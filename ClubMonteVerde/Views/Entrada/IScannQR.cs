using ClubMonteVerde.Classes.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Views.Entrada
{
    public interface IScannQR
    {
        string GetQrValue();
        void resetForm();

        void SetData(IList<ShowMembershipData> membresia, string userNombre, string userGrado, string estatus);

        event EventHandler SearchQrValue;
    }
}
