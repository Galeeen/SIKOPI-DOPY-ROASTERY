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
            dgvGreenAdmin = new DataGridView();
            tabRoastAdmin = new TabPage();
            dgvRoastAdmin = new DataGridView();
            txtCariAdmin = new TextBox();
            btnTambahGreenAdmin = new Button();
            btnEditGreenAdmin = new Button();
            btnHapusGreenAdmin = new Button();
            btnSetHargaAdmin = new Button();
            tabBahanAdmin.SuspendLayout();
            tabGreenAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).BeginInit();
            tabRoastAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastAdmin).BeginInit();
            SuspendLayout();
            // 
            // tabBahanAdmin
            // 
            tabBahanAdmin.Controls.Add(tabGreenAdmin);
            tabBahanAdmin.Controls.Add(tabRoastAdmin);
            tabBahanAdmin.Location = new Point(89, 72);
            tabBahanAdmin.Margin = new Padding(4, 4, 4, 4);
            tabBahanAdmin.Name = "tabBahanAdmin";
            tabBahanAdmin.SelectedIndex = 0;
            tabBahanAdmin.Size = new Size(811, 366);
            tabBahanAdmin.TabIndex = 0;
            // 
            // tabGreenAdmin
            // 
            tabGreenAdmin.Controls.Add(dgvGreenAdmin);
            tabGreenAdmin.Location = new Point(4, 34);
            tabGreenAdmin.Margin = new Padding(4, 4, 4, 4);
            tabGreenAdmin.Name = "tabGreenAdmin";
            tabGreenAdmin.Padding = new Padding(4, 4, 4, 4);
            tabGreenAdmin.Size = new Size(803, 328);
            tabGreenAdmin.TabIndex = 0;
            tabGreenAdmin.Text = "tabPage1";
            tabGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvGreenAdmin
            // 
            dgvGreenAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenAdmin.Location = new Point(8, 45);
            dgvGreenAdmin.Margin = new Padding(4, 4, 4, 4);
            dgvGreenAdmin.Name = "dgvGreenAdmin";
            dgvGreenAdmin.RowHeadersWidth = 51;
            dgvGreenAdmin.Size = new Size(786, 235);
            dgvGreenAdmin.TabIndex = 0;
            // 
            // tabRoastAdmin
            // 
            tabRoastAdmin.Controls.Add(dgvRoastAdmin);
            tabRoastAdmin.Location = new Point(4, 34);
            tabRoastAdmin.Margin = new Padding(4, 4, 4, 4);
            tabRoastAdmin.Name = "tabRoastAdmin";
            tabRoastAdmin.Padding = new Padding(4, 4, 4, 4);
            tabRoastAdmin.Size = new Size(803, 328);
            tabRoastAdmin.TabIndex = 1;
            tabRoastAdmin.Text = "tabPage2";
            tabRoastAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvRoastAdmin
            // 
            dgvRoastAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastAdmin.Location = new Point(29, 56);
            dgvRoastAdmin.Margin = new Padding(4, 4, 4, 4);
            dgvRoastAdmin.Name = "dgvRoastAdmin";
            dgvRoastAdmin.RowHeadersWidth = 51;
            dgvRoastAdmin.Size = new Size(765, 235);
            dgvRoastAdmin.TabIndex = 0;
            dgvRoastAdmin.CellContentClick += dgvRoastAdmin_CellContentClick;
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(105, 446);
            txtCariAdmin.Margin = new Padding(4, 4, 4, 4);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(384, 31);
            txtCariAdmin.TabIndex = 1;
            // 
            // btnTambahGreenAdmin
            // 
            btnTambahGreenAdmin.Location = new Point(105, 511);
            btnTambahGreenAdmin.Margin = new Padding(4, 4, 4, 4);
            btnTambahGreenAdmin.Name = "btnTambahGreenAdmin";
            btnTambahGreenAdmin.Size = new Size(118, 36);
            btnTambahGreenAdmin.TabIndex = 2;
            btnTambahGreenAdmin.Text = "button1";
            btnTambahGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEditGreenAdmin
            // 
            btnEditGreenAdmin.Location = new Point(244, 511);
            btnEditGreenAdmin.Margin = new Padding(4, 4, 4, 4);
            btnEditGreenAdmin.Name = "btnEditGreenAdmin";
            btnEditGreenAdmin.Size = new Size(118, 36);
            btnEditGreenAdmin.TabIndex = 3;
            btnEditGreenAdmin.Text = "button2";
            btnEditGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnHapusGreenAdmin
            // 
            btnHapusGreenAdmin.Location = new Point(372, 511);
            btnHapusGreenAdmin.Margin = new Padding(4, 4, 4, 4);
            btnHapusGreenAdmin.Name = "btnHapusGreenAdmin";
            btnHapusGreenAdmin.Size = new Size(118, 36);
            btnHapusGreenAdmin.TabIndex = 4;
            btnHapusGreenAdmin.Text = "button3";
            btnHapusGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSetHargaAdmin
            // 
            btnSetHargaAdmin.Location = new Point(520, 511);
            btnSetHargaAdmin.Margin = new Padding(4, 4, 4, 4);
            btnSetHargaAdmin.Name = "btnSetHargaAdmin";
            btnSetHargaAdmin.Size = new Size(118, 36);
            btnSetHargaAdmin.TabIndex = 5;
            btnSetHargaAdmin.Text = "button4";
            btnSetHargaAdmin.UseVisualStyleBackColor = true;
            btnSetHargaAdmin.Click += btnSetHargaAdmin_Click;
            // 
            // FormBahanBakuAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnSetHargaAdmin);
            Controls.Add(btnHapusGreenAdmin);
            Controls.Add(btnEditGreenAdmin);
            Controls.Add(btnTambahGreenAdmin);
            Controls.Add(txtCariAdmin);
            Controls.Add(tabBahanAdmin);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBahanBakuAdmin";
            Text = "FormBahanBakuAdmin";
            tabBahanAdmin.ResumeLayout(false);
            tabGreenAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).EndInit();
            tabRoastAdmin.ResumeLayout(false);
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