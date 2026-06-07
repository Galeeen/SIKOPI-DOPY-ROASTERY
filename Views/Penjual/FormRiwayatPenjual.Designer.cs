namespace SIKOPI_DOPY_ROASTERY.Views.Penjual
{
    partial class FormriwayatPenjual
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
            txtCariPenjual = new TextBox();
            cmbKategoriPenjual = new ComboBox();
            cmbArahPenjual = new ComboBox();
            tabRiwayatPenjual = new TabControl();
            tabPergerakanStokPenjual = new TabPage();
            dgvPergerakanPenjual = new DataGridView();
            tabTransaksiPenjual = new TabPage();
            dgvTransaksiPenjual = new DataGridView();
            tabRiwayatPenjual.SuspendLayout();
            tabPergerakanStokPenjual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanPenjual).BeginInit();
            tabTransaksiPenjual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiPenjual).BeginInit();
            SuspendLayout();
            // 
            // txtCariPenjual
            // 
            txtCariPenjual.Location = new Point(613, 45);
            txtCariPenjual.Name = "txtCariPenjual";
            txtCariPenjual.Size = new Size(125, 27);
            txtCariPenjual.TabIndex = 12;
            // 
            // cmbKategoriPenjual
            // 
            cmbKategoriPenjual.FormattingEnabled = true;
            cmbKategoriPenjual.Location = new Point(433, 45);
            cmbKategoriPenjual.Name = "cmbKategoriPenjual";
            cmbKategoriPenjual.Size = new Size(151, 28);
            cmbKategoriPenjual.TabIndex = 11;
            // 
            // cmbArahPenjual
            // 
            cmbArahPenjual.FormattingEnabled = true;
            cmbArahPenjual.Location = new Point(256, 45);
            cmbArahPenjual.Name = "cmbArahPenjual";
            cmbArahPenjual.Size = new Size(151, 28);
            cmbArahPenjual.TabIndex = 10;
            // 
            // tabRiwayatPenjual
            // 
            tabRiwayatPenjual.Controls.Add(tabPergerakanStokPenjual);
            tabRiwayatPenjual.Controls.Add(tabTransaksiPenjual);
            tabRiwayatPenjual.Location = new Point(63, 73);
            tabRiwayatPenjual.Name = "tabRiwayatPenjual";
            tabRiwayatPenjual.SelectedIndex = 0;
            tabRiwayatPenjual.Size = new Size(570, 332);
            tabRiwayatPenjual.TabIndex = 9;
            // 
            // tabPergerakanStokPenjual
            // 
            tabPergerakanStokPenjual.Controls.Add(dgvPergerakanPenjual);
            tabPergerakanStokPenjual.Location = new Point(4, 29);
            tabPergerakanStokPenjual.Name = "tabPergerakanStokPenjual";
            tabPergerakanStokPenjual.Padding = new Padding(3);
            tabPergerakanStokPenjual.Size = new Size(562, 299);
            tabPergerakanStokPenjual.TabIndex = 0;
            tabPergerakanStokPenjual.Text = "tabPage1";
            tabPergerakanStokPenjual.UseVisualStyleBackColor = true;
            // 
            // dgvPergerakanPenjual
            // 
            dgvPergerakanPenjual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPergerakanPenjual.Location = new Point(26, 112);
            dgvPergerakanPenjual.Name = "dgvPergerakanPenjual";
            dgvPergerakanPenjual.RowHeadersWidth = 51;
            dgvPergerakanPenjual.Size = new Size(509, 167);
            dgvPergerakanPenjual.TabIndex = 0;
            // 
            // tabTransaksiPenjual
            // 
            tabTransaksiPenjual.Controls.Add(dgvTransaksiPenjual);
            tabTransaksiPenjual.Location = new Point(4, 29);
            tabTransaksiPenjual.Name = "tabTransaksiPenjual";
            tabTransaksiPenjual.Padding = new Padding(3);
            tabTransaksiPenjual.Size = new Size(562, 299);
            tabTransaksiPenjual.TabIndex = 1;
            tabTransaksiPenjual.Text = "tabPage2";
            tabTransaksiPenjual.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksiPenjual
            // 
            dgvTransaksiPenjual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiPenjual.Location = new Point(17, 26);
            dgvTransaksiPenjual.Name = "dgvTransaksiPenjual";
            dgvTransaksiPenjual.RowHeadersWidth = 51;
            dgvTransaksiPenjual.Size = new Size(539, 177);
            dgvTransaksiPenjual.TabIndex = 0;
            // 
            // FormriwayatPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCariPenjual);
            Controls.Add(cmbKategoriPenjual);
            Controls.Add(cmbArahPenjual);
            Controls.Add(tabRiwayatPenjual);
            Name = "FormriwayatPenjual";
            Text = "FormriwayatPenjual";
            tabRiwayatPenjual.ResumeLayout(false);
            tabPergerakanStokPenjual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanPenjual).EndInit();
            tabTransaksiPenjual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiPenjual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCariPenjual;
        private ComboBox cmbKategoriPenjual;
        private ComboBox cmbArahPenjual;
        private TabControl tabRiwayatPenjual;
        private TabPage tabPergerakanStokPenjual;
        private DataGridView dgvPergerakanPenjual;
        private TabPage tabTransaksiPenjual;
        private DataGridView dgvTransaksiPenjual;
    }
}