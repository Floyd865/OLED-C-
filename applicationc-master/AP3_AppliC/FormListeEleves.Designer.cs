namespace AP3_AppliC
{
    partial class FormListeEleves
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
            label1 = new Label();
            dgvEleves = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voirSesForfaitsToolStripMenuItem = new ToolStripMenuItem();
            attribuerUnForfaitToolStripMenuItem = new ToolStripMenuItem();
            bsEleves = new BindingSource(components);
            dgvForfaits = new DataGridView();
            bsForfaitsparEleve = new BindingSource(components);
            label2 = new Label();
            btnFermer = new Button();
            gbInfos = new GroupBox();
            tbEmail = new TextBox();
            tbPrenom = new TextBox();
            tbNom = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbTel = new TextBox();
            tbMdp = new TextBox();
            tbDateN = new TextBox();
            btnAction = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEleves).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsEleves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvForfaits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsForfaitsparEleve).BeginInit();
            gbInfos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(61, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Liste des Elèves";
            // 
            // dgvEleves
            // 
            dgvEleves.AllowUserToAddRows = false;
            dgvEleves.AllowUserToDeleteRows = false;
            dgvEleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEleves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEleves.ContextMenuStrip = contextMenuStrip1;
            dgvEleves.Location = new Point(61, 80);
            dgvEleves.Margin = new Padding(3, 2, 3, 2);
            dgvEleves.MultiSelect = false;
            dgvEleves.Name = "dgvEleves";
            dgvEleves.ReadOnly = true;
            dgvEleves.RowHeadersWidth = 51;
            dgvEleves.Size = new Size(770, 280);
            dgvEleves.TabIndex = 1;
            dgvEleves.CellContentClick += dgvEleves_CellContentClick;
            dgvEleves.CellMouseClick += dgvEleves_CellMouseClick;
            dgvEleves.Click += dgvEleves_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirSesForfaitsToolStripMenuItem, attribuerUnForfaitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(174, 48);
            // 
            // voirSesForfaitsToolStripMenuItem
            // 
            voirSesForfaitsToolStripMenuItem.Name = "voirSesForfaitsToolStripMenuItem";
            voirSesForfaitsToolStripMenuItem.Size = new Size(173, 22);
            voirSesForfaitsToolStripMenuItem.Text = "Voir ses forfaits";
            voirSesForfaitsToolStripMenuItem.Click += voirSesForfaitsToolStripMenuItem_Click;
            // 
            // attribuerUnForfaitToolStripMenuItem
            // 
            attribuerUnForfaitToolStripMenuItem.Name = "attribuerUnForfaitToolStripMenuItem";
            attribuerUnForfaitToolStripMenuItem.Size = new Size(173, 22);
            attribuerUnForfaitToolStripMenuItem.Text = "Attribuer un forfait";
            attribuerUnForfaitToolStripMenuItem.Click += attribuerUnForfaitToolStripMenuItem_Click;
            // 
            // dgvForfaits
            // 
            dgvForfaits.AllowUserToAddRows = false;
            dgvForfaits.AllowUserToDeleteRows = false;
            dgvForfaits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvForfaits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvForfaits.Location = new Point(555, 133);
            dgvForfaits.Margin = new Padding(3, 2, 3, 2);
            dgvForfaits.Name = "dgvForfaits";
            dgvForfaits.ReadOnly = true;
            dgvForfaits.RowHeadersWidth = 51;
            dgvForfaits.Size = new Size(349, 141);
            dgvForfaits.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(61, 385);
            label2.Name = "label2";
            label2.Size = new Size(541, 21);
            label2.TabIndex = 3;
            label2.Text = "click droit sur l'élève sélectionné pour voir ses forfaits ou en attribuer un.";
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(713, 374);
            btnFermer.Margin = new Padding(3, 2, 3, 2);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(118, 43);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // gbInfos
            // 
            gbInfos.Controls.Add(tbDateN);
            gbInfos.Controls.Add(tbMdp);
            gbInfos.Controls.Add(tbTel);
            gbInfos.Controls.Add(label8);
            gbInfos.Controls.Add(label7);
            gbInfos.Controls.Add(label6);
            gbInfos.Controls.Add(tbEmail);
            gbInfos.Controls.Add(tbPrenom);
            gbInfos.Controls.Add(tbNom);
            gbInfos.Controls.Add(label4);
            gbInfos.Controls.Add(label3);
            gbInfos.Controls.Add(label5);
            gbInfos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbInfos.ForeColor = SystemColors.ControlLight;
            gbInfos.Location = new Point(61, 133);
            gbInfos.Margin = new Padding(3, 2, 3, 2);
            gbInfos.Name = "gbInfos";
            gbInfos.Padding = new Padding(3, 2, 3, 2);
            gbInfos.Size = new Size(685, 161);
            gbInfos.TabIndex = 5;
            gbInfos.TabStop = false;
            gbInfos.Text = "Informations sur un élève";
            gbInfos.Visible = false;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(76, 114);
            tbEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(227, 26);
            tbEmail.TabIndex = 5;
            // 
            // tbPrenom
            // 
            tbPrenom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrenom.Location = new Point(76, 76);
            tbPrenom.Margin = new Padding(3, 2, 3, 2);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(227, 26);
            tbPrenom.TabIndex = 4;
            // 
            // tbNom
            // 
            tbNom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNom.Location = new Point(76, 37);
            tbNom.Margin = new Padding(3, 2, 3, 2);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(227, 26);
            tbNom.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 114);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 76);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 1;
            label3.Text = "Prénom";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 37);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 0;
            label5.Text = "Nom";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(319, 45);
            label6.Name = "label6";
            label6.Size = new Size(25, 19);
            label6.TabIndex = 6;
            label6.Text = "Tel";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(319, 81);
            label7.Name = "label7";
            label7.Size = new Size(92, 19);
            label7.TabIndex = 7;
            label7.Text = "Mot de passe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(319, 117);
            label8.Name = "label8";
            label8.Size = new Size(119, 19);
            label8.TabIndex = 8;
            label8.Text = "Date de naissance";
            // 
            // tbTel
            // 
            tbTel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTel.Location = new Point(447, 37);
            tbTel.Margin = new Padding(3, 2, 3, 2);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(227, 26);
            tbTel.TabIndex = 9;
            // 
            // tbMdp
            // 
            tbMdp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMdp.Location = new Point(447, 77);
            tbMdp.Margin = new Padding(3, 2, 3, 2);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(227, 26);
            tbMdp.TabIndex = 10;
            // 
            // tbDateN
            // 
            tbDateN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDateN.Location = new Point(447, 117);
            tbDateN.Margin = new Padding(3, 2, 3, 2);
            tbDateN.Name = "tbDateN";
            tbDateN.Size = new Size(227, 26);
            tbDateN.TabIndex = 11;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Black;
            btnAction.FlatStyle = FlatStyle.Popup;
            btnAction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction.ForeColor = SystemColors.ControlLightLight;
            btnAction.Location = new Point(61, 374);
            btnAction.Margin = new Padding(3, 2, 3, 2);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(122, 43);
            btnAction.TabIndex = 12;
            btnAction.Text = "AJOUTER";
            btnAction.UseVisualStyleBackColor = false;
            // 
            // FormListeEleves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(914, 443);
            Controls.Add(btnAction);
            Controls.Add(gbInfos);
            Controls.Add(btnFermer);
            Controls.Add(label2);
            Controls.Add(dgvForfaits);
            Controls.Add(dgvEleves);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListeEleves";
            Text = "Liste des Elèves";
            Load += FormListeEleves_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEleves).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsEleves).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvForfaits).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsForfaitsparEleve).EndInit();
            gbInfos.ResumeLayout(false);
            gbInfos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEleves;
        private BindingSource bsEleves;
        private DataGridView dgvForfaits;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem voirSesForfaitsToolStripMenuItem;
        private BindingSource bsForfaitsparEleve;
        private Label label2;
        private Button btnFermer;
        private ToolStripMenuItem attribuerUnForfaitToolStripMenuItem;
        private GroupBox gbInfos;
        private TextBox tbEmail;
        private TextBox tbPrenom;
        private TextBox tbNom;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tbDateN;
        private TextBox tbMdp;
        private TextBox tbTel;
        private Button btnAction;
    }
}