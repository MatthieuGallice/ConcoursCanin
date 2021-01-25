namespace ConcourCanin
{
    partial class Notes
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
            this.concoursCaninDataSet = new ConcourCanin.ConcoursCaninDataSet();
            this.cONCOURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONCOURSTableAdapter = new ConcourCanin.ConcoursCaninDataSetTableAdapters.CONCOURSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomChien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPropriétaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtboxNote = new System.Windows.Forms.TextBox();
            this.cboxProp = new System.Windows.Forms.ComboBox();
            this.cboxChien = new System.Windows.Forms.ComboBox();
            this.cboxConc = new System.Windows.Forms.ComboBox();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblChien = new System.Windows.Forms.Label();
            this.lblConcour = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnValiderModif = new System.Windows.Forms.Button();
            this.btnValiderAjout = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.codeproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codechienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTICIPEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pROPRIETAIREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTICIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTICIPEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.concoursCaninDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETAIREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // concoursCaninDataSet
            // 
            this.concoursCaninDataSet.DataSetName = "ConcoursCaninDataSet";
            this.concoursCaninDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONCOURSBindingSource
            // 
            this.cONCOURSBindingSource.DataMember = "CONCOURS";
            this.cONCOURSBindingSource.DataSource = this.concoursCaninDataSet;
            // 
            // cONCOURSTableAdapter
            // 
            this.cONCOURSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomChien,
            this.NomPropriétaire,
            this.codeproprietaireDataGridViewTextBoxColumn,
            this.codechienDataGridViewTextBoxColumn,
            this.codeconcoursDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pARTICIPEBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(544, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // NomChien
            // 
            this.NomChien.HeaderText = "NomChien";
            this.NomChien.Name = "NomChien";
            // 
            // NomPropriétaire
            // 
            this.NomPropriétaire.HeaderText = "NomPropriétaire";
            this.NomPropriétaire.Name = "NomPropriétaire";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(118, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnAjouterUnConcours_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(687, 447);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(544, 447);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(416, 447);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtboxNote
            // 
            this.txtboxNote.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtboxNote.Location = new System.Drawing.Point(970, 449);
            this.txtboxNote.Name = "txtboxNote";
            this.txtboxNote.Size = new System.Drawing.Size(100, 20);
            this.txtboxNote.TabIndex = 6;
            // 
            // cboxProp
            // 
            this.cboxProp.FormattingEnabled = true;
            this.cboxProp.Location = new System.Drawing.Point(38, 352);
            this.cboxProp.Name = "cboxProp";
            this.cboxProp.Size = new System.Drawing.Size(183, 21);
            this.cboxProp.TabIndex = 7;
            this.cboxProp.TextChanged += new System.EventHandler(this.cboxProp_TextChanged);
            // 
            // cboxChien
            // 
            this.cboxChien.FormattingEnabled = true;
            this.cboxChien.Location = new System.Drawing.Point(504, 352);
            this.cboxChien.Name = "cboxChien";
            this.cboxChien.Size = new System.Drawing.Size(206, 21);
            this.cboxChien.TabIndex = 8;
            this.cboxChien.Visible = false;
            // 
            // cboxConc
            // 
            this.cboxConc.FormattingEnabled = true;
            this.cboxConc.Location = new System.Drawing.Point(970, 351);
            this.cboxConc.Name = "cboxConc";
            this.cboxConc.Size = new System.Drawing.Size(184, 21);
            this.cboxConc.TabIndex = 9;
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Location = new System.Drawing.Point(35, 335);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(60, 13);
            this.lblProp.TabIndex = 10;
            this.lblProp.Text = "Propriétaire";
            // 
            // lblChien
            // 
            this.lblChien.AutoSize = true;
            this.lblChien.Location = new System.Drawing.Point(501, 335);
            this.lblChien.Name = "lblChien";
            this.lblChien.Size = new System.Drawing.Size(34, 13);
            this.lblChien.TabIndex = 11;
            this.lblChien.Text = "Chien";
            // 
            // lblConcour
            // 
            this.lblConcour.AutoSize = true;
            this.lblConcour.Location = new System.Drawing.Point(967, 335);
            this.lblConcour.Name = "lblConcour";
            this.lblConcour.Size = new System.Drawing.Size(52, 13);
            this.lblConcour.TabIndex = 12;
            this.lblConcour.Text = "Concours";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(967, 433);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Note";
            // 
            // btnValiderModif
            // 
            this.btnValiderModif.Location = new System.Drawing.Point(544, 504);
            this.btnValiderModif.Name = "btnValiderModif";
            this.btnValiderModif.Size = new System.Drawing.Size(92, 23);
            this.btnValiderModif.TabIndex = 14;
            this.btnValiderModif.Text = "Valider Modif";
            this.btnValiderModif.UseVisualStyleBackColor = true;
            this.btnValiderModif.Visible = false;
            this.btnValiderModif.Click += new System.EventHandler(this.btnValiderModif_Click);
            // 
            // btnValiderAjout
            // 
            this.btnValiderAjout.Location = new System.Drawing.Point(416, 504);
            this.btnValiderAjout.Name = "btnValiderAjout";
            this.btnValiderAjout.Size = new System.Drawing.Size(75, 23);
            this.btnValiderAjout.TabIndex = 15;
            this.btnValiderAjout.Text = "Valider Ajout";
            this.btnValiderAjout.UseVisualStyleBackColor = true;
            this.btnValiderAjout.Visible = false;
            this.btnValiderAjout.Click += new System.EventHandler(this.btnValiderAjout_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(877, 504);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(92, 23);
            this.btnReinitialiser.TabIndex = 16;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Visible = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(136, 12);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 19;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(829, 504);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(42, 23);
            this.btnVider.TabIndex = 20;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Visible = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // codeproprietaireDataGridViewTextBoxColumn
            // 
            this.codeproprietaireDataGridViewTextBoxColumn.DataPropertyName = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.HeaderText = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.Name = "codeproprietaireDataGridViewTextBoxColumn";
            // 
            // codechienDataGridViewTextBoxColumn
            // 
            this.codechienDataGridViewTextBoxColumn.DataPropertyName = "codechien";
            this.codechienDataGridViewTextBoxColumn.HeaderText = "codechien";
            this.codechienDataGridViewTextBoxColumn.Name = "codechienDataGridViewTextBoxColumn";
            // 
            // codeconcoursDataGridViewTextBoxColumn
            // 
            this.codeconcoursDataGridViewTextBoxColumn.DataPropertyName = "codeconcours";
            this.codeconcoursDataGridViewTextBoxColumn.HeaderText = "codeconcours";
            this.codeconcoursDataGridViewTextBoxColumn.Name = "codeconcoursDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // pARTICIPEBindingSource2
            // 
            this.pARTICIPEBindingSource2.DataSource = typeof(ConcourCanin.PARTICIPE);
            // 
            // pROPRIETAIREBindingSource
            // 
            this.pROPRIETAIREBindingSource.DataSource = typeof(ConcourCanin.PROPRIETAIRE);
            // 
            // pARTICIPEBindingSource
            // 
            this.pARTICIPEBindingSource.DataSource = typeof(ConcourCanin.PARTICIPE);
            // 
            // pARTICIPEBindingSource1
            // 
            this.pARTICIPEBindingSource1.DataSource = typeof(ConcourCanin.PARTICIPE);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(217, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 21;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 612);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnValiderAjout);
            this.Controls.Add(this.btnValiderModif);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblConcour);
            this.Controls.Add(this.lblChien);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.cboxConc);
            this.Controls.Add(this.cboxChien);
            this.Controls.Add(this.cboxProp);
            this.Controls.Add(this.txtboxNote);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concoursCaninDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETAIREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ConcoursCaninDataSet concoursCaninDataSet;
        private System.Windows.Forms.BindingSource cONCOURSBindingSource;
        private ConcoursCaninDataSetTableAdapters.CONCOURSTableAdapter cONCOURSTableAdapter;
        private System.Windows.Forms.BindingSource pARTICIPEBindingSource;
        private System.Windows.Forms.BindingSource pROPRIETAIREBindingSource;
        private System.Windows.Forms.BindingSource pARTICIPEBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pARTICIPEBindingSource2;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtboxNote;
        private System.Windows.Forms.ComboBox cboxProp;
        private System.Windows.Forms.ComboBox cboxChien;
        private System.Windows.Forms.ComboBox cboxConc;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.Label lblChien;
        private System.Windows.Forms.Label lblConcour;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomChien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPropriétaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnValiderModif;
        private System.Windows.Forms.Button btnValiderAjout;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnQuitter;
    }
}