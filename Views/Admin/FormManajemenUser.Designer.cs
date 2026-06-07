namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    partial class FormManajemenUser
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
            dgvUserAdmin = new DataGridView();
            txtCariAdmin = new TextBox();
            btnTambahUserAdmin = new Button();
            btnEditUserAdmin = new Button();
            btnHapusUserAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserAdmin).BeginInit();
            SuspendLayout();
            // 
            // dgvUserAdmin
            // 
            dgvUserAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserAdmin.Location = new Point(53, 100);
            dgvUserAdmin.Name = "dgvUserAdmin";
            dgvUserAdmin.RowHeadersWidth = 51;
            dgvUserAdmin.Size = new Size(684, 175);
            dgvUserAdmin.TabIndex = 0;
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(207, 27);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(125, 27);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnTambahUserAdmin
            // 
            btnTambahUserAdmin.Location = new Point(102, 297);
            btnTambahUserAdmin.Name = "btnTambahUserAdmin";
            btnTambahUserAdmin.Size = new Size(94, 29);
            btnTambahUserAdmin.TabIndex = 2;
            btnTambahUserAdmin.Text = "button1";
            btnTambahUserAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEditUserAdmin
            // 
            btnEditUserAdmin.Location = new Point(216, 297);
            btnEditUserAdmin.Name = "btnEditUserAdmin";
            btnEditUserAdmin.Size = new Size(94, 29);
            btnEditUserAdmin.TabIndex = 3;
            btnEditUserAdmin.Text = "button2";
            btnEditUserAdmin.UseVisualStyleBackColor = true;
            // 
            // btnHapusUserAdmin
            // 
            btnHapusUserAdmin.Location = new Point(326, 297);
            btnHapusUserAdmin.Name = "btnHapusUserAdmin";
            btnHapusUserAdmin.Size = new Size(94, 29);
            btnHapusUserAdmin.TabIndex = 4;
            btnHapusUserAdmin.Text = "button3";
            btnHapusUserAdmin.UseVisualStyleBackColor = true;
            // 
            // FormManajemenUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHapusUserAdmin);
            Controls.Add(btnEditUserAdmin);
            Controls.Add(btnTambahUserAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(dgvUserAdmin);
            Name = "FormManajemenUser";
            Text = "FormManajemenUser";
            ((System.ComponentModel.ISupportInitialize)dgvUserAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUserAdmin;
        private TextBox txtCariAdmin;
        private Button btnTambahUserAdmin;
        private Button btnEditUserAdmin;
        private Button btnHapusUserAdmin;
    }
}