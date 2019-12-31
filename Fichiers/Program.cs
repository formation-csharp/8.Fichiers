using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStagiaires gestion = new DataStagiaires();

            //gestion.liste_stagiaires
            //    .Add(new Stagiaire() { Id = 1, Nom = "Madani" });

            //gestion.liste_stagiaires
            //  .Add(new Stagiaire() { Id = 2, Nom = "Chami" });

            //// Enregistrer dans un fichier XML
            //XmlSerializer xs =
            //    new XmlSerializer(typeof(DataStagiaires));
            //StreamWriter w =
            //    new StreamWriter("stagiaire.xml");
            //xs.Serialize(w, gestion);

           // Lecture
           XmlSerializer xs =
               new XmlSerializer(typeof(DataStagiaires));
            StreamReader R =
                new StreamReader("stagiaire.xml");
            gestion = xs.Deserialize(R) as DataStagiaires;

            foreach (var item in gestion.liste_stagiaires)
            {
                Console.WriteLine(item.Nom);
            }

            Console.ReadKey();

        }
    }
}
