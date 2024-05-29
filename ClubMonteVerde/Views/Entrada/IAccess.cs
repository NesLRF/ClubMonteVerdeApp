using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Views.Entrada
{
    public interface IAccess
    {
        string GetQrValue();

        void ResetForm();
        void SetData();

        event EventHandler SearchClient;
    }
}
