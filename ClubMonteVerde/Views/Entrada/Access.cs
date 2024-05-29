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
    public partial class Access : Form, IAccess
    {
        public Access()
        {
            InitializeComponent();
            AssociateEvent();
        }

        public event EventHandler SearchClient;

        private void AssociateEvent()
        {
            btnSearch.Click += delegate { SearchClient?.Invoke(this, EventArgs.Empty); };

            txtScann.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchClient?.Invoke(this, EventArgs.Empty);
                    e.Handled = true;
                }
            };
        }
        public void ResetForm()
        {

        }

        public void SetData()
        {

        }

        public string GetQrValue()
        {
            return txtScann.Text;
        }
    }
}
