using SIKOPI_DOPY_ROASTERY.Controllers;
using SIKOPI_DOPY_ROASTERY.Helpers;
using SIKOPI_DOPY_ROASTERY.Repositories;
using System;
using System.Windows.Forms;

namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    public partial class FormUtamaAdmin : Form
    {
        public FormUtamaAdmin()
        {
            InitializeComponent();
        }

        private void FormUtamaAdmin_Load(object sender, EventArgs e)
        {
            lblSelamatDatangAdmin.Text = $"Selamat datang, {SesiAktif.PenggunaSaatIni.Nama}";
        }

        private void btnDasboardAdmin_Click(object sender, EventArgs e)
        {
            // nanti diisi setelah FormDashboardAdmin dibuat
        }

        private void btnBahanBakuAdmin_Click(object sender, EventArgs e)
        {
            BukaDiPanel(new FormBahanBakuAdmin());
        }

        private void BukaDiPanel(Form form)
        {
            panelKontenAdmin.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelKontenAdmin.Controls.Add(form);
            form.Show();
        }

        private void btnRoastingAdmin_Click(object sender, EventArgs e)
        {
            // nanti diisi setelah FormRoastingAdmin dibuat
        }

        private void btnEtalaseAdmin_Click(object sender, EventArgs e)
        {
            // nanti
        }

        private void btnRiwayatAdmin_Click(object sender, EventArgs e)
        {
            // nanti
        }

        private void btnManajemenUserAdmin_Click(object sender, EventArgs e)
        {
            // nanti
        }

        private void btnKeluarAdmin_Click(object sender, EventArgs e)
        {
            SesiAktif.Keluar();
            this.Close();
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void dgvStokGreenBean_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}