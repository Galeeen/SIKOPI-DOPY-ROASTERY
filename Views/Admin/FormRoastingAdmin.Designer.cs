namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    partial class FormRoastingAdmin
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
            dgvBatchAdmin = new DataGridView();
            txtCariAdmin = new TextBox();
            btnTambahBatchAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBatchAdmin).BeginInit();
            SuspendLayout();
            // 
            // dgvBatchAdmin
            // 
            dgvBatchAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchAdmin.Location = new Point(105, 121);
            dgvBatchAdmin.Margin = new Padding(4, 4, 4, 4);
            dgvBatchAdmin.Name = "dgvBatchAdmin";
            dgvBatchAdmin.RowHeadersWidth = 51;
            dgvBatchAdmin.Size = new Size(791, 358);
            dgvBatchAdmin.TabIndex = 0;
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(105, 50);
            txtCariAdmin.Margin = new Padding(4, 4, 4, 4);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(155, 31);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnTambahBatchAdmin
            // 
            btnTambahBatchAdmin.Location = new Point(105, 498);
            btnTambahBatchAdmin.Margin = new Padding(4, 4, 4, 4);
            btnTambahBatchAdmin.Name = "btnTambahBatchAdmin";
            btnTambahBatchAdmin.Size = new Size(118, 36);
            btnTambahBatchAdmin.TabIndex = 2;
            btnTambahBatchAdmin.Text = "button1";
            btnTambahBatchAdmin.UseVisualStyleBackColor = true;
            // 
            // FormRoastingAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnTambahBatchAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(dgvBatchAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormRoastingAdmin";
            Text = "FormRoastingAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvBatchAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBatchAdmin;
        private TextBox txtCariAdmin;
        private Button btnTambahBatchAdmin;
    }
}