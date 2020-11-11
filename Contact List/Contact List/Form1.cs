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
            lstContacts.SelectedIndex = -1;
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
            btnGoBack.Visible = false;
            txtName.Enabled = false;
            txtNumber.Enabled = false;
            lblName.Enabled = false;
            lblNumber.Enabled = false;
            imgProfile.Image = Properties.Resources.rhodes;
            txtName.Text = "";
            txtNumber.Text = "";
            txtSearch.Text = "";
            grpNewContact.Text = "New Contact";
        }

        //Funcion that tracks the corresponding object and deletes it
        private void Deleter()
        {
            int index = lstContacts.SelectedIndex;
            int indexContact = -1;
            bool foundDeleted = false;
            foreach (Contact contact in personalContacts)
            {
                indexContact++;
                if (lstContacts.SelectedItem.ToString().Contains(contact.getNom()) && lstContacts.SelectedItem.ToString().Contains(contact.getTel()))
                {
                    personalContacts.RemoveAt(indexContact);
                    foundDeleted = true;
                    break;
                }
            }
            if (foundDeleted == false)
            {
                indexContact = -1;
                foreach (Contact contact in professionalContacts)
                {
                    indexContact++;
                    if (lstContacts.SelectedItem.ToString().Contains(contact.getNom()) && lstContacts.SelectedItem.ToString().Contains(contact.getTel()))
                    {
                        professionalContacts.RemoveAt(indexContact);
                        foundDeleted = true;
                        break;
                    }
                }
            }
            else
            {
                foundDeleted = false;
            }
        }


        //Funcion that tracks the corresponding object and uses it for reference in modification
        private void Modifier()
        {
            int index = lstContacts.SelectedIndex;
            int indexContact = -1;
            bool foundDeleted = false;
            foreach (Contact contact in personalContacts)
            {
                indexContact++;
                if (lstContacts.SelectedItem.ToString().Contains(contact.getNom()) && lstContacts.SelectedItem.ToString().Contains(contact.getTel()))
                {

                    foundDeleted = true;
                    txtName.Text = contact.getNom();
                    rbtnPersonal.Checked = true;
                    txtNumber.Text = contact.getTel();
                    imgProfile.Image = contact.getPhoto();
                    break;
                }
            }
            if (foundDeleted == false)
            {
                foreach (Contact contact in professionalContacts)
                {
                    indexContact++;
                    if (lstContacts.SelectedItem.ToString().Contains(contact.getNom()) && lstContacts.SelectedItem.ToString().Contains(contact.getTel()))
                    {
                        foundDeleted = true;
                        txtName.Text = contact.getNom();
                        rbtnProfessional.Checked = true;
                        txtNumber.Text = contact.getTel();
                        imgProfile.Image = contact.getPhoto();
                        break;
                    }
                }
            }
            else
            {
                foundDeleted = false;
            }
        }


        //Funcion that searches an item based on specific criteria
        private void Search()
        {
            List<String> Findings = new List<String>();
            if (rbtnByName.Checked)
            {
                foreach(String item in lstContacts.Items)
                {
                    if (item.Contains(txtSearch.Text))
                    {
                        Findings.Add(item);
                    }
                }
            }
            if (rbtnByNumber.Checked)
            {
                foreach (String item in lstContacts.Items)
                {
                    if (item.Contains(txtSearch.Text))
                    {
                        Findings.Add(item);
                    }
                }
            }
            if (Findings.Count() != 0)
            {
                lstContacts.Items.Clear();
                foreach(String item in Findings)
                {
                    lstContacts.Items.Add(item);
                }
                Resetter();
                lstContacts.SelectedIndex = 0;
                btnGoBack.Visible = true;
            }
            else
            {
                MessageBox.Show(txtSearch.Text + " wasn't found on the search.");
            }
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
            Serialise.Save(personalSave, personalContacts);
            foreach (Contact contact in professionalContacts)
            {
                allContacts.Add(contact);
                lstContacts.Items.Add(contact.StringName());
            }
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
                int index = lstContacts.SelectedIndex;
                grpNewContact.Text = "Insert Modifications";
                Modifier();
                Deleter();
                NewContactVisibility();
                lstContacts.SelectedIndex = index;
            }
        }


        //Deletes selected contact
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstContacts.SelectedIndex != -1)
            {
                Deleter();
                UpdateListbox();
            }
        }


        //Searches contact list based on specific criteria
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                Search();
            }
            else
            {
                MessageBox.Show("Insert a valid entry.");
            }
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
            if (lstContacts.SelectedIndex != -1)
            {
                foreach(Contact contact in allContacts)
                {
                    if(lstContacts.SelectedItem.ToString().Contains(contact.getNom()) && lstContacts.SelectedItem.ToString().Contains(contact.getTel()))
                    {
                        imgProfile.Image = contact.getPhoto();
                        break;
                    }
                }
                
            }
            else
            {
                BlankPhoto();
            }

        }


        //Allows enter key to be used as input besides the Add button
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
        }



        //Allows enter key to be used as input besides the Search button
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }


        //Allows user to return to previous screen after doing a search
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = false;
            Resetter();
            UpdateListbox();
        }


        //Checks if the radio button in the search groupbox is checked, and changes the label accordingly
        private void rbtnByNumber_CheckedChanged(object sender, EventArgs e)
        {
            lblNameNumber.Text = "Number:";
        }

        //Checks if the radio button in the search groupbox is checked, and changes the label accordingly
        private void rbtnByName_CheckedChanged(object sender, EventArgs e)
        {
            lblNameNumber.Text = "Name:";
        }
    }
}
