using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.Imersao.Core.Application.Clientes.ViewModels;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;
using dpLibrary05;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Clientes.Queries
{
    public class ClienteQueryHandler:
           IRequestHandler<ClienteQuery, IEnumerable<ClienteViewModel>>
    {
        #region fields
        private readonly IDataAccess _dataAccess;
        #endregion


        #region contructors
        public ClienteQueryHandler(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        #endregion

        #region clientes
        public async Task<IEnumerable<ClienteViewModel>> Handle(ClienteQuery request, CancellationToken cancellationToken)
        {
            var sql = $@"
            SET TRANSACTION ISOLATION LEVEL SNAPSHOT;

            SELECT 
		        cliente.CdCliente, 
                Empresa.razao AS Razao
	        FROM cliente 
                INNER JOIN Empresa 
                    ON Empresa.empresaid = cliente.empresaid
                        AND Empresa.cdempresa = cliente.cdempresa
                        AND Empresa.cdfilial = cliente.cdfilial

            /**where**/	
            /**orderby**/
            ";
            var builder = new SqlBuilder();
            var selector = builder.AddTemplate(sql);

            builder.Where("Empresa.stativo = 1");

            builder.OrderBy("Empresa.razao DESC");

            var cmd = new CommandDefinition(selector.RawSql, selector.Parameters, flags: CommandFlags.NoCache);

            return _dataAccess.Connection.Query<ClienteViewModel>(cmd);
        }

        #endregion
    }
}
