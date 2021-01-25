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
    public partial class Concours : Form
    {
        // Créer la variable monModele de la classe ConcoursCaninEntities
        private ConcoursCaninEntities monModele;
        public Concours()
        {
            InitializeComponent();
            // Instancie l'objet ConcoursCaninEntities
            monModele = new ConcoursCaninEntities();
        }

        private void Concours_Load(object sender, EventArgs e)
        {
            // Charge le DGV
            Raffraichirdgv();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Gérer les visibilité des éléments
            CacherLesBox();
            btnValidAjout.Visible = true;


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Récupère les données du tableau 
            txtboxcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtboxadresse.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtboxcp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtboxsalle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtboxVilleConcours.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            //Gère la visibilité des box
            CacherLesBox();
            btnValiderModif.Visible = true;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Récupère les données du tableau
            string CodeConcours = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // Cherche le concour qui a le code concours de CodeConcours
            CONCOUR LaParticipation = monModele.CONCOURS.Find(CodeConcours);

            // Requête qui récupère la liste des chiens qui participe a ce concours
            var req = from v in monModele.PARTICIPEs
                      where v.codeconcours == CodeConcours
                      select v;
            int Compteur = 0;
            // Boucle qui balaye la requête 
            foreach (PARTICIPE lareqbis in req)
            {
                // Supprimer l'objet instancié PARTICIPE
                monModele.PARTICIPEs.Remove(lareqbis);
                Compteur = Compteur + 1;

            }
            // Supprimer l'objet instancié précédemment 
            monModele.CONCOURS.Remove(LaParticipation);
            // Sauvegarde le changement 
            monModele.SaveChanges();
            // Raffraichit la dgv 
            Raffraichirdgv();

            // Affiche le message d'informations sur la suppression 
            MessageBox.Show("Le concours " + CodeConcours + " et le(s) " + Compteur + " chien(s) ont bien été supprimer.");


        }

        private void btnValiderModif_Click(object sender, EventArgs e)
        {
            //Condition sur la longueur du texte du code du concour
            if (txtboxcode.Text.Length > 6)
            {
                //Message si le texte est trop long 
                MessageBox.Show(" IL NE FAUT PAS METTRE PLUS DE 6 CARACTERES POUR LE CODE DU CONCOURS");
            }
            // Condition si la longueur du texte du code postal est trop longue
            else if (txtboxcp.Text.Length > 5)
            {
                // Message d'informations
                MessageBox.Show(" IL NE FAUT PAS METTRE PLUS DE 5 CARACTERES POUR LE CODE POSTAL");
            }
            else
            {
                //Récupère les données du tableau
                string leCode = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string lAdresse = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string leCp = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string laDate = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string laSalle = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string laVille = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                //Récupère les données des textbox
                string codeconcour = txtboxcode.Text;
                string adresseconcours = txtboxadresse.Text;
                string cpconcours = txtboxcp.Text;
                string dateconcours = dateTimePicker1.Text;
                string salleconcours = txtboxsalle.Text;
                string villeconcours = txtboxVilleConcours.Text;

                // Compare le code dans le DGV et le compare au code du txtbox
                if (leCode == codeconcour)
                {
                    //Remplace dans le datagrid View les infomrmations modifié
                    dataGridView1.CurrentRow.Cells[1].Value = adresseconcours;
                    dataGridView1.CurrentRow.Cells[2].Value = cpconcours;
                    dataGridView1.CurrentRow.Cells[3].Value = dateconcours;
                    dataGridView1.CurrentRow.Cells[4].Value = salleconcours;
                    dataGridView1.CurrentRow.Cells[5].Value = villeconcours;
                }

                // Sauvegarde les données   
                monModele.SaveChanges();
                // Raffraichit le DGV
                Raffraichirdgv();
                // Remet les textBox et boutons en place
                Reset();
                // Message d'information quand le code concour est modifié
                MessageBox.Show("Le concours " + codeconcour + " a été modifier.");
            }
                

        }

        private void BtnNote_Click(object sender, EventArgs e)
        {
            //Instancie un form Menu
            Menu menu = new Menu();
            // Montre le form Menu
            menu.Show();
            // Cache le form Concour
            this.Close();
        }
        
        private void btnAide_Click(object sender, EventArgs e)
        {
            // Affiche les informations nécéssaires pour faire marcher ce formulaire
            MessageBox.Show("Vous pouvez choisir une des trois options, ajouter, modifier ou supprimer:" +
                " \n\n- Pour ajouter le formulaire s'ouvrira sur le clic du bouton ajouter et vous pourrez ensuite valider l'ajout ou réinitialiser et recommencer" +
                " \n\n- Pour modifier, vous aurez toutes les propriétés de la ligne selectionné dans le tableau qui seront retranscrites dans les text box " +
                " \n\n- Pour supprimer une ligne, il vous suffit de selectionner une ligne et d'appuyer sur le bouton supprimer" +
                " \n\n\n\n*Règles Spécifiques*" +
                " \n\n- Le code concours ne doit pas excéder 6 caractères" +
                " \n\n- Le code postal ne doit pas exécder 5 caractères et doit être composé que de chiffres ");
        }

        private void btnValidAjout_Click(object sender, EventArgs e)
        {
            // Récupère la date entrée dans le text box
            string datetemp = dateTimePicker1.Value.ToString();
            String jour = datetemp.Substring(0, 2);
            String mois = datetemp.Substring(3, 2);
            String Ans = datetemp.Substring(6, 4);

            // Convertit la date en entier
            int leJour = int.Parse(jour);
            int leMois = int.Parse(mois);
            int lAns = int.Parse(Ans);

            //Condition sur la longueur du texte du code du concour
            if (txtboxcode.Text.Length > 6)
            {
                //Message si le texte est trop long 
                MessageBox.Show(" IL NE FAUT PAS METTRE PLUS DE 6 CARACTERES POUR LE CODE DU CONCOURS");
            }
            // Condition si la longueur du texte du code postal est trop longue
            else if (txtboxcp.Text.Length > 5)
            {
                // Message d'informations
                MessageBox.Show(" IL NE FAUT PAS METTRE PLUS DE 5 CARACTERES POUR LE CODE POSTAL");
            }
            else
            {
                // Instancie un objet CONCOUR
                CONCOUR unConcour = new CONCOUR()
                {
                    codeconcours = txtboxcode.Text,
                    adresseconcours = txtboxadresse.Text,
                    cpconcours = txtboxcp.Text,
                    dateconcours = new DateTime(lAns, leMois, leJour),
                    salleconcours = txtboxsalle.Text,
                    villeconcours = txtboxVilleConcours.Text,
                    PARTICIPEs = new List<PARTICIPE>(), // Instancie une liste PARTICIPE vide 

                };

                // Ajoute le CONCOUR dans la base de données
                monModele.CONCOURS.Add(unConcour);
                // Sauvegarde l'ajout
                monModele.SaveChanges();
                // Recharge le DGV
                Raffraichirdgv();
                // Remet en place les boutons et textBox 
                Reset();
            }
        }

        #region Fonctions
        /// <summary>
        /// Raffraichit le datagrid view 
        /// </summary>
        private void Raffraichirdgv()
        {
            // Requête qui récupère les concours
            var req = from v in monModele.CONCOURS
                      select v;
            //Gère la mise en place desdonnées récupérer dans le DGV
            cONCOURSBindingSource.DataSource = req.ToList();
            dataGridView1.DataSource = cONCOURSBindingSource;
        }
        /// <summary>
        /// Gére les visible des éléments
        /// </summary>
        private void CacherLesBox()
        {
            // Gérer les visibilité des boutons
            btnAjouter.Visible = false;
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            btnValiderModif.Visible = false;
            btnValidAjout.Visible = false;
            btnReinit.Visible = true;
            btnVider.Visible = true;
            // Gérer les visibilité des labels
            labeladress.Visible = true;
            labelcc.Visible = true;
            labeldate.Visible = true;
            labelcp.Visible = true;
            labelsalle.Visible = true;
            labelville.Visible = true;
            // Gérer les visibilité des text box
            txtboxadresse.Visible = true;
            txtboxcode.Visible = true;
            txtboxcp.Visible = true;
            txtboxsalle.Visible = true;
            txtboxVilleConcours.Visible = true;
            dateTimePicker1.Visible = true;
        }
        /// <summary>
        /// Remet en place les boutons
        /// </summary>
        private void Reset()
        {
            // Gérer les visibilité des boutons
            btnAjouter.Visible = true;
            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnValiderModif.Visible = false;
            btnValidAjout.Visible = false;
            btnReinit.Visible = false;
            btnVider.Visible = false;
            // Gérer les visibilité des labels
            labeladress.Visible = false;
            labelcc.Visible = false;
            labeldate.Visible = false;
            labelcp.Visible = false;
            labelsalle.Visible = false;
            labelville.Visible = false;
            // Gérer les visibilité des text box
            txtboxadresse.Visible = false;
            txtboxcode.Visible = false;
            txtboxcp.Visible = false;
            txtboxsalle.Visible = false;
            txtboxVilleConcours.Visible = false;
            dateTimePicker1.Visible = false;
        }

        /// <summary>
        ///  Nettoie les éléments 
        /// </summary>
        private void Clear()
        {
            // Clear les textbox
            txtboxadresse.Clear();
            txtboxcode.Clear();
            txtboxcp.Clear();
            txtboxsalle.Clear();
            txtboxVilleConcours.Clear();

            // Clear le DTP
            dateTimePicker1.ResetText();
        }
        #endregion

        private void btnReinit_Click(object sender, EventArgs e)
        {
            // Remet en place les boutons 
            Reset();
            Clear();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            // Affiche un message d'informations 
            DialogResult Vidage = MessageBox.Show("Voulez vous vraiment vider tout les éléments?",
                "Vider les éléments",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            // Vérifie si la réponse est "YES"
            if (Vidage == DialogResult.Yes)
            {
                // Nettoie les éléments
                Clear();
            }

            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
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
