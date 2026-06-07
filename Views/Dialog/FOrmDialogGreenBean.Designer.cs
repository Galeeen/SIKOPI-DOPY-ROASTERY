namespace SIKOPI_DOPY_ROASTERY.Views.Dialog
{
    partial class FormDialogGreenBean
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNamaAdmin = new TextBox();
            txtAsalAdmin = new TextBox();
            cmbTipeAdmin = new ComboBox();
            numStokAdmin = new NumericUpDown();
            numHargaAdmin = new NumericUpDown();
            btnSimpanAdmin = new Button();
            btnBatalAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)numStokAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHargaAdmin).BeginInit();
            SuspendLayout();

            txtNamaAdmin.Location = new Point(152, 75);
            txtNamaAdmin.Name = "txtNamaAdmin";
            txtNamaAdmin.Size = new Size(125, 27);
            txtNamaAdmin.TabIndex = 0;

            txtAsalAdmin.Location = new Point(152, 133);
            txtAsalAdmin.Name = "txtAsalAdmin";
            txtAsalAdmin.Size = new Size(125, 27);
            txtAsalAdmin.TabIndex = 1;

            cmbTipeAdmin.FormattingEnabled = true;
            cmbTipeAdmin.Location = new Point(152, 179);
            cmbTipeAdmin.Name = "cmbTipeAdmin";
            cmbTipeAdmin.Size = new Size(151, 28);
            cmbTipeAdmin.TabIndex = 2;

            numStokAdmin.Location = new Point(152, 230);
            numStokAdmin.Name = "numStokAdmin";
            numStokAdmin.Size = new Size(150, 27);
            numStokAdmin.TabIndex = 3;

            numHargaAdmin.Location = new Point(152, 275);
            numHargaAdmin.Name = "numHargaAdmin";
            numHargaAdmin.Size = new Size(150, 27);
            numHargaAdmin.TabIndex = 4;

            btnSimpanAdmin.Location = new Point(163, 330);
            btnSimpanAdmin.Name = "btnSimpanAdmin";
            btnSimpanAdmin.Size = new Size(94, 29);
            btnSimpanAdmin.TabIndex = 5;
            btnSimpanAdmin.Text = "Simpan";
            btnSimpanAdmin.UseVisualStyleBackColor = true;

            btnBatalAdmin.Location = new Point(375, 330);
            btnBatalAdmin.Name = "btnBatalAdmin";
            btnBatalAdmin.Size = new Size(94, 29);
            btnBatalAdmin.TabIndex = 6;
            btnBatalAdmin.Text = "Batal";
            btnBatalAdmin.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatalAdmin);
            Controls.Add(btnSimpanAdmin);
            Controls.Add(numHargaAdmin);
            Controls.Add(numStokAdmin);
            Controls.Add(cmbTipeAdmin);
            Controls.Add(txtAsalAdmin);
            Controls.Add(txtNamaAdmin);
            Name = "FormDialogGreenBean";
            Text = "FormDialogGreenBean";
            ((System.ComponentModel.ISupportInitialize)numStokAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHargaAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaAdmin;
        private TextBox txtAsalAdmin;
        private ComboBox cmbTipeAdmin;
        private NumericUpDown numStokAdmin;
        private NumericUpDown numHargaAdmin;
        private Button btnSimpanAdmin;
        private Button btnBatalAdmin;
    }
}