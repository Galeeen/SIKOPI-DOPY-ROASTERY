namespace SIKOPI_DOPY_ROASTERY.Views.Roastery
{
    partial class FormRiwayatRoaster
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
            txtCariRoaster = new TextBox();
            cmbKategoriRoaster = new ComboBox();
            cmbArahRoaster = new ComboBox();
            tabRiwayatRoaster = new TabControl();
            tabPergerakanStokRoaster = new TabPage();
            dgvPergerakanRoaster = new DataGridView();
            tabTransaksiRoaster = new TabPage();
            dgvTransaksiRoaster = new DataGridView();
            tabRiwayatRoaster.SuspendLayout();
            tabPergerakanStokRoaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanRoaster).BeginInit();
            tabTransaksiRoaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiRoaster).BeginInit();
            SuspendLayout();
            // 
            // txtCariRoaster
            // 
            txtCariRoaster.Location = new Point(613, 45);
            txtCariRoaster.Name = "txtCariRoaster";
            txtCariRoaster.Size = new Size(125, 27);
            txtCariRoaster.TabIndex = 8;
            // 
            // cmbKategoriRoaster
            // 
            cmbKategoriRoaster.FormattingEnabled = true;
            cmbKategoriRoaster.Location = new Point(433, 45);
            cmbKategoriRoaster.Name = "cmbKategoriRoaster";
            cmbKategoriRoaster.Size = new Size(151, 28);
            cmbKategoriRoaster.TabIndex = 7;
            // 
            // cmbArahRoaster
            // 
            cmbArahRoaster.FormattingEnabled = true;
            cmbArahRoaster.Location = new Point(256, 45);
            cmbArahRoaster.Name = "cmbArahRoaster";
            cmbArahRoaster.Size = new Size(151, 28);
            cmbArahRoaster.TabIndex = 6;
            // 
            // tabRiwayatRoaster
            // 
            tabRiwayatRoaster.Controls.Add(tabPergerakanStokRoaster);
            tabRiwayatRoaster.Controls.Add(tabTransaksiRoaster);
            tabRiwayatRoaster.Location = new Point(63, 73);
            tabRiwayatRoaster.Name = "tabRiwayatRoaster";
            tabRiwayatRoaster.SelectedIndex = 0;
            tabRiwayatRoaster.Size = new Size(570, 332);
            tabRiwayatRoaster.TabIndex = 5;
            // 
            // tabPergerakanStokRoaster
            // 
            tabPergerakanStokRoaster.Controls.Add(dgvPergerakanRoaster);
            tabPergerakanStokRoaster.Location = new Point(4, 29);
            tabPergerakanStokRoaster.Name = "tabPergerakanStokRoaster";
            tabPergerakanStokRoaster.Padding = new Padding(3);
            tabPergerakanStokRoaster.Size = new Size(562, 299);
            tabPergerakanStokRoaster.TabIndex = 0;
            tabPergerakanStokRoaster.Text = "tabPage1";
            tabPergerakanStokRoaster.UseVisualStyleBackColor = true;
            // 
            // dgvPergerakanRoaster
            // 
            dgvPergerakanRoaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPergerakanRoaster.Location = new Point(26, 112);
            dgvPergerakanRoaster.Name = "dgvPergerakanRoaster";
            dgvPergerakanRoaster.RowHeadersWidth = 51;
            dgvPergerakanRoaster.Size = new Size(509, 167);
            dgvPergerakanRoaster.TabIndex = 0;
            // 
            // tabTransaksiRoaster
            // 
            tabTransaksiRoaster.Controls.Add(dgvTransaksiRoaster);
            tabTransaksiRoaster.Location = new Point(4, 29);
            tabTransaksiRoaster.Name = "tabTransaksiRoaster";
            tabTransaksiRoaster.Padding = new Padding(3);
            tabTransaksiRoaster.Size = new Size(562, 299);
            tabTransaksiRoaster.TabIndex = 1;
            tabTransaksiRoaster.Text = "tabPage2";
            tabTransaksiRoaster.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksiRoaster
            // 
            dgvTransaksiRoaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiRoaster.Location = new Point(17, 26);
            dgvTransaksiRoaster.Name = "dgvTransaksiRoaster";
            dgvTransaksiRoaster.RowHeadersWidth = 51;
            dgvTransaksiRoaster.Size = new Size(539, 177);
            dgvTransaksiRoaster.TabIndex = 0;
            // 
            // FormRiwayatRoaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCariRoaster);
            Controls.Add(cmbKategoriRoaster);
            Controls.Add(cmbArahRoaster);
            Controls.Add(tabRiwayatRoaster);
            Name = "FormRiwayatRoaster";
            Text = "FormRiwayatRoaster";
            tabRiwayatRoaster.ResumeLayout(false);
            tabPergerakanStokRoaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanRoaster).EndInit();
            tabTransaksiRoaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiRoaster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCariRoaster;
        private ComboBox cmbKategoriRoaster;
        private ComboBox cmbArahRoaster;
        private TabControl tabRiwayatRoaster;
        private TabPage tabPergerakanStokRoaster;
        private DataGridView dgvPergerakanRoaster;
        private TabPage tabTransaksiRoaster;
        private DataGridView dgvTransaksiRoaster;
    }
}