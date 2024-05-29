namespace ClubMonteVerde.Views.Entrada
{
    partial class Access
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
            txtScann = new TextBox();
            lblEscanear = new Label();
            btnSearch = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtScann
            // 
            txtScann.Location = new Point(28, 44);
            txtScann.Name = "txtScann";
            txtScann.Size = new Size(100, 23);
            txtScann.TabIndex = 0;
            // 
            // lblEscanear
            // 
            lblEscanear.AutoSize = true;
            lblEscanear.Location = new Point(28, 26);
            lblEscanear.Name = "lblEscanear";
            lblEscanear.Size = new Size(53, 15);
            lblEscanear.TabIndex = 1;
            lblEscanear.Text = "Escanear";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(134, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEscanear);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtScann);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 350);
            panel2.TabIndex = 4;
            // 
            // Access
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Access";
            Text = "Access";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtScann;
        private Label lblEscanear;
        private Button btnSearch;
        private Panel panel1;
        private Panel panel2;
    }
}