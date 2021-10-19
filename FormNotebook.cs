using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class FormNotebook : Form
    {
        string bestandNaam = "";
        bool txtChanged = false;

        public FormNotebook()
        {
            InitializeComponent();
        }

        private void mnAfsluiten_Click(object sender, EventArgs e)
        {
            CheckBewaard(sender, e);
            this.Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            CheckBewaard(sender, e);
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                bestandNaam = dlgOpen.FileName;
                StreamReader leesStream = File.OpenText(bestandNaam);
                tbNotitie.Text = leesStream.ReadToEnd();
                leesStream.Close();
            }
        }

        private void mnBewaarAls_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Textbestanden (*.txt)|*.txt";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                bestandNaam=dlgSave.FileName;
                BewaarBestand();
            }
        }

        private void mnBewaar_Click(object sender, EventArgs e)
        {
            if (bestandNaam == "")
                mnBewaarAls_Click(sender, e);
            else
                BewaarBestand();
        }

        private void BewaarBestand()
        {
            StreamWriter schrijfStream = File.CreateText(bestandNaam);
            schrijfStream.Write(tbNotitie.Text); 
            schrijfStream.Close();
            txtChanged = false;
        }

        private void tbNotitie_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }

        private void CheckBewaard(object sender, EventArgs e)
        {
            if (txtChanged)
            {
                if (MessageBox.Show("Wil je je tekst bewaren?","Tekst bewaren",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mnBewaar_Click(sender, e);
                }

                txtChanged = false;
            }
        }
    }
}
