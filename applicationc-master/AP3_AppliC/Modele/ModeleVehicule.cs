using AP3_AppliC.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_AppliC.Modele
{
    public static class ModeleVehicule
    {
        public static List<Vehicule> listeVehicules()
        {
            return Modele.Connexion.MonModel.Vehicules.ToList();
        }
        public static Vehicule RecupererVehicule(int idVehicule)
        {
            Vehicule unV = new Vehicule();
            try
            {
                unV = Modele.Connexion.MonModel.Vehicules.First(x => x.Idvehicule == idVehicule);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unV;
        }
        public static bool SupprimerVehicule(int idVehicule)
        {
            bool vretour = true;
            try
            {
                Vehicule monV = RecupererVehicule(idVehicule);
                Modele.Connexion.MonModel.Vehicules.Remove(monV);
                Modele.Connexion.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutVehicule(string immatriculation, string? designation, int? nbPassager, bool manuelle)
        {
            Vehicule unV;
            bool vretour = true;
            try
            {
                unV = new Vehicule();
                unV.Immatriculation = immatriculation;
                unV.Designation = designation;
                unV.Nbpassagers = nbPassager;
                unV.Manuel = manuelle;

                Modele.Connexion.MonModel.Vehicules.Add(unV);
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
