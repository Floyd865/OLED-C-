namespace AP3_AppliC
{
    partial class FormForfaits
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
            cbForfaits = new ComboBox();
            label1 = new Label();
            bsForfaits = new BindingSource(components);
            lbDetails = new ListBox();
            btnSupprimer = new Button();
            btnFermer = new Button();
            btnAction = new Button();
            gbInfos = new GroupBox();
            tbPrixHoraire = new TextBox();
            tbHeures = new TextBox();
            tbPrix = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbContenu = new TextBox();
            tbDescription = new TextBox();
            tbNom = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)bsForfaits).BeginInit();
            gbInfos.SuspendLayout();
            SuspendLayout();
            // 
            // cbForfaits
            // 
            cbForfaits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbForfaits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbForfaits.FormattingEnabled = true;
            cbForfaits.Location = new Point(72, 66);
            cbForfaits.Margin = new Padding(3, 2, 3, 2);
            cbForfaits.Name = "cbForfaits";
            cbForfaits.Size = new Size(538, 29);
            cbForfaits.TabIndex = 0;
            cbForfaits.SelectedIndexChanged += cbForfaits_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(72, 28);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 1;
            label1.Text = "Gestion des Forfaits";
            // 
            // bsForfaits
            // 
            bsForfaits.CurrentChanged += bsForfaits_CurrentChanged;
            // 
            // lbDetails
            // 
            lbDetails.FormattingEnabled = true;
            lbDetails.HorizontalScrollbar = true;
            lbDetails.ItemHeight = 15;
            lbDetails.Location = new Point(72, 120);
            lbDetails.Margin = new Padding(3, 2, 3, 2);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(666, 139);
            lbDetails.TabIndex = 2;
            lbDetails.Visible = false;
            lbDetails.SelectedIndexChanged += lbDetails_SelectedIndexChanged;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Black;
            btnSupprimer.FlatStyle = FlatStyle.Popup;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = SystemColors.ControlLightLight;
            btnSupprimer.Location = new Point(74, 273);
            btnSupprimer.Margin = new Padding(3, 2, 3, 2);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(122, 43);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "SUPPRIMER";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Visible = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(620, 273);
            btnFermer.Margin = new Padding(3, 2, 3, 2);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(118, 43);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Black;
            btnAction.FlatStyle = FlatStyle.Popup;
            btnAction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction.ForeColor = SystemColors.ControlLightLight;
            btnAction.Location = new Point(75, 273);
            btnAction.Margin = new Padding(3, 2, 3, 2);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(122, 43);
            btnAction.TabIndex = 6;
            btnAction.Text = "AJOUTER";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Visible = false;
            btnAction.Click += btnAction_Click_1;
            // 
            // gbInfos
            // 
            gbInfos.Controls.Add(tbPrixHoraire);
            gbInfos.Controls.Add(tbHeures);
            gbInfos.Controls.Add(tbPrix);
            gbInfos.Controls.Add(label5);
            gbInfos.Controls.Add(label6);
            gbInfos.Controls.Add(label7);
            gbInfos.Controls.Add(tbContenu);
            gbInfos.Controls.Add(tbDescription);
            gbInfos.Controls.Add(tbNom);
            gbInfos.Controls.Add(label4);
            gbInfos.Controls.Add(label3);
            gbInfos.Controls.Add(label2);
            gbInfos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbInfos.ForeColor = SystemColors.ControlLight;
            gbInfos.Location = new Point(72, 116);
            gbInfos.Margin = new Padding(3, 2, 3, 2);
            gbInfos.Name = "gbInfos";
            gbInfos.Padding = new Padding(3, 2, 3, 2);
            gbInfos.Size = new Size(685, 144);
            gbInfos.TabIndex = 7;
            gbInfos.TabStop = false;
            gbInfos.Text = "Informations du Forfait";
            gbInfos.Visible = false;
            // 
            // tbPrixHoraire
            // 
            tbPrixHoraire.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrixHoraire.Location = new Point(444, 104);
            tbPrixHoraire.Margin = new Padding(3, 2, 3, 2);
            tbPrixHoraire.Name = "tbPrixHoraire";
            tbPrixHoraire.Size = new Size(213, 26);
            tbPrixHoraire.TabIndex = 11;
            tbPrixHoraire.KeyPress += tbPrixHoraire_KeyPress;
            // 
            // tbHeures
            // 
            tbHeures.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHeures.Location = new Point(444, 66);
            tbHeures.Margin = new Padding(3, 2, 3, 2);
            tbHeures.Name = "tbHeures";
            tbHeures.Size = new Size(213, 26);
            tbHeures.TabIndex = 10;
            tbHeures.KeyPress += tbHeures_KeyPress;
            // 
            // tbPrix
            // 
            tbPrix.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrix.Location = new Point(444, 27);
            tbPrix.Margin = new Padding(3, 2, 3, 2);
            tbPrix.Name = "tbPrix";
            tbPrix.Size = new Size(213, 26);
            tbPrix.TabIndex = 9;
            tbPrix.TextChanged += tbPrix_TextChanged;
            tbPrix.KeyPress += tbPrix_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(353, 104);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 8;
            label5.Text = "Prix horaire";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(353, 66);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 7;
            label6.Text = "Heures*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(353, 27);
            label7.Name = "label7";
            label7.Size = new Size(37, 19);
            label7.TabIndex = 6;
            label7.Text = "Prix*";
            // 
            // tbContenu
            // 
            tbContenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContenu.Location = new Point(103, 104);
            tbContenu.Margin = new Padding(3, 2, 3, 2);
            tbContenu.Name = "tbContenu";
            tbContenu.Size = new Size(213, 26);
            tbContenu.TabIndex = 5;
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.Location = new Point(103, 66);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(213, 26);
            tbDescription.TabIndex = 4;
            // 
            // tbNom
            // 
            tbNom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNom.Location = new Point(103, 27);
            tbNom.Margin = new Padding(3, 2, 3, 2);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(213, 26);
            tbNom.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 2;
            label4.Text = "Contenu*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 1;
            label3.Text = "Description*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "Nom*";
            // 
            // FormForfaits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(845, 338);
            Controls.Add(btnFermer);
            Controls.Add(btnSupprimer);
            Controls.Add(label1);
            Controls.Add(cbForfaits);
            Controls.Add(btnAction);
            Controls.Add(gbInfos);
            Controls.Add(lbDetails);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormForfaits";
            Text = "FormForfaits";
            Load += FormForfaits_Load;
            ((System.ComponentModel.ISupportInitialize)bsForfaits).EndInit();
            gbInfos.ResumeLayout(false);
            gbInfos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbForfaits;
        private Label label1;
        private BindingSource bsForfaits;
        private ListBox lbDetails;
        private Button btnSupprimer;
        private Button btnFermer;
        private Button btnAction;
        private GroupBox gbInfos;
        private TextBox tbContenu;
        private TextBox tbDescription;
        private TextBox tbNom;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbPrixHoraire;
        private TextBox tbHeures;
        private TextBox tbPrix;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}