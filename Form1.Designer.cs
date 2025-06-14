namespace PieceManagerSQLite
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDisponibilite;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDisponibilite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Size = new System.Drawing.Size(560, 200);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(120, 20);
            this.txtNom.Size = new System.Drawing.Size(200, 23);
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(120, 50);
            this.txtReference.Size = new System.Drawing.Size(200, 23);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(120, 80);
            this.txtPrix.Size = new System.Drawing.Size(200, 23);
            // 
            // chkDisponible
            // 
            this.chkDisponible.Location = new System.Drawing.Point(120, 110);
            this.chkDisponible.Text = "Disponible";
            this.chkDisponible.AutoSize = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(350, 20);
            this.btnAjouter.Size = new System.Drawing.Size(100, 30);
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(350, 60);
            this.btnModifier.Size = new System.Drawing.Size(100, 30);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(350, 100);
            this.btnSupprimer.Size = new System.Drawing.Size(100, 30);
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(20, 20);
            this.lblNom.Size = new System.Drawing.Size(100, 23);
            this.lblNom.Text = "Nom :";
            // 
            // lblReference
            // 
            this.lblReference.Location = new System.Drawing.Point(20, 50);
            this.lblReference.Size = new System.Drawing.Size(100, 23);
            this.lblReference.Text = "Référence :";
            // 
            // lblPrix
            // 
            this.lblPrix.Location = new System.Drawing.Point(20, 80);
            this.lblPrix.Size = new System.Drawing.Size(100, 23);
            this.lblPrix.Text = "Prix :";
            // 
            // lblDisponibilite
            // 
            this.lblDisponibilite.Location = new System.Drawing.Point(20, 110);
            this.lblDisponibilite.Size = new System.Drawing.Size(100, 23);
            this.lblDisponibilite.Text = "Disponibilité :";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblDisponibilite);
            this.Text = "Gestion des pièces";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
