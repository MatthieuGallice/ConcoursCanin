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
    public partial class Notes : Form
    {
        // Créer la variable monModele de la classe ConcoursCaninEntities
        private ConcoursCaninEntities monModele;
        public Notes()
        {
            InitializeComponent();
            // Instancie l'objet ConcoursCaninEntities
            monModele = new ConcoursCaninEntities();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            // Met à jour les données dans le DGV
            Raffraichirdgv();

            // Affichage dans les combobox
            RechercherProp();
            RechercherConcour();

            //Affichage des noms chien et propriétaire au load
            AfficherNom();

        }

        #region Fonctions
        /// <summary>
        /// Raffraichit le datagrid view 
        /// </summary>
        private void Raffraichirdgv()
        {
            // Récupère toutes la table PARTICIPE
            var req = from v in monModele.PARTICIPEs
                      orderby v.note descending
                      select v;
            // Combine les données de la table avec le DGV
            pARTICIPEBindingSource2.DataSource = req.ToList();
            dataGridView1.DataSource = pARTICIPEBindingSource2;
        }

        /// <summary>
        /// Rechercher Propriétaire
        /// </summary>
        private void RechercherProp()
        {
            // Requête qui récupère les noms des propriétaires
            var req = from v in monModele.PROPRIETAIREs
                      select v.nomproprietaire;
            foreach(string lareq in req)
            {
                // Ajoute les noms des propriétaires dans la combo box
                cboxProp.Items.Add(lareq);
            }
            
        }

        /// <summary>
        /// Rechercher COncours
        /// </summary>
        private void RechercherConcour()
        {
            // Requête  qui récupère les code concours 
            var req = from v in monModele.CONCOURS
                      select v.codeconcours;
            foreach (string lareq in req)
            {
                // Ajoute les codes dans la combo box
                cboxConc.Items.Add(lareq);
            }
        }

        /// <summary>
        /// Rechercher Chien
        /// </summary>
        private void RechercherCHien()
        {
            // Récupère le nom du propriétaire 
            string nomProprio = cboxProp.Text;
            // Requête qui récupère les noms des chiens selon le nom du propriétaire 
            var req = from v in monModele.CHIENs
                      where v.PROPRIETAIRE.nomproprietaire == nomProprio
                      select v.nomchien;
            foreach (string lareq in req)
            {
                // Ajotue les noms des chiens dans la combo box chien
                cboxChien.Items.Add(lareq);
            }
        }

        /// <summary>
        /// Permet l'affichage des noms des chiens et propriétaire selon leurs code sur chaque lignes
        /// </summary>
        private void AfficherNom()
        {
            // Charge le nom propriétaire et le nom chien selon les lignes
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                // Récupère le code du propriétaire 
                string leCodeProprietaire = dataGridView1.Rows[i].Cells[2].Value.ToString();
                // Requête qui récupère le nom du propriétaire selon le code du propriétaire 
                var req = from v in monModele.PROPRIETAIREs
                          where v.codeproprietaire == leCodeProprietaire
                          select v.nomproprietaire;
                foreach (string lareq in req)
                {
                    dataGridView1.Rows[i].Cells[1].Value = lareq;
                }

                // Récupère le code du chien 
                string leCodeChien = dataGridView1.Rows[i].Cells[3].Value.ToString();
                // Requête qui récupère le nom du chien selon le code du chien
                var reqbis = from v in monModele.CHIENs
                             where v.codechien == leCodeChien
                             select v.nomchien;
                foreach (string lareqbis in reqbis)
                {
                    dataGridView1.Rows[i].Cells[0].Value = lareqbis;
                }

            }
        }
        /// <summary>
        /// Nettoie les éléments
        /// </summary>
        private void Clear()
        {
            // Clear les combobox
            cboxChien.Items.Clear();
            cboxConc.Items.Clear();
            cboxProp.Items.Clear();

            // Clear la textbox
            txtboxNote.Clear();
        }
        private void Cacher()
        {
            // Gère la visibilité de certains éléments
            btnAjouter.Visible = true;
            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnReinitialiser.Visible = false;
            btnValiderAjout.Visible = false;
            btnValiderModif.Visible = false;
            btnVider.Visible = false;
        }
        private void Montrer()
        {
            btnSupprimer.Visible = false;
            btnValiderAjout.Visible = true;
            btnModifier.Visible = false;
            btnAjouter.Visible = false;
            btnReinitialiser.Visible = true;
            btnVider.Visible = false;
        }
        #endregion

        private void btnAjouterUnConcours_Click(object sender, EventArgs e)
        {
            // Instancie un formulaire concour 
            Menu menu = new Menu();
            // Affiche le formulaire 
            menu.Show();
            // Cache le formulaire note
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Gère la visibilité de certains éléments
            Montrer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Gère la visibilité de la combobox chien 
            cboxChien.Visible = true;

            // Remplis les combo box
            cboxProp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cboxChien.Text =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cboxConc.Text =  dataGridView1.CurrentRow.Cells[4].Value.ToString();

            // Vérifie que la note soit en null
            if (dataGridView1.CurrentRow.Cells[5].Value == null)
            {
                // Envoie un élément vide dnas la text box
                txtboxNote.Text = "";
            }
            else
            {
                // Envoie la note du DGV dans la text box
                txtboxNote.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }

            // Mis a jour nom du propriétaire et nom du chien 
            AfficherNom();


            // Gère la visibilité de certains éléments
            cboxChien.Enabled = false;
            cboxConc.Enabled = false;
            cboxProp.Enabled = false;
            Montrer();


        }

        private void cboxProp_TextChanged(object sender, EventArgs e)
        {
            // Met un texte vide dans la combobox chien
            cboxChien.Text = "";
            // Clear la combobox chien
            cboxChien.Items.Clear();
            // Met la combobox chien en visible
            cboxChien.Visible = true;
            // Appel de la fonction pour charger les chiens selon le propriétaire
            RechercherCHien();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Récupère les données du tableau
            string CodeProprietaire = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string CodeChien = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string CodeConcours = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            // Instancie un objet PARTICIPE contenant les informations selectionner
            PARTICIPE LaParticipation = monModele.PARTICIPEs.Find(CodeProprietaire, CodeChien, CodeConcours);
            // DELETE l'objet précédement instancié
            monModele.PARTICIPEs.Remove(LaParticipation);

            // Envoie les modifications apportés 
            monModele.SaveChanges();

            // Met à jour la DGV
            Raffraichirdgv();
        }

        private void btnValiderModif_Click(object sender, EventArgs e)
        {

            // Récupère les données du tableau
            string CodeProprietaire = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string CodeChien = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string CodeConcours = dataGridView1.CurrentRow.Cells[4].Value.ToString();


            // Récupère les données des textbox
            string leNomProprietaire = cboxProp.Text;
            string leCodeProprietaire = "";

            // Requête qui récupère le code du propriétaire grâce a son nom
            var req = from v in monModele.PROPRIETAIREs
                         where v.nomproprietaire == leNomProprietaire
                         select v.codeproprietaire;
            // Boucle qui balaye la requête 
            foreach (string lareqbis in req)
            {
                leCodeProprietaire = lareqbis;
            }


            // Récupère le nom du chien insérer 
            string leNomChien = cboxChien.Text;
            // Instancie le code du chien
            string leCodeChien = "";

            // Requête qui permet de récupérer le code du chien grâce a son nom
            var reqbis = from v in monModele.CHIENs
                      where v.nomchien == leNomChien
                      select v.codechien;

            // Boucle qui balaye la requête 
            foreach (string lareqbis in reqbis)
            {
                leCodeChien = lareqbis;
            }


            // Récupère le code concours insérer 
            string leCodeConcours = cboxConc.Text;

            // Récupère la note insérer 
            string lanote = txtboxNote.Text;

            // Condition si les clés primaire sont identique a celles selectionné 
            if (leCodeProprietaire == CodeProprietaire && leCodeChien == CodeChien && leCodeConcours == CodeConcours)
            {
                //Remplace dans le datagrid View les informations modifié
                dataGridView1.CurrentRow.Cells[2].Value = leCodeProprietaire;
                dataGridView1.CurrentRow.Cells[3].Value = leCodeChien;
                dataGridView1.CurrentRow.Cells[4].Value = leCodeConcours;
                dataGridView1.CurrentRow.Cells[5].Value = lanote;
            }
            // Envoie les modifications apportés 
            monModele.SaveChanges();
            // Met à jour la DGV
            Raffraichirdgv();
            // Mis a jour nom du propriétaire et nom du chien 
            AfficherNom();


            // Gère la visibilité de certains éléments
            Cacher();
            cboxChien.Enabled = true;
            cboxConc.Enabled = true;
            cboxProp.Enabled = true;
            Clear();
        }

        private void btnValiderAjout_Click(object sender, EventArgs e)
        {
            // Instancie les variables
            string leCodeP = "";
            string leCodeChien = "";

            //Récupère le nom du chien insérer 
            string nomChien = cboxChien.Text;

            // Requete qui récupère le code du chien selon son nom
            var req = from v in monModele.CHIENs
                      where v.nomchien == nomChien
                      select v.codechien;
            // Boucle qui balaye la requête 
            foreach (string lareq in req)
            {
                leCodeChien = lareq;
            }

            // Récupère le nom du propriétaire insérer
            string nomPropriétaire = cboxProp.Text;
            // Requete qui récupère le code du propriétaire selon son nom
            var reqbis = from v in monModele.PROPRIETAIREs
                         where v.nomproprietaire == nomPropriétaire
                         select v.codeproprietaire;
            // Boucle qui balaye la requête 
            foreach (string lareqbis in reqbis)
            {
                leCodeP = lareqbis;
            }

            // Recupère le code concours insérer
            string codeConcour = cboxConc.Text;

            // Récupère la note insérer
            int lanote = int.Parse(txtboxNote.Text);

            // Instancie un nouvel objeet PARCTICIPE avec les données récupéré
            var uneParticipe = new PARTICIPE()
            {
                codeproprietaire = leCodeP,
                codechien = leCodeChien,
                codeconcours = codeConcour,
                note = lanote,

            };

            // Ajout de l'objet PARTICIPE 
            monModele.PARTICIPEs.Add(uneParticipe);
            // Envoie de l'ajout de l'objet PARTICIPE
            monModele.SaveChanges();

            // Appel de fonctions
            // Mis a jour DGV
            Raffraichirdgv();
            // Mis a jour nom du propriétaire et nom du chien 
            AfficherNom();

            // Gère la visibilité de certains éléments
            Cacher();
            //Nettoie les éléments
            Clear();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            // Gère la visibilité de certains éléments
            Cacher();

            // Permet la modification des combo box
            cboxChien.Enabled = true;
            cboxConc.Enabled = true;
            cboxProp.Enabled = true;
            //Nettoie les éléments
            Clear();

        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            // Affiche les informations nécéssaires pour faire marcher ce formulaire
            MessageBox.Show("- Pour ajouter une un chien sur un concours il suffit de remplir la combobox Propriétaire"  +
                " \n\n- Ensuite cela débloquera la combobox chien, qui permettra de choisir le chien selon le propriétaire." +
                " \n\n- Vous pouvez modifier une ligne en selectionnant la ligne dans le tableau (tout a gauche de la ligne) " +
                " \n\n- Et enfin vous pouvez supprimer une ligne en la selectionnant et appuyant sur le boutton supprimer ");
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
