namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    partial class FormEtalaseAdmin
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
            dgvProdukAdmin = new DataGridView();
            txtCariAdmin = new TextBox();
            btnBeliAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdukAdmin).BeginInit();
            SuspendLayout();
            // 
            // dgvProdukAdmin
            // 
            dgvProdukAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdukAdmin.Location = new Point(76, 162);
            dgvProdukAdmin.Name = "dgvProdukAdmin";
            dgvProdukAdmin.RowHeadersWidth = 51;
            dgvProdukAdmin.Size = new Size(579, 188);
            dgvProdukAdmin.TabIndex = 0;
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(124, 107);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(125, 27);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnBeliAdmin
            // 
            btnBeliAdmin.Location = new Point(117, 379);
            btnBeliAdmin.Name = "btnBeliAdmin";
            btnBeliAdmin.Size = new Size(94, 29);
            btnBeliAdmin.TabIndex = 2;
            btnBeliAdmin.Text = "button1";
            btnBeliAdmin.UseVisualStyleBackColor = true;
            // 
            // FormEtalaseAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBeliAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(dgvProdukAdmin);
            Name = "FormEtalaseAdmin";
            Text = "FormEtalaseAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvProdukAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdukAdmin;
        private TextBox txtCariAdmin;
        private Button btnBeliAdmin;
    }
}