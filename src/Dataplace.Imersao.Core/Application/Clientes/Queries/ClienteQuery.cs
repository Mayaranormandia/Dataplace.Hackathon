using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Application.Clientes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Clientes.Queries
{
    public class ClienteQuery : QuerySort<IEnumerable<ClienteViewModel>>, IQuerySort<IEnumerable<ClienteViewModel>>
    {

    }
}
