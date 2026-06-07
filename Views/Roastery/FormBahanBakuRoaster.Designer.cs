namespace SIKOPI_DOPY_ROASTERY.Views.Roastery
{
    partial class FormBahanBakuRoaster
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
            txtCariAdmin = new TextBox();
            tabBahanRoaster = new TabControl();
            tabGreenRoaster = new TabPage();
            dgvGreenAdmin = new DataGridView();
            tabRoastRoaster = new TabPage();
            dgvRoastRoaster = new DataGridView();
            tabBahanRoaster.SuspendLayout();
            tabGreenRoaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).BeginInit();
            tabRoastRoaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastRoaster).BeginInit();
            SuspendLayout();
            // 
            // txtCariAdmin
            // 
            txtCariAdmin.Location = new Point(55, 351);
            txtCariAdmin.Name = "txtCariAdmin";
            txtCariAdmin.Size = new Size(308, 27);
            txtCariAdmin.TabIndex = 3;
            // 
            // tabBahanRoaster
            // 
            tabBahanRoaster.Controls.Add(tabGreenRoaster);
            tabBahanRoaster.Controls.Add(tabRoastRoaster);
            tabBahanRoaster.Location = new Point(55, 36);
            tabBahanRoaster.Name = "tabBahanRoaster";
            tabBahanRoaster.SelectedIndex = 0;
            tabBahanRoaster.Size = new Size(649, 293);
            tabBahanRoaster.TabIndex = 2;
            // 
            // tabGreenRoaster
            // 
            tabGreenRoaster.Controls.Add(dgvGreenAdmin);
            tabGreenRoaster.Location = new Point(4, 29);
            tabGreenRoaster.Name = "tabGreenRoaster";
            tabGreenRoaster.Padding = new Padding(3);
            tabGreenRoaster.Size = new Size(641, 260);
            tabGreenRoaster.TabIndex = 0;
            tabGreenRoaster.Text = "tabPage1";
            tabGreenRoaster.UseVisualStyleBackColor = true;
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
            // tabRoastRoaster
            // 
            tabRoastRoaster.Controls.Add(dgvRoastRoaster);
            tabRoastRoaster.Location = new Point(4, 29);
            tabRoastRoaster.Name = "tabRoastRoaster";
            tabRoastRoaster.Padding = new Padding(3);
            tabRoastRoaster.Size = new Size(641, 260);
            tabRoastRoaster.TabIndex = 1;
            tabRoastRoaster.Text = "tabPage2";
            tabRoastRoaster.UseVisualStyleBackColor = true;
            // 
            // dgvRoastRoaster
            // 
            dgvRoastRoaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastRoaster.Location = new Point(23, 45);
            dgvRoastRoaster.Name = "dgvRoastRoaster";
            dgvRoastRoaster.RowHeadersWidth = 51;
            dgvRoastRoaster.Size = new Size(612, 188);
            dgvRoastRoaster.TabIndex = 0;
            // 
            // FormBahanBakuRoaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCariAdmin);
            Controls.Add(tabBahanRoaster);
            Name = "FormBahanBakuRoaster";
            Text = "FormBahanBakuRoaster";
            tabBahanRoaster.ResumeLayout(false);
            tabGreenRoaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).EndInit();
            tabRoastRoaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoastRoaster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCariAdmin;
        private TabControl tabBahanRoaster;
        private TabPage tabGreenRoaster;
        private DataGridView dgvGreenAdmin;
        private TabPage tabRoastRoaster;
        private DataGridView dgvRoastRoaster;
    }
}