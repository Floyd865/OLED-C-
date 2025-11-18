using AP3_AppliC;
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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace AP3_AppliC
{
    public partial class FormVehicule : Form
    {
        private EtatGestion etat;
        public FormVehicule(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }
        public void RemplirListeVehicule()
        {

            cbVehicule.ValueMember = "Idvehicule";//permet de stocker l'identifiant
            cbVehicule.DisplayMember = "Immatriculation";
            bsVehicule.DataSource = Modele.ModeleVehicule.listeVehicules();
            cbVehicule.DataSource = bsVehicule;
            cbVehicule.SelectedIndex = -1;
        }
        private void FormVehicule_Load(object sender, EventArgs e)
        {
            if (etat == EtatGestion.Read) // MODE CONSULTATION/LISTE
            {
                label1.Text = "Gestion des Véhicules : Liste en consultation";

                // Charger les véhicules
                RemplirListeVehicule();

                // AFFICHER les éléments de consultation
                cbVehicule.Visible = true;

                // MASQUER les éléments qui apparaîtront à la sélection
                lbDetails.Visible = false;
                btnSupprimer.Visible = false;

                // MASQUER les éléments d'ajout
                gbInfos.Visible = false;
                btnAction.Visible = false;
            }
            else if (etat == EtatGestion.Create) // MODE AJOUT
            {
                label1.Text = "Gestion des Véhicules : Ajout";

                // Nettoyer les champs
                tbImmatriculation.Clear();
                tbDesignation.Clear();
                tbNbPlaces.Clear();
                cbManuelle.Checked = false;

                // MASQUER les éléments de consultation
                cbVehicule.Visible = false;
                lbDetails.Visible = false;
                btnSupprimer.Visible = false;

                // AFFICHER les éléments d'ajout
                gbInfos.Visible = true;
                btnAction.Visible = true;
                btnAction.Text = "AJOUTER";
            }
        }

        private void lbDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tbPrix_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbHeures_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbPrixHoraire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void bsVehicule_CurrentChanged(object sender, EventArgs e)
        {
            if (cbVehicule.SelectedIndex != -1)
            {
                lbDetails.Items.Clear();
                Vehicule V = (Vehicule)bsVehicule.Current;
                lbDetails.Items.Add("Identifiant : " + V.Idvehicule);
                lbDetails.Items.Add("Immatriculation : " + V.Immatriculation);
                if (V.Nbpassagers is not null)
                {
                    lbDetails.Items.Add("Nombre de places : " + V.Nbpassagers);
                }
                if (V.Designation is not null)
                {
                    lbDetails.Items.Add("Designation : " + V.Designation);
                }
                if (V.Manuel == true)
                {
                    lbDetails.Items.Add("Manuelle : oui");
                }
                else
                {
                    lbDetails.Items.Add("Manuelle : non");
                }
                lbDetails.Visible = true;
                btnSupprimer.Visible = true;
            }
            else
                lbDetails.Visible = false;
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (cbVehicule.SelectedIndex != -1)
            {
                Vehicule V = (Vehicule)bsVehicule.Current;
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce véhicule : " + V.Immatriculation + " ?",
                    "Suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Modele.ModeleVehicule.SupprimerVehicule(V.Idvehicule))
                    {
                        MessageBox.Show("Véhicule supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemplirListeVehicule(); // Recharger la liste
                        lbDetails.Visible = false;
                        btnSupprimer.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la suppression du véhicule : \nImpossible de le supprimer, des éléments liés existent",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbImmatriculation.Text))
            {
                int? nbPlace = null;
                if (!string.IsNullOrWhiteSpace(tbNbPlaces.Text))
                {
                    nbPlace = Convert.ToInt32(tbNbPlaces.Text);
                }

                string designation = string.IsNullOrWhiteSpace(tbDesignation.Text) ? null : tbDesignation.Text;

                if (Modele.ModeleVehicule.AjoutVehicule(tbImmatriculation.Text, designation, nbPlace, cbManuelle.Checked))
                {
                    MessageBox.Show("Véhicule ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur dans l'ajout du véhicule", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enregistrement impossible : L'immatriculation est obligatoire", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsVehicule_CurrentChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
