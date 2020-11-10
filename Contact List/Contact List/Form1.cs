using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_List
{
    public partial class ContactList : Form
    {
        private List<Contact> personalContacts = new List<Contact>();
        private List<Contact> professionalContacts = new List<Contact>();
        private List<Contact> allContacts = new List<Contact>();
        private string personalSave = "SavedPersonalContacts";
        private string professionalSave = "SavedProfessionalContacts";

        public ContactList()
        {
            InitializeComponent();
        }


        //Function that changes visibility and permissions
        private void NewContactVisibility()
        {
            lstContacts.Enabled = false;
            grpNewContact.Enabled = true;
            rbtnPersonal.Enabled = true;
            rbtnProfessional.Enabled = true;
            btnPicture.Enabled = true;
            btnPicture.Visible = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            txtName.Enabled = true;
            txtNumber.Enabled = true;
            lblName.Enabled = true;
            lblNumber.Enabled = true;
            imgProfile.Image = Properties.Resources.rhodes;
            txtName.Focus();
        }


        //Funcion that resets all permissions and settings to default
        private void Resetter()
        {
            lstContacts.Enabled = true;
            grpNewContact.Enabled = false;
            rbtnPersonal.Enabled = false;
            rbtnProfessional.Enabled = false;
            btnPicture.Enabled = false;
            btnPicture.Visible = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            txtName.Enabled = false;
            txtNumber.Enabled = false;
            lblName.Enabled = false;
            lblNumber.Enabled = false;
            imgProfile.Image = Properties.Resources.rhodes;
            txtName.Text = "";
            txtNumber.Text = "";
            grpNewContact.Text = "New Contact";
        }


        //Funcion that changes the photo back to default
        private void BlankPhoto()
        {
            imgProfile.Image = Properties.Resources.rhodes;
        }


        //Loading settings
        private void Form1_Load(object sender, EventArgs e)
        {
            Object restorePersonal = Serialise.Recup(personalSave);
            Object restoreProfessional = Serialise.Recup(professionalSave);
            if (restorePersonal != null)
            {
                personalContacts = (List<Contact>)restorePersonal;
            }
            if (restoreProfessional != null)
            {
                professionalContacts = (List<Contact>)restoreProfessional;
            }
            UpdateListbox();
        }


        //Refreshes contacts listbox and saves the new one
        private void UpdateListbox()
        {
            personalContacts.Sort();
            professionalContacts.Sort();
            lstContacts.Items.Clear();
            allContacts.Clear();
            foreach (Contact contact in personalContacts)
            {
                allContacts.Add(contact);
                lstContacts.Items.Add(contact.StringName());
            }
            foreach (Contact contact in professionalContacts)
            {
                allContacts.Add(contact);
                lstContacts.Items.Add(contact.StringName());
            }
            Serialise.Save(personalSave, personalContacts);
            Serialise.Save(professionalSave, professionalContacts);
        }


        //Changes visibility when clicking on Add New Contact
        private void btnNewContact_Click(object sender, EventArgs e)
        {
            NewContactVisibility();
        }


        //Adds new entry to Contact class and then to its respective list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals("") && !txtNumber.Text.Equals("") && rbtnPersonal.Checked || rbtnProfessional.Checked )
            {
                Contact newContact;
                if (rbtnPersonal.Checked)
                {
                    newContact = new Contact(txtName.Text, txtNumber.Text, rbtnPersonal.Text, imgProfile.Image);
                    personalContacts.Add(newContact);
                }
                else
                {
                    newContact = new Contact(txtName.Text, txtNumber.Text, rbtnProfessional.Text, imgProfile.Image);
                    professionalContacts.Add(newContact);

                }
                UpdateListbox();
                Resetter();
            }
            else
            {
                MessageBox.Show("Please insert name, number, and category.");
            }
        }


        //Changes permissions so that a contact may be modified
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1)
            {

                NewContactVisibility();
                grpNewContact.Text = "Insert Modifications";
                int index = lstContacts.SelectedIndex;
                Contact selectedContact = allContacts[index];
                if (selectedContact.getCategory() == "Personal")
                {
                    personalContacts.RemoveAt(index);
                }
                else
                {
                    professionalContacts.RemoveAt(index - personalContacts.Count());
                }
                txtName.Text = selectedContact.getNom();
                if (selectedContact.getCategory() == "Personal")
                {
                    rbtnPersonal.Checked = true; 
                }
                else
                {
                    rbtnProfessional.Checked = true;
                }
                txtNumber.Text = selectedContact.getTel();
                imgProfile.Image = selectedContact.getPhoto();
                
            }
        }


        //Deletes selected contact
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstContacts.SelectedIndex;
            Contact selectedContact = allContacts[index];
            if (selectedContact.getCategory() == "Personal")
            {
                personalContacts.RemoveAt(index);
            }
            else
            {
                professionalContacts.RemoveAt(index - personalContacts.Count());
            }
            UpdateListbox();
        }


        //Opens a window so that the user may chose an image to insert as the contact's profile picture
        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchFile;
            searchFile = new OpenFileDialog();
            DialogResult choice = searchFile.ShowDialog();
            if (choice == DialogResult.OK)
            {
                string nameFile = searchFile.FileName;
                // tente d'afficher l'image
                try
                {
                    imgProfile.Image = Image.FromFile(nameFile);
                }
                catch
                {
                    MessageBox.Show("Please chose a valid image.");
                }
            }
        }


        //Cancels an adding contact process
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Resetter();
        }


        //Checks if the selected contact has changed, and if so, changes the picture to match the contact.
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstContacts.SelectedIndex;
            Contact selectedContact = allContacts[index];
            if (lstContacts.SelectedIndex != -1)
            {
                imgProfile.Image = selectedContact.getPhoto();
            }
            else
            {
                // affiche une image vide
                BlankPhoto();
            }
        }


    }
}
