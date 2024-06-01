namespace ClubMonteVerde.Views.MainView
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnScannQR = new DevExpress.XtraBars.BarButtonItem();
            btnShowEnterSocios = new DevExpress.XtraBars.BarButtonItem();
            btnShowEnterVisits = new DevExpress.XtraBars.BarButtonItem();
            btnAddVisit = new DevExpress.XtraBars.BarButtonItem();
            btnAddSocio = new DevExpress.XtraBars.BarButtonItem();
            btnShowAllSocios = new DevExpress.XtraBars.BarButtonItem();
            btnAddMembership = new DevExpress.XtraBars.BarButtonItem();
            btnShowAllMembership = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            Registros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnScannQR, btnShowEnterSocios, btnShowEnterVisits, btnAddVisit, btnAddSocio, btnShowAllSocios, btnAddMembership, btnShowAllMembership });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 9;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
            ribbon.Size = new Size(1117, 201);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnScannQR
            // 
            btnScannQR.Caption = "Escanear QR";
            btnScannQR.Id = 1;
            btnScannQR.ImageOptions.Image = (Image)resources.GetObject("btnScannQR.ImageOptions.Image");
            btnScannQR.Name = "btnScannQR";
            btnScannQR.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnShowEnterSocios
            // 
            btnShowEnterSocios.Caption = "Administrar Entradas Socios";
            btnShowEnterSocios.Id = 2;
            btnShowEnterSocios.ImageOptions.Image = (Image)resources.GetObject("btnShowEnterSocios.ImageOptions.Image");
            btnShowEnterSocios.Name = "btnShowEnterSocios";
            btnShowEnterSocios.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnShowEnterVisits
            // 
            btnShowEnterVisits.Caption = "Administrar Entradas Visitas";
            btnShowEnterVisits.Id = 3;
            btnShowEnterVisits.ImageOptions.Image = (Image)resources.GetObject("btnShowEnterVisits.ImageOptions.Image");
            btnShowEnterVisits.Name = "btnShowEnterVisits";
            btnShowEnterVisits.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAddVisit
            // 
            btnAddVisit.Caption = "Registrar Visita";
            btnAddVisit.Id = 4;
            btnAddVisit.ImageOptions.Image = (Image)resources.GetObject("btnAddVisit.ImageOptions.Image");
            btnAddVisit.Name = "btnAddVisit";
            btnAddVisit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAddSocio
            // 
            btnAddSocio.Caption = "Nuevo Socio";
            btnAddSocio.Id = 5;
            btnAddSocio.ImageOptions.Image = (Image)resources.GetObject("btnAddSocio.ImageOptions.Image");
            btnAddSocio.Name = "btnAddSocio";
            btnAddSocio.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnShowAllSocios
            // 
            btnShowAllSocios.Caption = "Administrar Socios";
            btnShowAllSocios.Id = 6;
            btnShowAllSocios.ImageOptions.Image = (Image)resources.GetObject("btnShowAllSocios.ImageOptions.Image");
            btnShowAllSocios.Name = "btnShowAllSocios";
            btnShowAllSocios.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAddMembership
            // 
            btnAddMembership.Caption = "Nueva Membresía";
            btnAddMembership.Id = 7;
            btnAddMembership.ImageOptions.Image = (Image)resources.GetObject("btnAddMembership.ImageOptions.Image");
            btnAddMembership.Name = "btnAddMembership";
            btnAddMembership.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnShowAllMembership
            // 
            btnShowAllMembership.Caption = "Administrar Membresías";
            btnShowAllMembership.Id = 8;
            btnShowAllMembership.ImageOptions.Image = (Image)resources.GetObject("btnShowAllMembership.ImageOptions.Image");
            btnShowAllMembership.Name = "btnShowAllMembership";
            btnShowAllMembership.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, Registros });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Entrada";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnScannQR);
            ribbonPageGroup1.ItemLinks.Add(btnShowEnterSocios);
            ribbonPageGroup1.ItemLinks.Add(btnShowEnterVisits);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Acceso";
            // 
            // Registros
            // 
            Registros.ItemLinks.Add(btnAddVisit);
            Registros.Name = "Registros";
            Registros.Text = "Registros";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup3 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Administración";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnAddSocio);
            ribbonPageGroup2.ItemLinks.Add(btnShowAllSocios);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Socios";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnAddMembership);
            ribbonPageGroup3.ItemLinks.Add(btnShowAllMembership);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Membresías";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 525);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1117, 37);
            // 
            // defaultLookAndFeel1
            // 
            defaultLookAndFeel1.LookAndFeel.SkinName = "WXI";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 562);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "MainView";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnScannQR;
        private DevExpress.XtraBars.BarButtonItem btnShowEnterSocios;
        private DevExpress.XtraBars.BarButtonItem btnShowEnterVisits;
        private DevExpress.XtraBars.BarButtonItem btnAddVisit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Registros;
        private DevExpress.XtraBars.BarButtonItem btnAddSocio;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnShowAllSocios;
        private DevExpress.XtraBars.BarButtonItem btnAddMembership;
        private DevExpress.XtraBars.BarButtonItem btnShowAllMembership;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}