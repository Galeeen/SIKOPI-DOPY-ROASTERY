namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    partial class FormBahanBakuAdmin
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
            tabBahanAdmin = new TabControl();
            tabGreenAdmin = new TabPage();
            tabRoastAdmin = new TabPage();
            dgvGreenAdmin = new DataGridView();
            dgvRoastAdmin = new DataGridView();
            txtCariAdmin = new TextBox();
            btnTambahGreenAdmin = new Button();
            btnEditGreenAdmin = new Button();
            btnHapusGreenAdmin = new Button();
            btnSetHargaAdmin = new Button();
            tabBahanAdmin.SuspendLayout();
            tabGreenAdmin.SuspendLayout();
            tabRoastAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoastAdmin).BeginInit();
            SuspendLayout();
            // 
            // tabBahanAdmin
            // 
            tabBahanAdmin.Controls.Add(tabGreenAdmin);
            tabBahanAdmin.Controls.Add(tabRoastAdmin);
            tabBahanAdmin.Location = new Point(71, 58);
            tabBahanAdmin.Name = "tabBahanAdmin";
            tabBahanAdmin.SelectedIndex = 0;
            tabBahanAdmin.Size = new Size(649, 293);
            tabBahanAdmin.TabIndex = 0;
            // 
            // tabGreenAdmin
            // 
            tabGreenAdmin.Controls.Add(dgvGreenAdmin);
            tabGreenAdmin.Location = new Point(4, 29);
            tabGreenAdmin.Name = "tabGreenAdmin";
            tabGreenAdmin.Padding = new Padding(3);
            tabGreenAdmin.Size = new Size(641, 260);
            tabGreenAdmin.TabIndex = 0;
            tabGreenAdmin.Text = "tabPage1";
            tabGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // tabRoastAdmin
            // 
            tabRoastAdmin.Controls.Add(dgvRoastAdmin);
            tabRoastAdmin.Location = new Point(4, 29);
            tabRoastAdmin.Name = "tabRoastAdmin";
            tabRoastAdmin.Padding = new Padding(3);
            tabRoastAdmin.Size = new Size(641, 260);
            tabRoastAdmin.TabIndex = 1;
            tabRoastAdmin.Text = "tabPage2";
            tabRoastAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvGreenAdmin
            // 
            dgvGreenAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenAdmin.Location = new Point(6, 36);
            dgvGreenAdmin.Name = "dgvGreenAdmin";
            dgvGreenAdmin.RowHeadersWidth = 51;
            dgvGreenAdmin.Size = new Size(629, 188);
            dgvGreenAdmin.TabIndex = 0;
            // 
            // dgvRoastAdmin
            // 
            dgvRoastAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastAdmin.Location = new Point(23, 45);
            dgvRoastAdmin.Name = "dgvRoastAdmin";
            dgvRoastAdmin.RowHeadersWidth = 51;
            dgvRoastAdmin.Size = new Size(612, 188);
            dgvRoastAdmin.TabIndex = 0;
            dgvRoastAdmin.CellContentClick += dgvRoastAdmin_CellContentClick;
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(84, 357);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(308, 27);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnTambahGreenAdmin
            // 
            btnTambahGreenAdmin.Location = new Point(84, 409);
            btnTambahGreenAdmin.Name = "btnTambahGreenAdmin";
            btnTambahGreenAdmin.Size = new Size(94, 29);
            btnTambahGreenAdmin.TabIndex = 2;
            btnTambahGreenAdmin.Text = "button1";
            btnTambahGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEditGreenAdmin
            // 
            btnEditGreenAdmin.Location = new Point(195, 409);
            btnEditGreenAdmin.Name = "btnEditGreenAdmin";
            btnEditGreenAdmin.Size = new Size(94, 29);
            btnEditGreenAdmin.TabIndex = 3;
            btnEditGreenAdmin.Text = "button2";
            btnEditGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnHapusGreenAdmin
            // 
            btnHapusGreenAdmin.Location = new Point(298, 409);
            btnHapusGreenAdmin.Name = "btnHapusGreenAdmin";
            btnHapusGreenAdmin.Size = new Size(94, 29);
            btnHapusGreenAdmin.TabIndex = 4;
            btnHapusGreenAdmin.Text = "button3";
            btnHapusGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSetHargaAdmin
            // 
            btnSetHargaAdmin.Location = new Point(416, 409);
            btnSetHargaAdmin.Name = "btnSetHargaAdmin";
            btnSetHargaAdmin.Size = new Size(94, 29);
            btnSetHargaAdmin.TabIndex = 5;
            btnSetHargaAdmin.Text = "button4";
            btnSetHargaAdmin.UseVisualStyleBackColor = true;
            // 
            // FormBahanBakuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetHargaAdmin);
            Controls.Add(btnHapusGreenAdmin);
            Controls.Add(btnEditGreenAdmin);
            Controls.Add(btnTambahGreenAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(tabBahanAdmin);
            Name = "FormBahanBakuAdmin";
            Text = "FormBahanBakuAdmin";
            tabBahanAdmin.ResumeLayout(false);
            tabGreenAdmin.ResumeLayout(false);
            tabRoastAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoastAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabBahanAdmin;
        private TabPage tabGreenAdmin;
        private DataGridView dgvGreenAdmin;
        private TabPage tabRoastAdmin;
        private DataGridView dgvRoastAdmin;
        private TextBox txtCariAdmin;
        private Button btnTambahGreenAdmin;
        private Button btnEditGreenAdmin;
        private Button btnHapusGreenAdmin;
        private Button btnSetHargaAdmin;
    }
}