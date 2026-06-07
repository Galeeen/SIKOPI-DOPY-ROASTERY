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
            txtCariRoaster.Location = new Point(766, 56);
            txtCariRoaster.Margin = new Padding(4, 4, 4, 4);
            txtCariRoaster.Name = "txtCariRoaster";
            txtCariRoaster.Size = new Size(155, 31);
            txtCariRoaster.TabIndex = 8;
            // 
            // cmbKategoriRoaster
            // 
            cmbKategoriRoaster.FormattingEnabled = true;
            cmbKategoriRoaster.Location = new Point(541, 56);
            cmbKategoriRoaster.Margin = new Padding(4, 4, 4, 4);
            cmbKategoriRoaster.Name = "cmbKategoriRoaster";
            cmbKategoriRoaster.Size = new Size(188, 33);
            cmbKategoriRoaster.TabIndex = 7;
            // 
            // cmbArahRoaster
            // 
            cmbArahRoaster.FormattingEnabled = true;
            cmbArahRoaster.Location = new Point(320, 56);
            cmbArahRoaster.Margin = new Padding(4, 4, 4, 4);
            cmbArahRoaster.Name = "cmbArahRoaster";
            cmbArahRoaster.Size = new Size(188, 33);
            cmbArahRoaster.TabIndex = 6;
            // 
            // tabRiwayatRoaster
            // 
            tabRiwayatRoaster.Controls.Add(tabPergerakanStokRoaster);
            tabRiwayatRoaster.Controls.Add(tabTransaksiRoaster);
            tabRiwayatRoaster.Location = new Point(79, 91);
            tabRiwayatRoaster.Margin = new Padding(4, 4, 4, 4);
            tabRiwayatRoaster.Name = "tabRiwayatRoaster";
            tabRiwayatRoaster.SelectedIndex = 0;
            tabRiwayatRoaster.Size = new Size(712, 415);
            tabRiwayatRoaster.TabIndex = 5;
            // 
            // tabPergerakanStokRoaster
            // 
            tabPergerakanStokRoaster.Controls.Add(dgvPergerakanRoaster);
            tabPergerakanStokRoaster.Location = new Point(4, 34);
            tabPergerakanStokRoaster.Margin = new Padding(4, 4, 4, 4);
            tabPergerakanStokRoaster.Name = "tabPergerakanStokRoaster";
            tabPergerakanStokRoaster.Padding = new Padding(4, 4, 4, 4);
            tabPergerakanStokRoaster.Size = new Size(704, 377);
            tabPergerakanStokRoaster.TabIndex = 0;
            tabPergerakanStokRoaster.Text = "tabPage1";
            tabPergerakanStokRoaster.UseVisualStyleBackColor = true;
            // 
            // dgvPergerakanRoaster
            // 
            dgvPergerakanRoaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPergerakanRoaster.Location = new Point(32, 140);
            dgvPergerakanRoaster.Margin = new Padding(4, 4, 4, 4);
            dgvPergerakanRoaster.Name = "dgvPergerakanRoaster";
            dgvPergerakanRoaster.RowHeadersWidth = 51;
            dgvPergerakanRoaster.Size = new Size(636, 209);
            dgvPergerakanRoaster.TabIndex = 0;
            // 
            // tabTransaksiRoaster
            // 
            tabTransaksiRoaster.Controls.Add(dgvTransaksiRoaster);
            tabTransaksiRoaster.Location = new Point(4, 34);
            tabTransaksiRoaster.Margin = new Padding(4, 4, 4, 4);
            tabTransaksiRoaster.Name = "tabTransaksiRoaster";
            tabTransaksiRoaster.Padding = new Padding(4, 4, 4, 4);
            tabTransaksiRoaster.Size = new Size(704, 377);
            tabTransaksiRoaster.TabIndex = 1;
            tabTransaksiRoaster.Text = "tabPage2";
            tabTransaksiRoaster.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksiRoaster
            // 
            dgvTransaksiRoaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiRoaster.Location = new Point(21, 32);
            dgvTransaksiRoaster.Margin = new Padding(4, 4, 4, 4);
            dgvTransaksiRoaster.Name = "dgvTransaksiRoaster";
            dgvTransaksiRoaster.RowHeadersWidth = 51;
            dgvTransaksiRoaster.Size = new Size(674, 221);
            dgvTransaksiRoaster.TabIndex = 0;
            // 
            // FormRiwayatRoaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(txtCariRoaster);
            Controls.Add(cmbKategoriRoaster);
            Controls.Add(cmbArahRoaster);
            Controls.Add(tabRiwayatRoaster);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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