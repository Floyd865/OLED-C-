namespace AP3_AppliC
{
    partial class FormVehicule
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
            cbVehicule = new ComboBox();
            lbDetails = new ListBox();
            gbInfos = new GroupBox();
            cbManuelle = new CheckBox();
            tbNbPlaces = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbDesignation = new TextBox();
            tbImmatriculation = new TextBox();
            label3 = new Label();
            label2 = new Label();
            bsVehicule = new BindingSource(components);
            btnAction = new Button();
            btnFermer = new Button();
            btnSupprimer = new Button();
            gbInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsVehicule).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 3;
            label1.Text = "Gestion des Véhicules";
            label1.Click += label1_Click;
            // 
            // cbVehicule
            // 
            cbVehicule.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehicule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbVehicule.FormattingEnabled = true;
            cbVehicule.Location = new Point(54, 69);
            cbVehicule.Margin = new Padding(3, 2, 3, 2);
            cbVehicule.Name = "cbVehicule";
            cbVehicule.Size = new Size(529, 29);
            cbVehicule.TabIndex = 4;
            cbVehicule.SelectedIndexChanged += cbVehicule_SelectedIndexChanged;
            // 
            // lbDetails
            // 
            lbDetails.FormattingEnabled = true;
            lbDetails.HorizontalScrollbar = true;
            lbDetails.ItemHeight = 15;
            lbDetails.Location = new Point(67, 156);
            lbDetails.Margin = new Padding(3, 2, 3, 2);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(666, 139);
            lbDetails.TabIndex = 5;
            lbDetails.Visible = false;
            // 
            // gbInfos
            // 
            gbInfos.Controls.Add(cbManuelle);
            gbInfos.Controls.Add(tbNbPlaces);
            gbInfos.Controls.Add(label6);
            gbInfos.Controls.Add(label7);
            gbInfos.Controls.Add(tbDesignation);
            gbInfos.Controls.Add(tbImmatriculation);
            gbInfos.Controls.Add(label3);
            gbInfos.Controls.Add(label2);
            gbInfos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbInfos.ForeColor = SystemColors.ControlLight;
            gbInfos.Location = new Point(58, 153);
            gbInfos.Margin = new Padding(3, 2, 3, 2);
            gbInfos.Name = "gbInfos";
            gbInfos.Padding = new Padding(3, 2, 3, 2);
            gbInfos.Size = new Size(685, 144);
            gbInfos.TabIndex = 8;
            gbInfos.TabStop = false;
            gbInfos.Text = "Informations du Véhicule";
            gbInfos.Visible = false;
            // 
            // cbManuelle
            // 
            cbManuelle.AutoSize = true;
            cbManuelle.Location = new Point(484, 88);
            cbManuelle.Name = "cbManuelle";
            cbManuelle.Size = new Size(15, 14);
            cbManuelle.TabIndex = 10;
            cbManuelle.UseVisualStyleBackColor = true;
            // 
            // tbNbPlaces
            // 
            tbNbPlaces.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNbPlaces.Location = new Point(484, 36);
            tbNbPlaces.Margin = new Padding(3, 2, 3, 2);
            tbNbPlaces.Name = "tbNbPlaces";
            tbNbPlaces.Size = new Size(173, 26);
            tbNbPlaces.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(401, 84);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 7;
            label6.Text = "Manuelle*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(353, 36);
            label7.Name = "label7";
            label7.Size = new Size(119, 19);
            label7.TabIndex = 6;
            label7.Text = "Nombre de places";
            // 
            // tbDesignation
            // 
            tbDesignation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDesignation.Location = new Point(129, 79);
            tbDesignation.Margin = new Padding(3, 2, 3, 2);
            tbDesignation.Name = "tbDesignation";
            tbDesignation.Size = new Size(213, 26);
            tbDesignation.TabIndex = 4;
            // 
            // tbImmatriculation
            // 
            tbImmatriculation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbImmatriculation.Location = new Point(129, 33);
            tbImmatriculation.Margin = new Padding(3, 2, 3, 2);
            tbImmatriculation.Name = "tbImmatriculation";
            tbImmatriculation.Size = new Size(213, 26);
            tbImmatriculation.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 81);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 1;
            label3.Text = "Designation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 0;
            label2.Text = "Immatriculation*";
            // 
            // bsVehicule
            // 
            bsVehicule.CurrentChanged += bsVehicule_CurrentChanged;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Black;
            btnAction.FlatStyle = FlatStyle.Popup;
            btnAction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction.ForeColor = SystemColors.ControlLightLight;
            btnAction.Location = new Point(54, 328);
            btnAction.Margin = new Padding(3, 2, 3, 2);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(122, 43);
            btnAction.TabIndex = 9;
            btnAction.Text = "AJOUTER";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(621, 328);
            btnFermer.Margin = new Padding(3, 2, 3, 2);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(118, 43);
            btnFermer.TabIndex = 10;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click_1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Black;
            btnSupprimer.FlatStyle = FlatStyle.Popup;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = SystemColors.ControlLightLight;
            btnSupprimer.Location = new Point(54, 328);
            btnSupprimer.Margin = new Padding(3, 2, 3, 2);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(122, 43);
            btnSupprimer.TabIndex = 11;
            btnSupprimer.Text = "SUPPRIMER";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Visible = false;
            btnSupprimer.Click += btnSupprimer_Click_1;
            // 
            // FormVehicule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(btnFermer);
            Controls.Add(btnAction);
            Controls.Add(cbVehicule);
            Controls.Add(label1);
            Controls.Add(gbInfos);
            Controls.Add(lbDetails);
            Controls.Add(btnSupprimer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVehicule";
            Text = "FormVehicule";
            Load += FormVehicule_Load;
            gbInfos.ResumeLayout(false);
            gbInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsVehicule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbVehicule;
        private ListBox lbDetails;
        private GroupBox gbInfos;
        private TextBox tbNbPlaces;
        private Label label6;
        private Label label7;
        private TextBox tbDesignation;
        private TextBox tbImmatriculation;
        private Label label3;
        private Label label2;
        private CheckBox cbManuelle;
        private BindingSource bsVehicule;
        private Button btnAction;
        private Button btnFermer;
        private Button btnSupprimer;
    }
}