namespace SIKOPI_DOPY_ROASTERY.Views.Penjual
{
    partial class FormEtalasePenjual
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
            btnBeliPenjual = new Button();
            txtCariPenjual = new TextBox();
            dgvProdukPenjual = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdukPenjual).BeginInit();
            SuspendLayout();
            // 
            // btnBeliPenjual
            // 
            btnBeliPenjual.Location = new Point(152, 347);
            btnBeliPenjual.Name = "btnBeliPenjual";
            btnBeliPenjual.Size = new Size(94, 29);
            btnBeliPenjual.TabIndex = 5;
            btnBeliPenjual.Text = "button1";
            btnBeliPenjual.UseVisualStyleBackColor = true;
            // 
            // txtCariPenjual
            // 
            txtCariPenjual.Location = new Point(159, 75);
            txtCariPenjual.Name = "txtCariPenjual";
            txtCariPenjual.Size = new Size(125, 27);
            txtCariPenjual.TabIndex = 4;
            // 
            // dgvProdukPenjual
            // 
            dgvProdukPenjual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdukPenjual.Location = new Point(111, 130);
            dgvProdukPenjual.Name = "dgvProdukPenjual";
            dgvProdukPenjual.RowHeadersWidth = 51;
            dgvProdukPenjual.Size = new Size(579, 188);
            dgvProdukPenjual.TabIndex = 3;
            // 
            // FormEtalasePenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBeliPenjual);
            Controls.Add(txtCariPenjual);
            Controls.Add(dgvProdukPenjual);
            Name = "FormEtalasePenjual";
            Text = "FormEtalasePenjual";
            ((System.ComponentModel.ISupportInitialize)dgvProdukPenjual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBeliPenjual;
        private TextBox txtCariPenjual;
        private DataGridView dgvProdukPenjual;
    }
}