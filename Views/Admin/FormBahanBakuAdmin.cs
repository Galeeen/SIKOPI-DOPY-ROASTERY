using System;
using System.Windows.Forms;

namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    public partial class FormBahanBakuAdmin : Form
    {
        public FormBahanBakuAdmin()
        {
            InitializeComponent();
        }

        private void FormBahanBakuAdmin_Load(object sender, EventArgs e)
        {
            panel1.Visible = false; // sembunyikan sidebar duplikat
        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void tabGreenAdmin_Click(object sender, EventArgs e) { }
        private void dgvRoastAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void btnBahanBakuAdmin1_Click(object sender, EventArgs e) { }
    }


}