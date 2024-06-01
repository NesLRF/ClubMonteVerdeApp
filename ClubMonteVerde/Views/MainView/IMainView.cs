using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Views.MainView
{
    public interface IMainView
    {
        event EventHandler? NewQrCode;
        event EventHandler? ShowContainers;
    }
}
