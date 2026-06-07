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
            dgvPergerakanAdmin = new DataGridView();
            tabTransaksiAdmin = new TabPage();
            dgvTransaksiAdmin = new DataGridView();
            cmbArahAdmin = new ComboBox();
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
            tabRiwayatAdmin.Location = new Point(69, 72);
            tabRiwayatAdmin.Margin = new Padding(4, 4, 4, 4);
            tabRiwayatAdmin.Name = "tabRiwayatAdmin";
            tabRiwayatAdmin.SelectedIndex = 0;
            tabRiwayatAdmin.Size = new Size(712, 415);
            tabRiwayatAdmin.TabIndex = 0;
            tabRiwayatAdmin.SelectedIndexChanged += tabRiwayatAdmin_SelectedIndexChanged;
            // 
            // tabPergerakanStokAdmin
            // 
            tabPergerakanStokAdmin.Controls.Add(dgvPergerakanAdmin);
            tabPergerakanStokAdmin.Location = new Point(4, 34);
            tabPergerakanStokAdmin.Margin = new Padding(4, 4, 4, 4);
            tabPergerakanStokAdmin.Name = "tabPergerakanStokAdmin";
            tabPergerakanStokAdmin.Padding = new Padding(4, 4, 4, 4);
            tabPergerakanStokAdmin.Size = new Size(704, 377);
            tabPergerakanStokAdmin.TabIndex = 0;
            tabPergerakanStokAdmin.Text = "tabPage1";
            tabPergerakanStokAdmin.UseVisualStyleBackColor = true;
            tabPergerakanStokAdmin.Click += tabPergerakanStokAdmin_Click;
            // 
            // dgvPergerakanAdmin
            // 
            dgvPergerakanAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPergerakanAdmin.Location = new Point(32, 140);
            dgvPergerakanAdmin.Margin = new Padding(4, 4, 4, 4);
            dgvPergerakanAdmin.Name = "dgvPergerakanAdmin";
            dgvPergerakanAdmin.RowHeadersWidth = 51;
            dgvPergerakanAdmin.Size = new Size(636, 209);
            dgvPergerakanAdmin.TabIndex = 0;
            // 
            // tabTransaksiAdmin
            // 
            tabTransaksiAdmin.Controls.Add(dgvTransaksiAdmin);
            tabTransaksiAdmin.Location = new Point(4, 34);
            tabTransaksiAdmin.Margin = new Padding(4, 4, 4, 4);
            tabTransaksiAdmin.Name = "tabTransaksiAdmin";
            tabTransaksiAdmin.Padding = new Padding(4, 4, 4, 4);
            tabTransaksiAdmin.Size = new Size(704, 377);
            tabTransaksiAdmin.TabIndex = 1;
            tabTransaksiAdmin.Text = "tabPage2";
            tabTransaksiAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksiAdmin
            // 
            dgvTransaksiAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiAdmin.Location = new Point(21, 32);
            dgvTransaksiAdmin.Margin = new Padding(4, 4, 4, 4);
            dgvTransaksiAdmin.Name = "dgvTransaksiAdmin";
            dgvTransaksiAdmin.RowHeadersWidth = 51;
            dgvTransaksiAdmin.Size = new Size(674, 221);
            dgvTransaksiAdmin.TabIndex = 0;
            // 
            // cmbArahAdmin
            // 
            cmbArahAdmin.FormattingEnabled = true;
            cmbArahAdmin.Location = new Point(310, 38);
            cmbArahAdmin.Margin = new Padding(4, 4, 4, 4);
            cmbArahAdmin.Name = "cmbArahAdmin";
            cmbArahAdmin.Size = new Size(188, 33);
            cmbArahAdmin.TabIndex = 1;
            // 
            // cmbKategoriAdmin
            // 
            cmbKategoriAdmin.FormattingEnabled = true;
            cmbKategoriAdmin.Location = new Point(531, 38);
            cmbKategoriAdmin.Margin = new Padding(4, 4, 4, 4);
            cmbKategoriAdmin.Name = "cmbKategoriAdmin";
            cmbKategoriAdmin.Size = new Size(188, 33);
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
            txtCariAdmin.Location = new Point(756, 38);
            txtCariAdmin.Margin = new Padding(4, 4, 4, 4);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(155, 31);
            txtCariAdmin.TabIndex = 4;
            // 
            // FormRiwayatAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(txtCariAdmin);
            Controls.Add(cmbKategoriAdmin);
            Controls.Add(cmbArahAdmin);
            Controls.Add(tabRiwayatAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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