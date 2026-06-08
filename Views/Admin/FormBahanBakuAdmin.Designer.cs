namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    partial class FormBahanBakuAdmin
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
            txtCariAdmin = new TextBox();
            btnTambahGreenAdmin = new Button();
            btnEditGreenAdmin = new Button();
            btnHapusGreenAdmin = new Button();
            btnSetHargaAdmin = new Button();
            label14 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            btnKeluarAdmin = new Button();
            lblSelamatDatangAdmin = new Label();
            btnManajemenUserAdmin1 = new Button();
            btnDasboardAdmin1 = new Button();
            btnRiwayatAdmin1 = new Button();
            btnBahanBakuAdmin1 = new Button();
            btnEtalaseAdmin1 = new Button();
            btnRoastingAdmin1 = new Button();
            panelKontenAdmin = new Panel();
            panel3 = new Panel();
            tabRoastAdmin = new TabPage();
            dgvRoastAdmin = new DataGridView();
            tabGreenAdmin = new TabPage();
            dgvGreenAdmin = new DataGridView();
            tabBahanAdmin = new TabControl();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabRoastAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastAdmin).BeginInit();
            tabGreenAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).BeginInit();
            tabBahanAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(482, 588);
            txtCariAdmin.Margin = new Padding(4);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(384, 31);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnTambahGreenAdmin
            // 
            btnTambahGreenAdmin.Location = new Point(1015, 602);
            btnTambahGreenAdmin.Margin = new Padding(4);
            btnTambahGreenAdmin.Name = "btnTambahGreenAdmin";
            btnTambahGreenAdmin.Size = new Size(118, 36);
            btnTambahGreenAdmin.TabIndex = 2;
            btnTambahGreenAdmin.Text = "button1";
            btnTambahGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEditGreenAdmin
            // 
            btnEditGreenAdmin.Location = new Point(855, 627);
            btnEditGreenAdmin.Margin = new Padding(4);
            btnEditGreenAdmin.Name = "btnEditGreenAdmin";
            btnEditGreenAdmin.Size = new Size(118, 36);
            btnEditGreenAdmin.TabIndex = 3;
            btnEditGreenAdmin.Text = "button2";
            btnEditGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnHapusGreenAdmin
            // 
            btnHapusGreenAdmin.Location = new Point(543, 627);
            btnHapusGreenAdmin.Margin = new Padding(4);
            btnHapusGreenAdmin.Name = "btnHapusGreenAdmin";
            btnHapusGreenAdmin.Size = new Size(118, 36);
            btnHapusGreenAdmin.TabIndex = 4;
            btnHapusGreenAdmin.Text = "button3";
            btnHapusGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSetHargaAdmin
            // 
            btnSetHargaAdmin.Location = new Point(690, 627);
            btnSetHargaAdmin.Margin = new Padding(4);
            btnSetHargaAdmin.Name = "btnSetHargaAdmin";
            btnSetHargaAdmin.Size = new Size(118, 36);
            btnSetHargaAdmin.TabIndex = 5;
            btnSetHargaAdmin.Text = "button4";
            btnSetHargaAdmin.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(25, 36);
            label14.Name = "label14";
            label14.Size = new Size(182, 21);
            label14.TabIndex = 13;
            label14.Text = "Sistem Kopi Digital Dopy";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(0, 67);
            panel7.Name = "panel7";
            panel7.Size = new Size(350, 4);
            panel7.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(17, 47);
            label4.Name = "label4";
            label4.Size = new Size(373, 25);
            label4.TabIndex = 1;
            label4.Text = "Kelola Stok Green Bean dan Harga Roast Bean";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 15);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 0;
            label3.Text = "Bahan Baku";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(366, 46);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 110);
            panel2.TabIndex = 20;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 385);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 10;
            label2.Text = "ADMIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 290);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 9;
            label1.Text = "PRODUK DAN JUAL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnKeluarAdmin);
            panel1.Controls.Add(lblSelamatDatangAdmin);
            panel1.Controls.Add(btnManajemenUserAdmin1);
            panel1.Controls.Add(btnDasboardAdmin1);
            panel1.Controls.Add(btnRiwayatAdmin1);
            panel1.Controls.Add(btnBahanBakuAdmin1);
            panel1.Controls.Add(btnEtalaseAdmin1);
            panel1.Controls.Add(btnRoastingAdmin1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 922);
            panel1.TabIndex = 19;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(25, 6);
            label13.Name = "label13";
            label13.Size = new Size(149, 30);
            label13.TabIndex = 12;
            label13.Text = "SIKOPI DOPY";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnKeluarAdmin
            // 
            btnKeluarAdmin.BackColor = Color.RoyalBlue;
            btnKeluarAdmin.FlatStyle = FlatStyle.Flat;
            btnKeluarAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluarAdmin.ForeColor = Color.Black;
            btnKeluarAdmin.Location = new Point(25, 660);
            btnKeluarAdmin.Margin = new Padding(5);
            btnKeluarAdmin.Name = "btnKeluarAdmin";
            btnKeluarAdmin.Size = new Size(120, 40);
            btnKeluarAdmin.TabIndex = 6;
            btnKeluarAdmin.Text = "Logout";
            btnKeluarAdmin.UseVisualStyleBackColor = false;
            // 
            // lblSelamatDatangAdmin
            // 
            lblSelamatDatangAdmin.AutoSize = true;
            lblSelamatDatangAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelamatDatangAdmin.Location = new Point(25, 80);
            lblSelamatDatangAdmin.Margin = new Padding(5, 0, 5, 0);
            lblSelamatDatangAdmin.Name = "lblSelamatDatangAdmin";
            lblSelamatDatangAdmin.Size = new Size(78, 25);
            lblSelamatDatangAdmin.TabIndex = 8;
            lblSelamatDatangAdmin.Text = "UTAMA";
            // 
            // btnManajemenUserAdmin1
            // 
            btnManajemenUserAdmin1.BackColor = Color.RoyalBlue;
            btnManajemenUserAdmin1.FlatStyle = FlatStyle.Flat;
            btnManajemenUserAdmin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManajemenUserAdmin1.ForeColor = Color.Black;
            btnManajemenUserAdmin1.Location = new Point(25, 480);
            btnManajemenUserAdmin1.Margin = new Padding(5);
            btnManajemenUserAdmin1.Name = "btnManajemenUserAdmin1";
            btnManajemenUserAdmin1.Size = new Size(300, 40);
            btnManajemenUserAdmin1.TabIndex = 5;
            btnManajemenUserAdmin1.Text = "Manajemen User";
            btnManajemenUserAdmin1.UseVisualStyleBackColor = false;
            // 
            // btnDasboardAdmin1
            // 
            btnDasboardAdmin1.BackColor = Color.RoyalBlue;
            btnDasboardAdmin1.BackgroundImageLayout = ImageLayout.None;
            btnDasboardAdmin1.FlatStyle = FlatStyle.Flat;
            btnDasboardAdmin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDasboardAdmin1.ForeColor = Color.Black;
            btnDasboardAdmin1.Location = new Point(25, 125);
            btnDasboardAdmin1.Margin = new Padding(5);
            btnDasboardAdmin1.Name = "btnDasboardAdmin1";
            btnDasboardAdmin1.Size = new Size(300, 40);
            btnDasboardAdmin1.TabIndex = 0;
            btnDasboardAdmin1.Text = "Dashboard";
            btnDasboardAdmin1.UseVisualStyleBackColor = false;
            // 
            // btnRiwayatAdmin1
            // 
            btnRiwayatAdmin1.BackColor = Color.RoyalBlue;
            btnRiwayatAdmin1.FlatStyle = FlatStyle.Flat;
            btnRiwayatAdmin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatAdmin1.ForeColor = Color.Black;
            btnRiwayatAdmin1.Location = new Point(25, 425);
            btnRiwayatAdmin1.Margin = new Padding(5);
            btnRiwayatAdmin1.Name = "btnRiwayatAdmin1";
            btnRiwayatAdmin1.Size = new Size(300, 40);
            btnRiwayatAdmin1.TabIndex = 4;
            btnRiwayatAdmin1.Text = "Riwayat";
            btnRiwayatAdmin1.UseVisualStyleBackColor = false;
            // 
            // btnBahanBakuAdmin1
            // 
            btnBahanBakuAdmin1.BackColor = Color.RoyalBlue;
            btnBahanBakuAdmin1.FlatStyle = FlatStyle.Flat;
            btnBahanBakuAdmin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBahanBakuAdmin1.ForeColor = Color.Black;
            btnBahanBakuAdmin1.Location = new Point(25, 180);
            btnBahanBakuAdmin1.Margin = new Padding(5);
            btnBahanBakuAdmin1.Name = "btnBahanBakuAdmin1";
            btnBahanBakuAdmin1.Size = new Size(300, 40);
            btnBahanBakuAdmin1.TabIndex = 1;
            btnBahanBakuAdmin1.Text = "Bahan Baku";
            btnBahanBakuAdmin1.UseVisualStyleBackColor = false;
            // 
            // btnEtalaseAdmin1
            // 
            btnEtalaseAdmin1.BackColor = Color.RoyalBlue;
            btnEtalaseAdmin1.FlatStyle = FlatStyle.Flat;
            btnEtalaseAdmin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEtalaseAdmin1.ForeColor = Color.Black;
            btnEtalaseAdmin1.Location = new Point(25, 330);
            btnEtalaseAdmin1.Margin = new Padding(5);
            btnEtalaseAdmin1.Name = "btnEtalaseAdmin1";
            btnEtalaseAdmin1.Size = new Size(300, 40);
            btnEtalaseAdmin1.TabIndex = 3;
            btnEtalaseAdmin1.Text = "Etalase Toko";
            btnEtalaseAdmin1.UseVisualStyleBackColor = false;
            // 
            // btnRoastingAdmin1
            // 
            btnRoastingAdmin1.BackColor = Color.RoyalBlue;
            btnRoastingAdmin1.FlatStyle = FlatStyle.Flat;
            btnRoastingAdmin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoastingAdmin1.ForeColor = Color.Black;
            btnRoastingAdmin1.Location = new Point(25, 235);
            btnRoastingAdmin1.Margin = new Padding(5);
            btnRoastingAdmin1.Name = "btnRoastingAdmin1";
            btnRoastingAdmin1.Size = new Size(300, 40);
            btnRoastingAdmin1.TabIndex = 2;
            btnRoastingAdmin1.Text = "Batch Roasting";
            btnRoastingAdmin1.UseVisualStyleBackColor = false;
            // 
            // panelKontenAdmin
            // 
            panelKontenAdmin.BackColor = Color.White;
            panelKontenAdmin.Location = new Point(250, -101);
            panelKontenAdmin.Margin = new Padding(5);
            panelKontenAdmin.Name = "panelKontenAdmin";
            panelKontenAdmin.Size = new Size(1030, 100);
            panelKontenAdmin.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(350, 0);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(933, 36);
            panel3.TabIndex = 21;
            // 
            // tabRoastAdmin
            // 
            tabRoastAdmin.Controls.Add(dgvRoastAdmin);
            tabRoastAdmin.Location = new Point(4, 34);
            tabRoastAdmin.Margin = new Padding(4);
            tabRoastAdmin.Name = "tabRoastAdmin";
            tabRoastAdmin.Padding = new Padding(4);
            tabRoastAdmin.Size = new Size(803, 328);
            tabRoastAdmin.TabIndex = 1;
            tabRoastAdmin.Text = "tabPage2";
            tabRoastAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvRoastAdmin
            // 
            dgvRoastAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastAdmin.Location = new Point(13, 16);
            dgvRoastAdmin.Margin = new Padding(4);
            dgvRoastAdmin.Name = "dgvRoastAdmin";
            dgvRoastAdmin.RowHeadersWidth = 51;
            dgvRoastAdmin.Size = new Size(765, 290);
            dgvRoastAdmin.TabIndex = 0;
            dgvRoastAdmin.CellContentClick += dgvRoastAdmin_CellContentClick;
            // 
            // tabGreenAdmin
            // 
            tabGreenAdmin.Controls.Add(dgvGreenAdmin);
            tabGreenAdmin.Location = new Point(4, 34);
            tabGreenAdmin.Margin = new Padding(4);
            tabGreenAdmin.Name = "tabGreenAdmin";
            tabGreenAdmin.Padding = new Padding(4);
            tabGreenAdmin.Size = new Size(803, 328);
            tabGreenAdmin.TabIndex = 0;
            tabGreenAdmin.Text = "tabPage1";
            tabGreenAdmin.UseVisualStyleBackColor = true;
            tabGreenAdmin.Click += tabGreenAdmin_Click;
            // 
            // dgvGreenAdmin
            // 
            dgvGreenAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenAdmin.Location = new Point(13, 11);
            dgvGreenAdmin.Margin = new Padding(4);
            dgvGreenAdmin.Name = "dgvGreenAdmin";
            dgvGreenAdmin.RowHeadersWidth = 51;
            dgvGreenAdmin.Size = new Size(772, 295);
            dgvGreenAdmin.TabIndex = 0;
            // 
            // tabBahanAdmin
            // 
            tabBahanAdmin.Controls.Add(tabGreenAdmin);
            tabBahanAdmin.Controls.Add(tabRoastAdmin);
            tabBahanAdmin.Location = new Point(366, 180);
            tabBahanAdmin.Margin = new Padding(4);
            tabBahanAdmin.Name = "tabBahanAdmin";
            tabBahanAdmin.SelectedIndex = 0;
            tabBahanAdmin.Size = new Size(811, 366);
            tabBahanAdmin.TabIndex = 0;
            // 
            // FormBahanBakuAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelKontenAdmin);
            Controls.Add(btnSetHargaAdmin);
            Controls.Add(btnHapusGreenAdmin);
            Controls.Add(btnEditGreenAdmin);
            Controls.Add(btnTambahGreenAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(tabBahanAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormBahanBakuAdmin";
            Text = "FormBahanBakuAdmin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabRoastAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoastAdmin).EndInit();
            tabGreenAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).EndInit();
            tabBahanAdmin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCariAdmin;
        private Button btnTambahGreenAdmin;
        private Button btnEditGreenAdmin;
        private Button btnHapusGreenAdmin;
        private Button btnSetHargaAdmin;
        private Label label14;
        private Panel panel7;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label13;
        private Button btnKeluarAdmin;
        private Label lblSelamatDatangAdmin;
        private Button btnManajemenUserAdmin1;
        private Button btnDasboardAdmin1;
        private Button btnRiwayatAdmin1;
        private Button btnBahanBakuAdmin1;
        private Button btnEtalaseAdmin1;
        private Button btnRoastingAdmin1;
        private Panel panelKontenAdmin;
        private Panel panel3;
        private TabPage tabRoastAdmin;
        private DataGridView dgvRoastAdmin;
        private TabPage tabGreenAdmin;
        private DataGridView dgvGreenAdmin;
        private TabControl tabBahanAdmin;
    }
}