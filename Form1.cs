using System;
using System.Linq;
using System.Windows.Forms;
using PieceManagerSQLite.Models;
using PieceManagerSQLite.Services;

namespace PieceManagerSQLite
{
    public partial class Form1 : Form
    {
        private readonly PieceService _service = new PieceService();

        public Form1()
        {
            InitializeComponent();
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            var pieces = _service.GetAll();
            dataGridView1.DataSource = pieces.Select(p => new {
                p.Id,
                p.Nom,
                p.Reference,
                p.Prix,
                Disponibilité = p.Disponibilite ? "Oui" : "Non"
            }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var piece = new Piece
            {
                Nom = txtNom.Text,
                Reference = txtReference.Text,
                Prix = decimal.Parse(txtPrix.Text),
                Disponibilite = chkDisponible.Checked
            };
            _service.Add(piece);
            ChargerDonnees();
            EffacerChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

            var piece = new Piece
            {
                Id = id,
                Nom = txtNom.Text,
                Reference = txtReference.Text,
                Prix = decimal.Parse(txtPrix.Text),
                Disponibilite = chkDisponible.Checked
            };
            _service.Update(piece);
            ChargerDonnees();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            _service.Delete(id);
            ChargerDonnees();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            txtNom.Text = dataGridView1.CurrentRow.Cells["Nom"].Value.ToString();
            txtReference.Text = dataGridView1.CurrentRow.Cells["Reference"].Value.ToString();
            txtPrix.Text = dataGridView1.CurrentRow.Cells["Prix"].Value.ToString();
            chkDisponible.Checked = dataGridView1.CurrentRow.Cells["Disponibilité"].Value.ToString() == "Oui";
        }

        private void EffacerChamps()
        {
            txtNom.Clear();
            txtReference.Clear();
            txtPrix.Clear();
            chkDisponible.Checked = false;
        }
    }
}
