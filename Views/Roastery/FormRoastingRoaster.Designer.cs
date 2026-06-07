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
            btnTambahtxtCariRoaster.Location = new Point(84, 390);
            btnTambahtxtCariRoaster.Name = "btnTambahtxtCariRoaster";
            btnTambahtxtCariRoaster.Size = new Size(94, 29);
            btnTambahtxtCariRoaster.TabIndex = 5;
            btnTambahtxtCariRoaster.Text = "button1";
            btnTambahtxtCariRoaster.UseVisualStyleBackColor = true;
            // 
            // txtCariRoaster
            // 
            txtCariRoaster.Location = new Point(84, 32);
            txtCariRoaster.Name = "txtCariRoaster";
            txtCariRoaster.Size = new Size(125, 27);
            txtCariRoaster.TabIndex = 4;
            // 
            // dgvBatchtxtCariRoaster
            // 
            dgvBatchtxtCariRoaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchtxtCariRoaster.Location = new Point(84, 89);
            dgvBatchtxtCariRoaster.Name = "dgvBatchtxtCariRoaster";
            dgvBatchtxtCariRoaster.RowHeadersWidth = 51;
            dgvBatchtxtCariRoaster.Size = new Size(633, 286);
            dgvBatchtxtCariRoaster.TabIndex = 3;
            // 
            // FormRoastingRoaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahtxtCariRoaster);
            Controls.Add(txtCariRoaster);
            Controls.Add(dgvBatchtxtCariRoaster);
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