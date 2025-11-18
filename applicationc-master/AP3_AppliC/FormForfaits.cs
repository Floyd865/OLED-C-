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
    public partial class FormForfaits : Form
    {
        private EtatGestion etat;
        public FormForfaits(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }
        public void RemplirListeForfaits()
        {
            cbForfaits.ValueMember = "Idforfait";//permet de stocker l'identifiantS
            cbForfaits.DisplayMember = "Libelleforfait";
            bsForfaits.DataSource = Modele.ModeleForfait.listeForfaits();
            cbForfaits.DataSource = bsForfaits;
            cbForfaits.SelectedIndex = -1;
        }
        private void FormForfaits_Load(object sender, EventArgs e)
        {
            if (etat == EtatGestion.Read) // cas etat en lecture
            {
                label1.Text = "Gestion des Forfaits : Liste en consultation";
                RemplirListeForfaits();
                btnAction.Visible = false;
                lbDetails.Visible = false;
                btnSupprimer.Visible = false;
                gbInfos.Visible = false;
            }
            if (etat == EtatGestion.Create) // cas etat en create
            {
                label1.Text = "Gestion des Forfaits : Ajout";
                tbNom.Clear();
                tbDescription.Clear();
                tbContenu.Clear();
                tbPrix.Clear();
                tbHeures.Clear();
                tbPrixHoraire.Clear();
                gbInfos.Visible = true;
                btnAction.Visible = true;
                lbDetails.Visible = false;
                btnSupprimer.Visible = false;
                cbForfaits.Visible = false;
            }
        }

        private void cbForfaits_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsForfaits_CurrentChanged(sender, e);
        }

        private void bsForfaits_CurrentChanged(object sender, EventArgs e)
        {
            // si un forfait est sélectionné dans la liste
            if (cbForfaits.SelectedIndex != -1)
            {
                lbDetails.Items.Clear();
                // récupération du forfait sélectionné
                Forfait F = (Forfait)bsForfaits.Current;

                // mise à jour des infos du forfait dans la listBox
                lbDetails.Items.Add("Identifiant : " + F.Idforfait);
                lbDetails.Items.Add("Libellé : " + F.Libelleforfait);
                lbDetails.Items.Add("Description : " + F.Descriptionforfait);
                lbDetails.Items.Add("Contenu : " + F.Contenuforfait);
                lbDetails.Items.Add("Prix du forfait : " + F.Prixforfait);
                lbDetails.Items.Add("Nombre d'heure : " + F.Nbheures);
                if (F.Prixhoraire is not null)
                {
                    lbDetails.Items.Add("Prix à l'heure : " + F.Prixhoraire);
                }

                lbDetails.Visible = true;
                btnSupprimer.Visible = true;
            }
            else
                lbDetails.Visible = false;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // si un forfait est sélectionné dans la liste
            if (cbForfaits.SelectedIndex != -1)
            {
                Forfait F = (Forfait)bsForfaits.Current;
                if (MessageBox.Show("Etes vous sur de vouloir supprimer ce forfait :" + F.Idforfait, "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (Modele.ModeleForfait.SupprimerForfait(F.Idforfait))
                    {
                        FormForfaits_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la suppression du forfait : \nimpossible de le supprimer, des élèves sont inscrits", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAction_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNom.Text) &&
                !string.IsNullOrWhiteSpace(tbDescription.Text) &&
                !string.IsNullOrWhiteSpace(tbContenu.Text) &&
                !string.IsNullOrWhiteSpace(tbPrix.Text) &&
                !string.IsNullOrWhiteSpace(tbHeures.Text))
            {
                int prix = Convert.ToInt32(tbPrix.Text);
                int nbHeures = Convert.ToInt32(tbHeures.Text);

                int? prixHoraire = null;
                if (!string.IsNullOrWhiteSpace(tbPrixHoraire.Text))
                {
                    prixHoraire = Convert.ToInt32(tbPrixHoraire.Text);
                }

                if (Modele.ModeleForfait.AjoutForfait(tbNom.Text, tbDescription.Text, tbContenu.Text, prix, nbHeures, prixHoraire))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur dans l'ajout d'un forfait", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enregistrement impossible : Il faut saisir tous les champs", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPrix_TextChanged(object sender, EventArgs e)
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
    }
}
