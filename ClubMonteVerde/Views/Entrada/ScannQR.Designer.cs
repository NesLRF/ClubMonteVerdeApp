namespace ClubMonteVerde.Views.Entrada
{
    partial class ScannQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            lblScann = new Label();
            txtScann = new DevExpress.XtraEditors.TextEdit();
            panelFill = new Panel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtScann.Properties).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonEdit1);
            panelTop.Controls.Add(lblScann);
            panelTop.Controls.Add(txtScann);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(921, 100);
            panelTop.TabIndex = 0;
            // 
            // buttonEdit1
            // 
            buttonEdit1.EditValue = "Buscar";
            buttonEdit1.Location = new Point(229, 44);
            buttonEdit1.Name = "buttonEdit1";
            buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph) });
            buttonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            buttonEdit1.Size = new Size(74, 20);
            buttonEdit1.TabIndex = 2;
            // 
            // lblScann
            // 
            lblScann.AutoSize = true;
            lblScann.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScann.Location = new Point(41, 23);
            lblScann.Name = "lblScann";
            lblScann.Size = new Size(71, 18);
            lblScann.TabIndex = 1;
            lblScann.Text = "Escanear";
            // 
            // txtScann
            // 
            txtScann.Location = new Point(41, 44);
            txtScann.Name = "txtScann";
            txtScann.Size = new Size(162, 20);
            txtScann.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(gridControl1);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 100);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(921, 376);
            panelFill.TabIndex = 1;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(921, 376);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // ScannQR
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 476);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScannQR";
            Text = "ScannQR";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtScann.Properties).EndInit();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblScann;
        private DevExpress.XtraEditors.TextEdit txtScann;
        private Panel panelFill;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}