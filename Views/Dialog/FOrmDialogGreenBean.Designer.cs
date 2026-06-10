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
            // 
            // txtNamaAdmin
            // 
            txtNamaAdmin.Location = new Point(190, 94);
            txtNamaAdmin.Margin = new Padding(4, 4, 4, 4);
            txtNamaAdmin.Name = "txtNamaAdmin";
            txtNamaAdmin.Size = new Size(155, 31);
            txtNamaAdmin.TabIndex = 0;
            txtNamaAdmin.TextChanged += txtNamaAdmin_TextChanged;
            // 
            // txtAsalAdmin
            // 
            txtAsalAdmin.Location = new Point(190, 166);
            txtAsalAdmin.Margin = new Padding(4, 4, 4, 4);
            txtAsalAdmin.Name = "txtAsalAdmin";
            txtAsalAdmin.Size = new Size(155, 31);
            txtAsalAdmin.TabIndex = 1;
            // 
            // cmbTipeAdmin
            // 
            cmbTipeAdmin.FormattingEnabled = true;
            cmbTipeAdmin.Location = new Point(190, 224);
            cmbTipeAdmin.Margin = new Padding(4, 4, 4, 4);
            cmbTipeAdmin.Name = "cmbTipeAdmin";
            cmbTipeAdmin.Size = new Size(188, 33);
            cmbTipeAdmin.TabIndex = 2;
            // 
            // numStokAdmin
            // 
            numStokAdmin.Location = new Point(190, 288);
            numStokAdmin.Margin = new Padding(4, 4, 4, 4);
            numStokAdmin.Name = "numStokAdmin";
            numStokAdmin.Size = new Size(188, 31);
            numStokAdmin.TabIndex = 3;
            // 
            // numHargaAdmin
            // 
            numHargaAdmin.Location = new Point(190, 344);
            numHargaAdmin.Margin = new Padding(4, 4, 4, 4);
            numHargaAdmin.Name = "numHargaAdmin";
            numHargaAdmin.Size = new Size(188, 31);
            numHargaAdmin.TabIndex = 4;
            // 
            // btnSimpanAdmin
            // 
            btnSimpanAdmin.Location = new Point(204, 412);
            btnSimpanAdmin.Margin = new Padding(4, 4, 4, 4);
            btnSimpanAdmin.Name = "btnSimpanAdmin";
            btnSimpanAdmin.Size = new Size(118, 36);
            btnSimpanAdmin.TabIndex = 5;
            btnSimpanAdmin.Text = "Simpan";
            btnSimpanAdmin.UseVisualStyleBackColor = true;
            // 
            // btnBatalAdmin
            // 
            btnBatalAdmin.Location = new Point(469, 412);
            btnBatalAdmin.Margin = new Padding(4, 4, 4, 4);
            btnBatalAdmin.Name = "btnBatalAdmin";
            btnBatalAdmin.Size = new Size(118, 36);
            btnBatalAdmin.TabIndex = 6;
            btnBatalAdmin.Text = "Batal";
            btnBatalAdmin.UseVisualStyleBackColor = true;
            // 
            // FormDialogGreenBean
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnBatalAdmin);
            Controls.Add(btnSimpanAdmin);
            Controls.Add(numHargaAdmin);
            Controls.Add(numStokAdmin);
            Controls.Add(cmbTipeAdmin);
            Controls.Add(txtAsalAdmin);
            Controls.Add(txtNamaAdmin);
            Margin = new Padding(4, 4, 4, 4);
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