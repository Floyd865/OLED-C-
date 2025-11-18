namespace AP3_AppliC
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            gestionDesElèvesToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            inscriptionToolStripMenuItem = new ToolStripMenuItem();
            gestionDesConducteursToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem1 = new ToolStripMenuItem();
            ajoutToolStripMenuItem = new ToolStripMenuItem();
            modificationToolStripMenuItem = new ToolStripMenuItem();
            gestionDesForfaitsToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem3 = new ToolStripMenuItem();
            ajoutToolStripMenuItem1 = new ToolStripMenuItem();
            gestionDesVéhiculesToolStripMenuItem = new ToolStripMenuItem();
            listeModificationEtSuppressionToolStripMenuItem = new ToolStripMenuItem();
            ajoutToolStripMenuItem2 = new ToolStripMenuItem();
            qUITTERToolStripMenuItem = new ToolStripMenuItem();
            bsUser = new BindingSource(components);
            panel1 = new Panel();
            btnQuitter = new Button();
            label2 = new Label();
            label1 = new Label();
            btnValider = new Button();
            tbMdp = new TextBox();
            tbLogin = new TextBox();
            panelPrincipal = new Panel();
            bsForfait = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsUser).BeginInit();
            panel1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsForfait).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(50, 50, 50);
            menuStrip1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDesElèvesToolStripMenuItem, gestionDesConducteursToolStripMenuItem, gestionDesForfaitsToolStripMenuItem, gestionDesVéhiculesToolStripMenuItem, qUITTERToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(932, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // gestionDesElèvesToolStripMenuItem
            // 
            gestionDesElèvesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem, inscriptionToolStripMenuItem });
            gestionDesElèvesToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            gestionDesElèvesToolStripMenuItem.Name = "gestionDesElèvesToolStripMenuItem";
            gestionDesElèvesToolStripMenuItem.Size = new Size(136, 23);
            gestionDesElèvesToolStripMenuItem.Text = "Gestion des Elèves";
            gestionDesElèvesToolStripMenuItem.Click += gestionDesElèvesToolStripMenuItem_Click;
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(264, 24);
            listeToolStripMenuItem.Text = "Liste et Attribution de forfaits";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // inscriptionToolStripMenuItem
            // 
            inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            inscriptionToolStripMenuItem.Size = new Size(264, 24);
            inscriptionToolStripMenuItem.Text = "Inscription";
            inscriptionToolStripMenuItem.Click += inscriptionToolStripMenuItem_Click;
            // 
            // gestionDesConducteursToolStripMenuItem
            // 
            gestionDesConducteursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem1, ajoutToolStripMenuItem, modificationToolStripMenuItem });
            gestionDesConducteursToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            gestionDesConducteursToolStripMenuItem.Name = "gestionDesConducteursToolStripMenuItem";
            gestionDesConducteursToolStripMenuItem.Size = new Size(162, 23);
            gestionDesConducteursToolStripMenuItem.Text = "Gestion des Moniteurs";
            // 
            // listeToolStripMenuItem1
            // 
            listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            listeToolStripMenuItem1.Size = new Size(159, 24);
            listeToolStripMenuItem1.Text = "Liste";
            listeToolStripMenuItem1.Click += listeToolStripMenuItem1_Click;
            // 
            // ajoutToolStripMenuItem
            // 
            ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            ajoutToolStripMenuItem.Size = new Size(159, 24);
            ajoutToolStripMenuItem.Text = "Ajout";
            ajoutToolStripMenuItem.Click += ajoutToolStripMenuItem_Click;
            // 
            // modificationToolStripMenuItem
            // 
            modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            modificationToolStripMenuItem.Size = new Size(159, 24);
            modificationToolStripMenuItem.Text = "Modification";
            modificationToolStripMenuItem.Click += modificationToolStripMenuItem_Click;
            // 
            // gestionDesForfaitsToolStripMenuItem
            // 
            gestionDesForfaitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem3, ajoutToolStripMenuItem1 });
            gestionDesForfaitsToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            gestionDesForfaitsToolStripMenuItem.Name = "gestionDesForfaitsToolStripMenuItem";
            gestionDesForfaitsToolStripMenuItem.Size = new Size(145, 23);
            gestionDesForfaitsToolStripMenuItem.Text = "Gestion des Forfaits";
            gestionDesForfaitsToolStripMenuItem.Click += gestionDesForfaitsToolStripMenuItem_Click;
            // 
            // listeToolStripMenuItem3
            // 
            listeToolStripMenuItem3.Name = "listeToolStripMenuItem3";
            listeToolStripMenuItem3.Size = new Size(203, 24);
            listeToolStripMenuItem3.Text = "Liste et Suppression";
            listeToolStripMenuItem3.Click += listeToolStripMenuItem3_Click;
            // 
            // ajoutToolStripMenuItem1
            // 
            ajoutToolStripMenuItem1.Name = "ajoutToolStripMenuItem1";
            ajoutToolStripMenuItem1.Size = new Size(203, 24);
            ajoutToolStripMenuItem1.Text = "Ajout";
            ajoutToolStripMenuItem1.Click += ajoutToolStripMenuItem1_Click;
            // 
            // gestionDesVéhiculesToolStripMenuItem
            // 
            gestionDesVéhiculesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeModificationEtSuppressionToolStripMenuItem, ajoutToolStripMenuItem2 });
            gestionDesVéhiculesToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            gestionDesVéhiculesToolStripMenuItem.Name = "gestionDesVéhiculesToolStripMenuItem";
            gestionDesVéhiculesToolStripMenuItem.Size = new Size(156, 23);
            gestionDesVéhiculesToolStripMenuItem.Text = "Gestion des véhicules";
            gestionDesVéhiculesToolStripMenuItem.Click += gestionDesVéhiculesToolStripMenuItem_Click;
            // 
            // listeModificationEtSuppressionToolStripMenuItem
            // 
            listeModificationEtSuppressionToolStripMenuItem.Name = "listeModificationEtSuppressionToolStripMenuItem";
            listeModificationEtSuppressionToolStripMenuItem.Size = new Size(288, 24);
            listeModificationEtSuppressionToolStripMenuItem.Text = "Liste, modification et suppression";
            listeModificationEtSuppressionToolStripMenuItem.Click += listeModificationEtSuppressionToolStripMenuItem_Click;
            // 
            // ajoutToolStripMenuItem2
            // 
            ajoutToolStripMenuItem2.Name = "ajoutToolStripMenuItem2";
            ajoutToolStripMenuItem2.Size = new Size(288, 24);
            ajoutToolStripMenuItem2.Text = "Ajout";
            ajoutToolStripMenuItem2.Click += ajoutToolStripMenuItem2_Click;
            // 
            // qUITTERToolStripMenuItem
            // 
            qUITTERToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            qUITTERToolStripMenuItem.Size = new Size(78, 23);
            qUITTERToolStripMenuItem.Text = "QUITTER";
            qUITTERToolStripMenuItem.Click += qUITTERToolStripMenuItem_Click;
            // 
            // bsUser
            // 
            bsUser.CurrentChanged += bsUser_CurrentChanged_1;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(btnQuitter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnValider);
            panel1.Controls.Add(tbMdp);
            panel1.Controls.Add(tbLogin);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-5, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1290, 597);
            panel1.TabIndex = 0;
            // 
            // btnQuitter
            // 
            btnQuitter.Font = new Font("Segoe UI Semibold", 9F);
            btnQuitter.Location = new Point(24, 49);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(75, 23);
            btnQuitter.TabIndex = 5;
            btnQuitter.Text = "QUITTER";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(319, 231);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(319, 142);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Identifiant";
            // 
            // btnValider
            // 
            btnValider.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnValider.FlatAppearance.BorderSize = 3;
            btnValider.Font = new Font("Segoe UI Semibold", 12F);
            btnValider.Location = new Point(402, 346);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(118, 37);
            btnValider.TabIndex = 2;
            btnValider.Text = "VALIDER";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // tbMdp
            // 
            tbMdp.BackColor = SystemColors.ScrollBar;
            tbMdp.Location = new Point(319, 249);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(293, 23);
            tbMdp.TabIndex = 1;
            tbMdp.UseSystemPasswordChar = true;
            tbMdp.TextChanged += textBox2_TextChanged;
            // 
            // tbLogin
            // 
            tbLogin.BackColor = SystemColors.ScrollBar;
            tbLogin.Location = new Point(319, 160);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(293, 23);
            tbLogin.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BackgroundImage = Properties.Resources.logo_cds49;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Zoom;
            panelPrincipal.BorderStyle = BorderStyle.Fixed3D;
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Location = new Point(0, 32);
            panelPrincipal.Margin = new Padding(4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(934, 489);
            panelPrincipal.TabIndex = 1;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // bsForfait
            // 
            bsForfait.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 519);
            ControlBox = false;
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            Text = "CDS 49 Administration";
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsForfait).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionDesElèvesToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem inscriptionToolStripMenuItem;
        private ToolStripMenuItem gestionDesConducteursToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem1;
        private ToolStripMenuItem ajoutToolStripMenuItem;
        private ToolStripMenuItem qUITTERToolStripMenuItem;
        private ToolStripMenuItem gestionDesForfaitsToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem3;
        private ToolStripMenuItem modificationToolStripMenuItem;
        private ToolStripMenuItem ajoutToolStripMenuItem1;
        private BindingSource bsUser;
        private Panel panel1;
        private Button btnQuitter;
        private Label label2;
        private Label label1;
        private Button btnValider;
        private TextBox tbMdp;
        private TextBox tbLogin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChoixForfait;
        private Panel panelPrincipal;
        private BindingSource bsForfait;
        private ToolStripMenuItem gestionDesVéhiculesToolStripMenuItem;
        private ToolStripMenuItem listeModificationEtSuppressionToolStripMenuItem;
        private ToolStripMenuItem ajoutToolStripMenuItem2;
    }
}