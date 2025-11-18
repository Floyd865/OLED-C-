using AP3_AppliC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using System.Windows.Forms.DataVisualization.Charting;

namespace AP3_AppliC
{
    public partial class FormMenu : Form
    {
        private EtatGestion etat;
        public FormMenu(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
            panel1.Size = new System.Drawing.Size(1500, 1000);
            panel1.Dock = DockStyle.Fill;
            this.chartChoixForfait = new System.Windows.Forms.DataVisualization.Charting.Chart();
        }
        private void ChargerDonneesGraphique()
        {
            // Nettoyer les séries existantes
            chartChoixForfait.Series.Clear();

            // Créer une nouvelle série
            Series serie = new Series("Forfaits");
            serie.ChartType = SeriesChartType.Pie;

            // Style du graphique
            serie.LabelForeColor = Color.White;
            serie["PieLabelStyle"] = "Outside";
            serie.BorderWidth = 2;
            serie.BorderColor = Color.White;

            // Ajouter la série au graphique
            chartChoixForfait.Series.Add(serie);

            // Configuration du titre
            chartChoixForfait.Titles.Clear();
            Title titre = new Title("Répartition des Forfaits");
            titre.Font = new Font("Segoe UI Semibold", 14);
            titre.ForeColor = Color.White;
            chartChoixForfait.Titles.Add(titre);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (etat == EtatGestion.Read)
            {
                menuStrip1.Visible = false;
                if (chartChoixForfait != null)
                {
                    chartChoixForfait.Visible = false;
                }
            }
            if (etat == EtatGestion.Create)
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                tbLogin.Visible = false;
                tbMdp.Visible = false;
                btnQuitter.Visible = false;
                btnValider.Visible = false;
                if (chartChoixForfait != null)
                {
                    chartChoixForfait.Visible = true;
                }
                ChargerDonneesGraphique();
            }
        }
        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListeEleves(AP3_AppliC.EtatGestion.Read));
        }

        private void listeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormForfaits(AP3_AppliC.EtatGestion.Read));
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMoniteurs(AP3_AppliC.EtatGestion.Read));
        }


        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMoniteurs(AP3_AppliC.EtatGestion.Create));
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMoniteurs(AP3_AppliC.EtatGestion.Update));
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new ArgumentException("Cette fonctionnalité n'est pas encore opérationnelle");
        }

        private void gestionDesForfaitsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormForfaits(AP3_AppliC.EtatGestion.Create));
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbMdp.Text != "")
            {
                string login = tbLogin.Text;
                string password = tbMdp.Text;
                string hashStocke = Controleur.RecupMdp(login);
                if (!string.IsNullOrEmpty(hashStocke) && BC.Verify(password, hashStocke))
                {
                    FormMenu formMenu = new FormMenu(AP3_AppliC.EtatGestion.Create);
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur de connection, veuillez vérifier vos informations", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enregistrement impossible : Il faut saisir tous les champs", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bsUser_CurrentChanged(object sender, EventArgs e)
        {
            tbLogin.Clear();
            tbMdp.Clear();
        }

        private void bsUser_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gestionDesVéhiculesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeModificationEtSuppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVehicule(AP3_AppliC.EtatGestion.Read));
        }

        private void ajoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVehicule(AP3_AppliC.EtatGestion.Create));
        }

        private void gestionDesElèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
