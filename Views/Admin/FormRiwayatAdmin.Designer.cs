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
            tabRiwayatAdmin = new TabControl();
            tabPergerakanStokAdmin = new TabPage();
            tabTransaksiAdmin = new TabPage();
            dgvPergerakanAdmin = new DataGridView();
            dgvTransaksiAdmin = new DataGridView();
            comboBox1 = new ComboBox();
            tabRiwayatAdmin.SuspendLayout();
            tabPergerakanStokAdmin.SuspendLayout();
            tabTransaksiAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiAdmin).BeginInit();
            SuspendLayout();
            // 
            // tabRiwayatAdmin
            // 
            tabRiwayatAdmin.Controls.Add(tabPergerakanStokAdmin);
            tabRiwayatAdmin.Controls.Add(tabTransaksiAdmin);
            tabRiwayatAdmin.Location = new Point(55, 28);
            tabRiwayatAdmin.Name = "tabRiwayatAdmin";
            tabRiwayatAdmin.SelectedIndex = 0;
            tabRiwayatAdmin.Size = new Size(570, 362);
            tabRiwayatAdmin.TabIndex = 0;
            tabRiwayatAdmin.SelectedIndexChanged += tabRiwayatAdmin_SelectedIndexChanged;
            // 
            // tabPergerakanStokAdmin
            // 
            tabPergerakanStokAdmin.Controls.Add(comboBox1);
            tabPergerakanStokAdmin.Controls.Add(dgvPergerakanAdmin);
            tabPergerakanStokAdmin.Location = new Point(4, 29);
            tabPergerakanStokAdmin.Name = "tabPergerakanStokAdmin";
            tabPergerakanStokAdmin.Padding = new Padding(3);
            tabPergerakanStokAdmin.Size = new Size(562, 329);
            tabPergerakanStokAdmin.TabIndex = 0;
            tabPergerakanStokAdmin.Text = "tabPage1";
            tabPergerakanStokAdmin.UseVisualStyleBackColor = true;
            tabPergerakanStokAdmin.Click += tabPergerakanStokAdmin_Click;
            // 
            // tabTransaksiAdmin
            // 
            tabTransaksiAdmin.Controls.Add(dgvTransaksiAdmin);
            tabTransaksiAdmin.Location = new Point(4, 29);
            tabTransaksiAdmin.Name = "tabTransaksiAdmin";
            tabTransaksiAdmin.Padding = new Padding(3);
            tabTransaksiAdmin.Size = new Size(562, 220);
            tabTransaksiAdmin.TabIndex = 1;
            tabTransaksiAdmin.Text = "tabPage2";
            tabTransaksiAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvPergerakanAdmin
            // 
            dgvPergerakanAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPergerakanAdmin.Location = new Point(26, 26);
            dgvPergerakanAdmin.Name = "dgvPergerakanAdmin";
            dgvPergerakanAdmin.RowHeadersWidth = 51;
            dgvPergerakanAdmin.Size = new Size(509, 167);
            dgvPergerakanAdmin.TabIndex = 0;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // FormRiwayatAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabRiwayatAdmin);
            Name = "FormRiwayatAdmin";
            Text = "FormRiwayatAdmin";
            tabRiwayatAdmin.ResumeLayout(false);
            tabPergerakanStokAdmin.ResumeLayout(false);
            tabTransaksiAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPergerakanAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabRiwayatAdmin;
        private TabPage tabPergerakanStokAdmin;
        private TabPage tabTransaksiAdmin;
        private ComboBox comboBox1;
        private DataGridView dgvPergerakanAdmin;
        private DataGridView dgvTransaksiAdmin;
    }
}