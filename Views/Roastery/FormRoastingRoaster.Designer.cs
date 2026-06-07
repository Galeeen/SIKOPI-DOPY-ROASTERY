namespace SIKOPI_DOPY_ROASTERY.Views.Roastery
{
    partial class FormRoastingRoaster
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
            btnTambahtxtCariRoaster = new Button();
            txtCariRoaster = new TextBox();
            dgvBatchtxtCariRoaster = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBatchtxtCariRoaster).BeginInit();
            SuspendLayout();
            // 
            // btnTambahtxtCariRoaster
            // 
            btnTambahtxtCariRoaster.Location = new Point(105, 488);
            btnTambahtxtCariRoaster.Margin = new Padding(4, 4, 4, 4);
            btnTambahtxtCariRoaster.Name = "btnTambahtxtCariRoaster";
            btnTambahtxtCariRoaster.Size = new Size(118, 36);
            btnTambahtxtCariRoaster.TabIndex = 5;
            btnTambahtxtCariRoaster.Text = "button1";
            btnTambahtxtCariRoaster.UseVisualStyleBackColor = true;
            // 
            // txtCariRoaster
            // 
            txtCariRoaster.Location = new Point(105, 40);
            txtCariRoaster.Margin = new Padding(4, 4, 4, 4);
            txtCariRoaster.Name = "txtCariRoaster";
            txtCariRoaster.Size = new Size(155, 31);
            txtCariRoaster.TabIndex = 4;
            // 
            // dgvBatchtxtCariRoaster
            // 
            dgvBatchtxtCariRoaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchtxtCariRoaster.Location = new Point(105, 111);
            dgvBatchtxtCariRoaster.Margin = new Padding(4, 4, 4, 4);
            dgvBatchtxtCariRoaster.Name = "dgvBatchtxtCariRoaster";
            dgvBatchtxtCariRoaster.RowHeadersWidth = 51;
            dgvBatchtxtCariRoaster.Size = new Size(791, 358);
            dgvBatchtxtCariRoaster.TabIndex = 3;
            // 
            // FormRoastingRoaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnTambahtxtCariRoaster);
            Controls.Add(txtCariRoaster);
            Controls.Add(dgvBatchtxtCariRoaster);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormRoastingRoaster";
            Text = "FormRoastingRoaster";
            ((System.ComponentModel.ISupportInitialize)dgvBatchtxtCariRoaster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambahtxtCariRoaster;
        private TextBox txtCariRoaster;
        private DataGridView dgvBatchtxtCariRoaster;
    }
}