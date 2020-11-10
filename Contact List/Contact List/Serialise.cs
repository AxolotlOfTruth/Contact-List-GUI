using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Contact_List
{
    /// <summary>
    /// Classe Sérialise
    /// Permet de sauvegarder en binaire et récupérer des objets
    /// </summary>
    public abstract class Serialise
    {
        /// <summary>
        /// Sérialisation
        /// </summary>
        /// <param name="fichier">nom du fichier de sauvegarde</param>
        /// <param name="objet">objet à sérialiser</param>
        public static void Save(string fichier, Object objet)
        {
            // si le fichier existe, il faut le supprimer
            if (File.Exists(fichier))
            {
                File.Delete(fichier);
            }
            // création du flux pour l'écriture dans le fichier
            FileStream flux = new FileStream(fichier, FileMode.Create);
            // création d'un objet pour le formatage en binaire des informations
            BinaryFormatter fbinaire = new BinaryFormatter();
            // sérialisation des objets de la collection
            fbinaire.Serialize(flux, objet);
            // fermeture du flux
            flux.Close();
        }

        /// <summary>
        /// Désérialisation
        /// </summary>
        /// <param name="fichier">nom du fichier de sauvegarde</param>
        /// <returns>objet désérialisé</returns>
        public static Object Recup(string fichier)
        {
            // Contrôle de l'existance du fichier
            if (File.Exists(fichier))
            {
                // ouverture du flux pour la lecture dans le fichier
                FileStream flux = new FileStream(fichier, FileMode.Open);
                // création d'un objet pour le formatage en binaire des informations
                BinaryFormatter fbinaire = new BinaryFormatter();
                // récupération de l'objet sérialisé
                try
                {
                    Object objet = fbinaire.Deserialize(flux);
                    // fermeture du flux
                    flux.Close();
                    // retour de l'objet
                    return objet;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
