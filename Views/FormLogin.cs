using SIKOPI_DOPY_ROASTERY.Controllers;
using SIKOPI_DOPY_ROASTERY.Helpers;
using SIKOPI_DOPY_ROASTERY.Models;
using SIKOPI_DOPY_ROASTERY.Repositories;
using SIKOPI_DOPY_ROASTERY.Views.Admin;
using SIKOPI_DOPY_ROASTERY.Views.Penjual;
using SIKOPI_DOPY_ROASTERY.Views.Roastery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIKOPI_DOPY_ROASTERY.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = new AuthController(new RepositoriUser());
                var pengguna = auth.Login(txtUsername.Text, txtPassword.Text);

                if (pengguna != null)  // ← pakai != null, bukan langsung if
                {
                    SesiAktif.Masuk(pengguna);  // simpan user ke sesi
                    this.Hide();

                    Form shell;
                    if (SesiAktif.Peran == "admin")
                        shell = new FormUtamaAdmin();
                    else if (SesiAktif.Peran == "roaster")   // ← ubah dari "produksi" jadi "roaster"
                        shell = new FormUtamaRoaster();
                    else
                        shell = new FormUtamaPenjual();

                    shell.FormClosed += (s, a) => this.Close();
                    shell.Show();
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
