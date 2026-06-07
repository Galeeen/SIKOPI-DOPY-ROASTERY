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
            dgvProdukAdmin.Location = new Point(95, 202);
            dgvProdukAdmin.Margin = new Padding(4, 4, 4, 4);
            dgvProdukAdmin.Name = "dgvProdukAdmin";
            dgvProdukAdmin.RowHeadersWidth = 51;
            dgvProdukAdmin.Size = new Size(724, 235);
            dgvProdukAdmin.TabIndex = 0;
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(155, 134);
            txtCariAdmin.Margin = new Padding(4, 4, 4, 4);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(155, 31);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnBeliAdmin
            // 
            btnBeliAdmin.Location = new Point(146, 474);
            btnBeliAdmin.Margin = new Padding(4, 4, 4, 4);
            btnBeliAdmin.Name = "btnBeliAdmin";
            btnBeliAdmin.Size = new Size(118, 36);
            btnBeliAdmin.TabIndex = 2;
            btnBeliAdmin.Text = "button1";
            btnBeliAdmin.UseVisualStyleBackColor = true;
            // 
            // FormEtalaseAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnBeliAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(dgvProdukAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormEtalaseAdmin";
            Text = "FormEtalaseAdmin";
            Load += FormEtalaseAdmin_Load;
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