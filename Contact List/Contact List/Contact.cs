using System;
using System.ComponentModel;
using System.Drawing;

namespace Contact_List
{

    /// <summary>
    /// Classe Contact
    /// mémorise les informations du contact
    /// </summary>
    [SerializableAttribute]
    public class Contact : IComparable
    //    public class Contact
    {
        /// <summary>
        /// nom du contact
        /// </summary>
        private string nom;
        /// <summary>
        /// tel du contact
        /// </summary>
        private string tel;
        /// <summary>
        /// photo du contact
        /// </summary>
        private Image photo;
        /// <summary>
        /// type du contact
        /// </summary>
        private string category;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">nom</param>
        /// <param name="tel">tel</param>
        /// <param name="photo">photo</param>
        /// /// <param name="category">category</param>
        public Contact(string nom, string tel, string category, Image photo)
        {
            this.nom = nom;
            this.tel = tel;
            this.photo = photo;
            this.category = category;
        }

        /// <summary>
        /// getter sur nom
        /// </summary>
        /// <returns>nom</returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// getter sur tel
        /// </summary>
        /// <returns>tel</returns>
        public string getTel()
        {
            return this.tel;
        }

        /// <summary>
        /// getter sur photo
        /// </summary>
        /// <returns>photo</returns>
        public Image getPhoto()
        {
            return this.photo;
        }

        public string getCategory()
        {
            return this.category;
        }
        /// <summary>
        /// Comparaison des noms pour le tri
        /// </summary>
        /// <param name="obj">Contact à comparer</param>
        /// <returns>comparaison sur le nom</returns>
        public int CompareTo(object obj)
        {
            return nom.CompareTo(((Contact)obj).getNom());
        }

        public string StringName()
        {
            return this.nom + " - " + this.category + " - (" + this.tel + ")";
        }
    }
}
