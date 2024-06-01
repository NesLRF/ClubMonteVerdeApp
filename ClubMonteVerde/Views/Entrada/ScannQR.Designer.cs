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
            components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            showMembershipDataBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMembresia = new DevExpress.XtraGrid.Columns.GridColumn();
            colMembresiaTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            colMembresiaTitular = new DevExpress.XtraGrid.Columns.GridColumn();
            colMembresiaTitularTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            colMembresiaTitularGradoFamiliar = new DevExpress.XtraGrid.Columns.GridColumn();
            colMembresiaTitularEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colMembresiaFechaBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            panelTop = new Panel();
            btnSearch = new DevExpress.XtraEditors.ButtonEdit();
            lblScann = new Label();
            txtScann = new DevExpress.XtraEditors.TextEdit();
            panelFill = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showMembershipDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtScann.Properties).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // gridView2
            // 
            gridView2.GridControl = gridControl1;
            gridView2.Name = "gridView2";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = showMembershipDataBindingSource;
            gridControl1.Dock = DockStyle.Fill;
            gridLevelNode1.LevelTemplate = gridView2;
            gridLevelNode1.RelationName = "Familiares";
            gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(921, 376);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1, gridView2 });
            // 
            // showMembershipDataBindingSource
            // 
            showMembershipDataBindingSource.DataSource = typeof(Classes.Membership.ShowMembershipData);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMembresia, colMembresiaTipo, colMembresiaTitular, colMembresiaTitularTitulo, colMembresiaTitularGradoFamiliar, colMembresiaTitularEstatus, colMembresiaFechaBaja });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colMembresia
            // 
            colMembresia.FieldName = "Membresia";
            colMembresia.Name = "colMembresia";
            colMembresia.Visible = true;
            colMembresia.VisibleIndex = 0;
            // 
            // colMembresiaTipo
            // 
            colMembresiaTipo.FieldName = "MembresiaTipo";
            colMembresiaTipo.Name = "colMembresiaTipo";
            colMembresiaTipo.Visible = true;
            colMembresiaTipo.VisibleIndex = 1;
            // 
            // colMembresiaTitular
            // 
            colMembresiaTitular.FieldName = "MembresiaTitular";
            colMembresiaTitular.Name = "colMembresiaTitular";
            colMembresiaTitular.Visible = true;
            colMembresiaTitular.VisibleIndex = 2;
            // 
            // colMembresiaTitularTitulo
            // 
            colMembresiaTitularTitulo.FieldName = "MembresiaTitularTitulo";
            colMembresiaTitularTitulo.Name = "colMembresiaTitularTitulo";
            colMembresiaTitularTitulo.Visible = true;
            colMembresiaTitularTitulo.VisibleIndex = 3;
            // 
            // colMembresiaTitularGradoFamiliar
            // 
            colMembresiaTitularGradoFamiliar.FieldName = "MembresiaTitularGradoFamiliar";
            colMembresiaTitularGradoFamiliar.Name = "colMembresiaTitularGradoFamiliar";
            colMembresiaTitularGradoFamiliar.Visible = true;
            colMembresiaTitularGradoFamiliar.VisibleIndex = 4;
            // 
            // colMembresiaTitularEstatus
            // 
            colMembresiaTitularEstatus.FieldName = "MembresiaTitularEstatus";
            colMembresiaTitularEstatus.Name = "colMembresiaTitularEstatus";
            colMembresiaTitularEstatus.Visible = true;
            colMembresiaTitularEstatus.VisibleIndex = 5;
            // 
            // colMembresiaFechaBaja
            // 
            colMembresiaFechaBaja.FieldName = "MembresiaFechaBaja";
            colMembresiaFechaBaja.Name = "colMembresiaFechaBaja";
            colMembresiaFechaBaja.Visible = true;
            colMembresiaFechaBaja.VisibleIndex = 6;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(lblScann);
            panelTop.Controls.Add(txtScann);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(921, 100);
            panelTop.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.EditValue = "Buscar";
            btnSearch.Location = new Point(229, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph) });
            btnSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            btnSearch.Size = new Size(67, 28);
            btnSearch.TabIndex = 2;
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
            txtScann.Size = new Size(162, 28);
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
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showMembershipDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtScann.Properties).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblScann;
        private DevExpress.XtraEditors.TextEdit txtScann;
        private Panel panelFill;
        private DevExpress.XtraEditors.ButtonEdit btnSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BindingSource showMembershipDataBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMembresia;
        private DevExpress.XtraGrid.Columns.GridColumn colMembresiaTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colMembresiaTitular;
        private DevExpress.XtraGrid.Columns.GridColumn colMembresiaTitularTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colMembresiaTitularGradoFamiliar;
        private DevExpress.XtraGrid.Columns.GridColumn colMembresiaTitularEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colMembresiaFechaBaja;
    }
}