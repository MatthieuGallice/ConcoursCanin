namespace ConcourCanin
{
    partial class Concours
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValiderModif = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salleconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONCOURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concoursCaninDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concoursCaninDataSet = new ConcourCanin.ConcoursCaninDataSet();
            this.cONCOURSTableAdapter = new ConcourCanin.ConcoursCaninDataSetTableAdapters.CONCOURSTableAdapter();
            this.txtboxcp = new System.Windows.Forms.TextBox();
            this.txtboxadresse = new System.Windows.Forms.TextBox();
            this.txtboxcode = new System.Windows.Forms.TextBox();
            this.txtboxVilleConcours = new System.Windows.Forms.TextBox();
            this.txtboxsalle = new System.Windows.Forms.TextBox();
            this.labelcc = new System.Windows.Forms.Label();
            this.labeladress = new System.Windows.Forms.Label();
            this.labelcp = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labelsalle = new System.Windows.Forms.Label();
            this.labelville = new System.Windows.Forms.Label();
            this.btnAide = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnValidAjout = new System.Windows.Forms.Button();
            this.btnReinit = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concoursCaninDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concoursCaninDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(675, 396);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(542, 396);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(400, 396);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnValiderModif
            // 
            this.btnValiderModif.Location = new System.Drawing.Point(542, 497);
            this.btnValiderModif.Name = "btnValiderModif";
            this.btnValiderModif.Size = new System.Drawing.Size(88, 23);
            this.btnValiderModif.TabIndex = 3;
            this.btnValiderModif.Text = "Valider Modif";
            this.btnValiderModif.UseVisualStyleBackColor = true;
            this.btnValiderModif.Visible = false;
            this.btnValiderModif.Click += new System.EventHandler(this.btnValiderModif_Click);
            // 
            // BtnRetour
            // 
            this.BtnRetour.Location = new System.Drawing.Point(12, 12);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(114, 23);
            this.BtnRetour.TabIndex = 4;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = true;
            this.BtnRetour.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeconcoursDataGridViewTextBoxColumn,
            this.adresseconcoursDataGridViewTextBoxColumn,
            this.cpconcoursDataGridViewTextBoxColumn,
            this.dateconcoursDataGridViewTextBoxColumn,
            this.salleconcoursDataGridViewTextBoxColumn,
            this.villeconcoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONCOURSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(493, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 294);
            this.dataGridView1.TabIndex = 5;
            // 
            // codeconcoursDataGridViewTextBoxColumn
            // 
            this.codeconcoursDataGridViewTextBoxColumn.DataPropertyName = "codeconcours";
            this.codeconcoursDataGridViewTextBoxColumn.HeaderText = "codeconcours";
            this.codeconcoursDataGridViewTextBoxColumn.Name = "codeconcoursDataGridViewTextBoxColumn";
            // 
            // adresseconcoursDataGridViewTextBoxColumn
            // 
            this.adresseconcoursDataGridViewTextBoxColumn.DataPropertyName = "adresseconcours";
            this.adresseconcoursDataGridViewTextBoxColumn.HeaderText = "adresseconcours";
            this.adresseconcoursDataGridViewTextBoxColumn.Name = "adresseconcoursDataGridViewTextBoxColumn";
            // 
            // cpconcoursDataGridViewTextBoxColumn
            // 
            this.cpconcoursDataGridViewTextBoxColumn.DataPropertyName = "cpconcours";
            this.cpconcoursDataGridViewTextBoxColumn.HeaderText = "cpconcours";
            this.cpconcoursDataGridViewTextBoxColumn.Name = "cpconcoursDataGridViewTextBoxColumn";
            // 
            // dateconcoursDataGridViewTextBoxColumn
            // 
            this.dateconcoursDataGridViewTextBoxColumn.DataPropertyName = "dateconcours";
            this.dateconcoursDataGridViewTextBoxColumn.HeaderText = "dateconcours";
            this.dateconcoursDataGridViewTextBoxColumn.Name = "dateconcoursDataGridViewTextBoxColumn";
            // 
            // salleconcoursDataGridViewTextBoxColumn
            // 
            this.salleconcoursDataGridViewTextBoxColumn.DataPropertyName = "salleconcours";
            this.salleconcoursDataGridViewTextBoxColumn.HeaderText = "salleconcours";
            this.salleconcoursDataGridViewTextBoxColumn.Name = "salleconcoursDataGridViewTextBoxColumn";
            // 
            // villeconcoursDataGridViewTextBoxColumn
            // 
            this.villeconcoursDataGridViewTextBoxColumn.DataPropertyName = "villeconcours";
            this.villeconcoursDataGridViewTextBoxColumn.HeaderText = "villeconcours";
            this.villeconcoursDataGridViewTextBoxColumn.Name = "villeconcoursDataGridViewTextBoxColumn";
            // 
            // cONCOURSBindingSource
            // 
            this.cONCOURSBindingSource.DataMember = "CONCOURS";
            this.cONCOURSBindingSource.DataSource = this.concoursCaninDataSetBindingSource;
            // 
            // concoursCaninDataSetBindingSource
            // 
            this.concoursCaninDataSetBindingSource.DataSource = this.concoursCaninDataSet;
            this.concoursCaninDataSetBindingSource.Position = 0;
            // 
            // concoursCaninDataSet
            // 
            this.concoursCaninDataSet.DataSetName = "ConcoursCaninDataSet";
            this.concoursCaninDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONCOURSTableAdapter
            // 
            this.cONCOURSTableAdapter.ClearBeforeFill = true;
            // 
            // txtboxcp
            // 
            this.txtboxcp.Location = new System.Drawing.Point(675, 339);
            this.txtboxcp.Name = "txtboxcp";
            this.txtboxcp.Size = new System.Drawing.Size(100, 20);
            this.txtboxcp.TabIndex = 7;
            this.txtboxcp.Visible = false;
            // 
            // txtboxadresse
            // 
            this.txtboxadresse.Location = new System.Drawing.Point(261, 339);
            this.txtboxadresse.Name = "txtboxadresse";
            this.txtboxadresse.Size = new System.Drawing.Size(269, 20);
            this.txtboxadresse.TabIndex = 8;
            this.txtboxadresse.Visible = false;
            // 
            // txtboxcode
            // 
            this.txtboxcode.Location = new System.Drawing.Point(16, 339);
            this.txtboxcode.Name = "txtboxcode";
            this.txtboxcode.Size = new System.Drawing.Size(110, 20);
            this.txtboxcode.TabIndex = 9;
            this.txtboxcode.Visible = false;
            // 
            // txtboxVilleConcours
            // 
            this.txtboxVilleConcours.Location = new System.Drawing.Point(987, 472);
            this.txtboxVilleConcours.Name = "txtboxVilleConcours";
            this.txtboxVilleConcours.Size = new System.Drawing.Size(137, 20);
            this.txtboxVilleConcours.TabIndex = 10;
            this.txtboxVilleConcours.Visible = false;
            // 
            // txtboxsalle
            // 
            this.txtboxsalle.Location = new System.Drawing.Point(16, 472);
            this.txtboxsalle.Name = "txtboxsalle";
            this.txtboxsalle.Size = new System.Drawing.Size(201, 20);
            this.txtboxsalle.TabIndex = 11;
            this.txtboxsalle.Visible = false;
            // 
            // labelcc
            // 
            this.labelcc.AutoSize = true;
            this.labelcc.Location = new System.Drawing.Point(13, 307);
            this.labelcc.Name = "labelcc";
            this.labelcc.Size = new System.Drawing.Size(79, 13);
            this.labelcc.TabIndex = 12;
            this.labelcc.Text = "Code concours";
            this.labelcc.Visible = false;
            // 
            // labeladress
            // 
            this.labeladress.AutoSize = true;
            this.labeladress.Location = new System.Drawing.Point(258, 323);
            this.labeladress.Name = "labeladress";
            this.labeladress.Size = new System.Drawing.Size(92, 13);
            this.labeladress.TabIndex = 13;
            this.labeladress.Text = "adresse Concours";
            this.labeladress.Visible = false;
            // 
            // labelcp
            // 
            this.labelcp.AutoSize = true;
            this.labelcp.Location = new System.Drawing.Point(672, 323);
            this.labelcp.Name = "labelcp";
            this.labelcp.Size = new System.Drawing.Size(68, 13);
            this.labelcp.TabIndex = 14;
            this.labelcp.Text = "CP concours";
            this.labelcp.Visible = false;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(1000, 323);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(78, 13);
            this.labeldate.TabIndex = 15;
            this.labeldate.Text = "DAte concours";
            this.labeldate.Visible = false;
            // 
            // labelsalle
            // 
            this.labelsalle.AutoSize = true;
            this.labelsalle.Location = new System.Drawing.Point(16, 456);
            this.labelsalle.Name = "labelsalle";
            this.labelsalle.Size = new System.Drawing.Size(76, 13);
            this.labelsalle.TabIndex = 16;
            this.labelsalle.Text = "salle Concours";
            this.labelsalle.Visible = false;
            // 
            // labelville
            // 
            this.labelville.AutoSize = true;
            this.labelville.Location = new System.Drawing.Point(1000, 456);
            this.labelville.Name = "labelville";
            this.labelville.Size = new System.Drawing.Size(72, 13);
            this.labelville.TabIndex = 17;
            this.labelville.Text = "ville concours";
            this.labelville.Visible = false;
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(132, 12);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 18;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(940, 339);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Visible = false;
            // 
            // btnValidAjout
            // 
            this.btnValidAjout.Location = new System.Drawing.Point(400, 497);
            this.btnValidAjout.Name = "btnValidAjout";
            this.btnValidAjout.Size = new System.Drawing.Size(84, 23);
            this.btnValidAjout.TabIndex = 20;
            this.btnValidAjout.Text = "Valider l\'Ajout";
            this.btnValidAjout.UseVisualStyleBackColor = true;
            this.btnValidAjout.Visible = false;
            this.btnValidAjout.Click += new System.EventHandler(this.btnValidAjout_Click);
            // 
            // btnReinit
            // 
            this.btnReinit.Location = new System.Drawing.Point(826, 512);
            this.btnReinit.Name = "btnReinit";
            this.btnReinit.Size = new System.Drawing.Size(75, 23);
            this.btnReinit.TabIndex = 21;
            this.btnReinit.Text = "Réinitialiser";
            this.btnReinit.UseVisualStyleBackColor = true;
            this.btnReinit.Visible = false;
            this.btnReinit.Click += new System.EventHandler(this.btnReinit_Click);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(781, 512);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(39, 23);
            this.btnVider.TabIndex = 22;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Visible = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(213, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 23;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Concours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 593);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnReinit);
            this.Controls.Add(this.btnValidAjout);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.labelville);
            this.Controls.Add(this.labelsalle);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labelcp);
            this.Controls.Add(this.labeladress);
            this.Controls.Add(this.labelcc);
            this.Controls.Add(this.txtboxsalle);
            this.Controls.Add(this.txtboxVilleConcours);
            this.Controls.Add(this.txtboxcode);
            this.Controls.Add(this.txtboxadresse);
            this.Controls.Add(this.txtboxcp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.btnValiderModif);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "Concours";
            this.Text = "Concours";
            this.Load += new System.EventHandler(this.Concours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concoursCaninDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concoursCaninDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValiderModif;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource concoursCaninDataSetBindingSource;
        private ConcoursCaninDataSet concoursCaninDataSet;
        private System.Windows.Forms.BindingSource cONCOURSBindingSource;
        private ConcoursCaninDataSetTableAdapters.CONCOURSTableAdapter cONCOURSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salleconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtboxcp;
        private System.Windows.Forms.TextBox txtboxadresse;
        private System.Windows.Forms.TextBox txtboxcode;
        private System.Windows.Forms.TextBox txtboxVilleConcours;
        private System.Windows.Forms.TextBox txtboxsalle;
        private System.Windows.Forms.Label labelcc;
        private System.Windows.Forms.Label labeladress;
        private System.Windows.Forms.Label labelcp;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelsalle;
        private System.Windows.Forms.Label labelville;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnValidAjout;
        private System.Windows.Forms.Button btnReinit;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnQuitter;
    }
}