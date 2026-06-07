namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    partial class FormRiwayatAdmin
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
            components = new System.ComponentModel.Container();
            tabRiwayatAdmin = new TabControl();
            tabPergerakanStokAdmin = new TabPage();
            cmbArahAdmin = new ComboBox();
            dgvPergerakanAdmin = new DataGridView();
            tabTransaksiAdmin = new TabPage();
            dgvTransaksiAdmin = new DataGridView();
            cmbKategoriAdmin = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtCariAdmin = new TextBox();
            tabRiwayatAdmin.SuspendLayout();
            tabPergerakanStokAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanAdmin).BeginInit();
            tabTransaksiAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiAdmin).BeginInit();
            SuspendLayout();
            // 
            // tabRiwayatAdmin
            // 
            tabRiwayatAdmin.Controls.Add(tabPergerakanStokAdmin);
            tabRiwayatAdmin.Controls.Add(tabTransaksiAdmin);
            tabRiwayatAdmin.Location = new Point(55, 58);
            tabRiwayatAdmin.Name = "tabRiwayatAdmin";
            tabRiwayatAdmin.SelectedIndex = 0;
            tabRiwayatAdmin.Size = new Size(570, 332);
            tabRiwayatAdmin.TabIndex = 0;
            tabRiwayatAdmin.SelectedIndexChanged += tabRiwayatAdmin_SelectedIndexChanged;
            // 
            // tabPergerakanStokAdmin
            // 
            tabPergerakanStokAdmin.Controls.Add(dgvPergerakanAdmin);
            tabPergerakanStokAdmin.Location = new Point(4, 29);
            tabPergerakanStokAdmin.Name = "tabPergerakanStokAdmin";
            tabPergerakanStokAdmin.Padding = new Padding(3);
            tabPergerakanStokAdmin.Size = new Size(562, 299);
            tabPergerakanStokAdmin.TabIndex = 0;
            tabPergerakanStokAdmin.Text = "tabPage1";
            tabPergerakanStokAdmin.UseVisualStyleBackColor = true;
            tabPergerakanStokAdmin.Click += tabPergerakanStokAdmin_Click;
            // 
            // cmbArahAdmin
            // 
            cmbArahAdmin.FormattingEnabled = true;
            cmbArahAdmin.Location = new Point(248, 30);
            cmbArahAdmin.Name = "cmbArahAdmin";
            cmbArahAdmin.Size = new Size(151, 28);
            cmbArahAdmin.TabIndex = 1;
            // 
            // dgvPergerakanAdmin
            // 
            dgvPergerakanAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPergerakanAdmin.Location = new Point(26, 112);
            dgvPergerakanAdmin.Name = "dgvPergerakanAdmin";
            dgvPergerakanAdmin.RowHeadersWidth = 51;
            dgvPergerakanAdmin.Size = new Size(509, 167);
            dgvPergerakanAdmin.TabIndex = 0;
            // 
            // tabTransaksiAdmin
            // 
            tabTransaksiAdmin.Controls.Add(dgvTransaksiAdmin);
            tabTransaksiAdmin.Location = new Point(4, 29);
            tabTransaksiAdmin.Name = "tabTransaksiAdmin";
            tabTransaksiAdmin.Padding = new Padding(3);
            tabTransaksiAdmin.Size = new Size(562, 329);
            tabTransaksiAdmin.TabIndex = 1;
            tabTransaksiAdmin.Text = "tabPage2";
            tabTransaksiAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksiAdmin
            // 
            dgvTransaksiAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiAdmin.Location = new Point(17, 26);
            dgvTransaksiAdmin.Name = "dgvTransaksiAdmin";
            dgvTransaksiAdmin.RowHeadersWidth = 51;
            dgvTransaksiAdmin.Size = new Size(539, 177);
            dgvTransaksiAdmin.TabIndex = 0;
            // 
            // cmbKategoriAdmin
            // 
            cmbKategoriAdmin.FormattingEnabled = true;
            cmbKategoriAdmin.Location = new Point(425, 30);
            cmbKategoriAdmin.Name = "cmbKategoriAdmin";
            cmbKategoriAdmin.Size = new Size(151, 28);
            cmbKategoriAdmin.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(605, 30);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(125, 27);
            txtCariAdmin.TabIndex = 4;
            // 
            // FormRiwayatAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCariAdmin);
            Controls.Add(cmbKategoriAdmin);
            Controls.Add(cmbArahAdmin);
            Controls.Add(tabRiwayatAdmin);
            Name = "FormRiwayatAdmin";
            Text = "FormRiwayatAdmin";
            tabRiwayatAdmin.ResumeLayout(false);
            tabPergerakanStokAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanAdmin).EndInit();
            tabTransaksiAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabRiwayatAdmin;
        private TabPage tabPergerakanStokAdmin;
        private TabPage tabTransaksiAdmin;
        private ComboBox cmbArahAdmin;
        private DataGridView dgvPergerakanAdmin;
        private DataGridView dgvTransaksiAdmin;
        private ComboBox cmbKategoriAdmin;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtCariAdmin;
    }
}