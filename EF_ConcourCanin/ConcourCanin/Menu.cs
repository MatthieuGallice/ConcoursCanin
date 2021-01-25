using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcourCanin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        

        private void gérerLesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancie un formulaire note
            Notes Notes = new Notes();
            // Affiche le formulaire 
            Notes.Show();
            // Cache le formulaire Menu
            this.Hide();
        }

        private void gérerLesConcoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancie un formulaire concour 
            Concours Concour = new Concours();
            // Affiche le formulaire 
            Concour.Show();
            // Cache le formulaire menu
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Affiche un message d'informations 
            DialogResult Vidage = MessageBox.Show("Voulez vous vraiment quitter l'application",
                "Quitter",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Vérifie si la réponse est "YES"
            if (Vidage == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
