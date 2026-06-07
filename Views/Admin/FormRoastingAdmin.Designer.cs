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
            dgvBatchAdmin.Location = new Point(84, 97);
            dgvBatchAdmin.Name = "dgvBatchAdmin";
            dgvBatchAdmin.RowHeadersWidth = 51;
            dgvBatchAdmin.Size = new Size(633, 286);
            dgvBatchAdmin.TabIndex = 0;
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(84, 40);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(125, 27);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnTambahBatchAdmin
            // 
            btnTambahBatchAdmin.Location = new Point(84, 398);
            btnTambahBatchAdmin.Name = "btnTambahBatchAdmin";
            btnTambahBatchAdmin.Size = new Size(94, 29);
            btnTambahBatchAdmin.TabIndex = 2;
            btnTambahBatchAdmin.Text = "button1";
            btnTambahBatchAdmin.UseVisualStyleBackColor = true;
            // 
            // FormRoastingAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahBatchAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(dgvBatchAdmin);
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