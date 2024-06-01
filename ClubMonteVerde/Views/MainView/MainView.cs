using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMonteVerde.Views.MainView
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateEvent();
        }

        public event EventHandler? ScannQrCode;
        public event EventHandler? ShowEnterSociosList;
        public event EventHandler? ShowEnterVisitsList;
        public event EventHandler? AddVisit;
        public event EventHandler? AddSocio;
        public event EventHandler? ShowAllSociosList;
        public event EventHandler? AddMembership;
        public event EventHandler? ShowAllMembershipList;

        private void AssociateEvent()
        {
            btnScannQR.ItemClick += delegate { ScannQrCode?.Invoke(this, EventArgs.Empty); };
            btnShowEnterSocios.ItemClick += delegate { ShowEnterSociosList?.Invoke(this, EventArgs.Empty); };
            btnShowEnterVisits.ItemClick += delegate { ShowEnterVisitsList?.Invoke(this, EventArgs.Empty); };
            btnAddVisit.ItemClick += delegate { AddVisit?.Invoke(this, EventArgs.Empty); };
            btnAddSocio.ItemClick += delegate { AddSocio?.Invoke(this, EventArgs.Empty); };
            btnShowAllSocios.ItemClick += delegate { ShowAllSociosList?.Invoke(this, EventArgs.Empty); };
            btnAddMembership.ItemClick += delegate { AddMembership?.Invoke(this, EventArgs.Empty); };
            btnShowAllMembership.ItemClick += delegate { ShowAllMembershipList?.Invoke(this, EventArgs.Empty); };
        }

        public void CloseActiveForm()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        public void CloseMainView()
        {
            this.Close();
        }

        public void ShowFirstView()
        {

        }

        public void UserHasPermissions(bool hasPermission)
        {
            ribbonPage2.Visible = hasPermission;
        }
    }
}