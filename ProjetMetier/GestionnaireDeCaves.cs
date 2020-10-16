using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            LesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);

            // A vous de jouer
        }

        public int NbBouteilles(string unNomDeCave)
        {
            int nbBouteilles = 0;

            

            nbBouteilles = lesCaves.Values.Count;
            
            
            // A vous de jouer
            return nbBouteilles;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            int nbBouteillesDeRouges = 0;

            

            // A vous de jouer
            return nbBouteillesDeRouges;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            double valeurDeLaCave = 0;

            
            // A vous de jouer
            return valeurDeLaCave;
        }
    }
}
