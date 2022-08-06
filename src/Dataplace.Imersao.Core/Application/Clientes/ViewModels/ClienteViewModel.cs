using Dataplace.Core.Application.Contracts.Results;
using Dataplace.Core.Application.ViewModels.Contracts;
using Dataplace.Core.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Clientes.ViewModels
{
    public class ClienteViewModel :  ISelectableViewModel,  IEquatable<ClienteViewModel>
    {
        public string CdCliente { get; set; }
        public string Razao { get; set; }

        public bool IsSelected { get; set; }
        private IResult _result;

        public bool Equals(ClienteViewModel other)
        {
            return other.CdCliente == this.CdCliente;
        }
    }
}
