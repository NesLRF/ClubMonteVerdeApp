using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Views.MainView
{
    public interface IMainView
    {
        void CloseActiveForm();
        void UserHasPermissions(bool hasPermission);
        void CloseMainView();
        void ShowFirstView();

        event EventHandler? ScannQrCode;
        event EventHandler? ShowEnterSociosList;
        event EventHandler? ShowEnterVisitsList;
        event EventHandler? AddVisit;
        event EventHandler? AddSocio;
        event EventHandler? ShowAllSociosList;
        event EventHandler? AddMembership;
        event EventHandler? ShowAllMembershipList;
    }
}
