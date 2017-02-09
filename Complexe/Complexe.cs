using System;
using System.Text;

namespace Complexe
{
    class Complexe
    {
        private double partieReelle;                                  //partie réelle
        private double partieImaginaire;                                  //partie imaginaire

        public double PartieReelle
        {
            get { return partieReelle; }
            set { partieReelle = value; }
        }

        public double PartieImaginaire
        {
            get { return partieImaginaire; }
            set { partieImaginaire = value; }
        }

        public Complexe() { }

        public Complexe(double partieReelle, double partieImaginaire)
        {
            this.partieReelle = partieReelle;
        }

        public Complexe Plus(Complexe c)               //La méthode retourne un objet (référence)
        {
            double relle, imaginaire;
            relle = this.partieReelle + c.partieReelle;
            imaginaire = this.partieImaginaire + c.partieImaginaire;

            Complexe rs = new Complexe(relle, imaginaire);
            return ;
        }

        public Complexe Moins(Complexe c)                //La méthode retourne un objet (référence)
        {

        }

        public string Afficher()
        {
            StringBuilder sb = new StringBuilder();

            if (partieImaginaire == 0)
                sb.Append(partieReelle);
            else if (partieImaginaire > 0)
            {
                if (partieImaginaire == 1)
                    sb.Append(partieReelle + "+i");
                else
                    sb.Append(partieReelle + "+" + partieImaginaire + "i");
            }
            else
            {
                if (partieImaginaire == -1)
                    sb.Append(partieReelle + "-i");
                else
                    sb.Append(partieReelle + "" + partieImaginaire + "i");
            }

            return sb.ToString();
        }
    }

}
