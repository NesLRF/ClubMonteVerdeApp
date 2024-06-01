using ClubMonteVerde.Classes.Membership;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMonteVerde.Views.Entrada
{
    public partial class ScannQR : DevExpress.XtraEditors.XtraForm, IScannQR
    {
        public ScannQR()
        {
            InitializeComponent();
            AssociateEvent();
        }

        public event EventHandler SearchQrValue;

        private void AssociateEvent()
        {
            btnSearch.Click += delegate { SearchQrValue?.Invoke(this, EventArgs.Empty); };
            txtScann.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchQrValue?.Invoke(this, EventArgs.Empty);
                    e.Handled = true;
                }
            };
        }

        public static ScannQR? instance;
        public static ScannQR GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ScannQR();
                instance.AutoScaleMode = AutoScaleMode.Font;
                instance.AutoSize = true;
                parentContainer.Resize += (sender, e) =>
                {
                    instance.ClientSize = parentContainer.ClientSize;
                };
                parentContainer.WindowState = instance.WindowState;
                parentContainer.ClientSize = parentContainer.ClientSize;
                parentContainer.MinimumSize = instance.MinimumSize;
                parentContainer.MaximumSize = new Size(instance.MinimumSize.Width, instance.MinimumSize.Height);
                parentContainer.AutoSize = true;
                instance.MdiParent = parentContainer;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
            }
            instance.BringToFront();
            instance.Show();
            return instance;
        }

        public string GetQrValue()
        {
            return txtScann.Text;
        }

        public void resetForm()
        {
            txtScann.Text = string.Empty;
        }

        public void SetData(IList<ShowMembershipData> membresia)
        {
            gridControl1.DataSource = membresia;
        }
    }
}