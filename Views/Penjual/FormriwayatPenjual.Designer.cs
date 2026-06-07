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
            txtCariPenjual.Location = new Point(766, 56);
            txtCariPenjual.Margin = new Padding(4, 4, 4, 4);
            txtCariPenjual.Name = "txtCariPenjual";
            txtCariPenjual.Size = new Size(155, 31);
            txtCariPenjual.TabIndex = 12;
            // 
            // cmbKategoriPenjual
            // 
            cmbKategoriPenjual.FormattingEnabled = true;
            cmbKategoriPenjual.Location = new Point(541, 56);
            cmbKategoriPenjual.Margin = new Padding(4, 4, 4, 4);
            cmbKategoriPenjual.Name = "cmbKategoriPenjual";
            cmbKategoriPenjual.Size = new Size(188, 33);
            cmbKategoriPenjual.TabIndex = 11;
            // 
            // cmbArahPenjual
            // 
            cmbArahPenjual.FormattingEnabled = true;
            cmbArahPenjual.Location = new Point(320, 56);
            cmbArahPenjual.Margin = new Padding(4, 4, 4, 4);
            cmbArahPenjual.Name = "cmbArahPenjual";
            cmbArahPenjual.Size = new Size(188, 33);
            cmbArahPenjual.TabIndex = 10;
            // 
            // tabRiwayatPenjual
            // 
            tabRiwayatPenjual.Controls.Add(tabPergerakanStokPenjual);
            tabRiwayatPenjual.Controls.Add(tabTransaksiPenjual);
            tabRiwayatPenjual.Location = new Point(79, 91);
            tabRiwayatPenjual.Margin = new Padding(4, 4, 4, 4);
            tabRiwayatPenjual.Name = "tabRiwayatPenjual";
            tabRiwayatPenjual.SelectedIndex = 0;
            tabRiwayatPenjual.Size = new Size(712, 415);
            tabRiwayatPenjual.TabIndex = 9;
            // 
            // tabPergerakanStokPenjual
            // 
            tabPergerakanStokPenjual.Controls.Add(dgvPergerakanPenjual);
            tabPergerakanStokPenjual.Location = new Point(4, 34);
            tabPergerakanStokPenjual.Margin = new Padding(4, 4, 4, 4);
            tabPergerakanStokPenjual.Name = "tabPergerakanStokPenjual";
            tabPergerakanStokPenjual.Padding = new Padding(4, 4, 4, 4);
            tabPergerakanStokPenjual.Size = new Size(704, 377);
            tabPergerakanStokPenjual.TabIndex = 0;
            tabPergerakanStokPenjual.Text = "tabPage1";
            tabPergerakanStokPenjual.UseVisualStyleBackColor = true;
            // 
            // dgvPergerakanPenjual
            // 
            dgvPergerakanPenjual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPergerakanPenjual.Location = new Point(32, 140);
            dgvPergerakanPenjual.Margin = new Padding(4, 4, 4, 4);
            dgvPergerakanPenjual.Name = "dgvPergerakanPenjual";
            dgvPergerakanPenjual.RowHeadersWidth = 51;
            dgvPergerakanPenjual.Size = new Size(636, 209);
            dgvPergerakanPenjual.TabIndex = 0;
            // 
            // tabTransaksiPenjual
            // 
            tabTransaksiPenjual.Controls.Add(dgvTransaksiPenjual);
            tabTransaksiPenjual.Location = new Point(4, 34);
            tabTransaksiPenjual.Margin = new Padding(4, 4, 4, 4);
            tabTransaksiPenjual.Name = "tabTransaksiPenjual";
            tabTransaksiPenjual.Padding = new Padding(4, 4, 4, 4);
            tabTransaksiPenjual.Size = new Size(704, 377);
            tabTransaksiPenjual.TabIndex = 1;
            tabTransaksiPenjual.Text = "tabPage2";
            tabTransaksiPenjual.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksiPenjual
            // 
            dgvTransaksiPenjual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiPenjual.Location = new Point(21, 32);
            dgvTransaksiPenjual.Margin = new Padding(4, 4, 4, 4);
            dgvTransaksiPenjual.Name = "dgvTransaksiPenjual";
            dgvTransaksiPenjual.RowHeadersWidth = 51;
            dgvTransaksiPenjual.Size = new Size(674, 221);
            dgvTransaksiPenjual.TabIndex = 0;
            // 
            // FormriwayatPenjual
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(txtCariPenjual);
            Controls.Add(cmbKategoriPenjual);
            Controls.Add(cmbArahPenjual);
            Controls.Add(tabRiwayatPenjual);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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