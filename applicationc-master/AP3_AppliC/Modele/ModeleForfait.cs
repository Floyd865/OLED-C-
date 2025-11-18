using AP3_AppliC.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_AppliC.Modele
{
    public static class ModeleForfait
    {
        public static List<Forfait> listeForfaits()
        {
            return Modele.Connexion.MonModel.Forfaits.ToList();
        }
        public static Forfait RecupererForfait(int idForfait)
        {
            Forfait unF = new Forfait();
            try
            {
                unF = Modele.Connexion.MonModel.Forfaits.First(x => x.Idforfait == idForfait);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unF;
        }
        public static bool SupprimerForfait(int idForfait)
        {
            bool vretour = true;
            try
            {
                Forfait monF = RecupererForfait(idForfait);
                Modele.Connexion.MonModel.Forfaits.Remove(monF);
                Modele.Connexion.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutForfait(string nom, string description, string contenu, int prix, int heures, int? prixHoraire)
        {
            Forfait unF;
            bool vretour = true;
            try
            {
                unF = new Forfait();
                unF.Libelleforfait = nom;
                unF.Descriptionforfait = description;
                unF.Contenuforfait = contenu;
                unF.Prixforfait = prix;
                unF.Nbheures = heures;
                unF.Prixhoraire = prixHoraire;

                Modele.Connexion.MonModel.Forfaits.Add(unF);
                Modele.Connexion.MonModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
    }
}
