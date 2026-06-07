namespace SIKOPI_DOPY_ROASTERY.Views.Dialog
{
    partial class FormDialogBeli
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
            txtPelangganPenjual = new TextBox();
            numQtyGramPenjual = new NumericUpDown();
            lblTotalPenjual = new Label();
            btnKonfirmasiPenjual = new Button();
            btnBatalPenjual = new Button();
            ((System.ComponentModel.ISupportInitialize)numQtyGramPenjual).BeginInit();
            SuspendLayout();
            // 
            // txtPelangganPenjual
            // 
            txtPelangganPenjual.Location = new Point(119, 94);
            txtPelangganPenjual.Margin = new Padding(4, 4, 4, 4);
            txtPelangganPenjual.Name = "txtPelangganPenjual";
            txtPelangganPenjual.Size = new Size(155, 31);
            txtPelangganPenjual.TabIndex = 0;
            // 
            // numQtyGramPenjual
            // 
            numQtyGramPenjual.Location = new Point(119, 170);
            numQtyGramPenjual.Margin = new Padding(4, 4, 4, 4);
            numQtyGramPenjual.Name = "numQtyGramPenjual";
            numQtyGramPenjual.Size = new Size(188, 31);
            numQtyGramPenjual.TabIndex = 1;
            // 
            // lblTotalPenjual
            // 
            lblTotalPenjual.AutoSize = true;
            lblTotalPenjual.Location = new Point(119, 234);
            lblTotalPenjual.Margin = new Padding(4, 0, 4, 0);
            lblTotalPenjual.Name = "lblTotalPenjual";
            lblTotalPenjual.Size = new Size(59, 25);
            lblTotalPenjual.TabIndex = 2;
            lblTotalPenjual.Text = "label1";
            // 
            // btnKonfirmasiPenjual
            // 
            btnKonfirmasiPenjual.Location = new Point(140, 352);
            btnKonfirmasiPenjual.Margin = new Padding(4, 4, 4, 4);
            btnKonfirmasiPenjual.Name = "btnKonfirmasiPenjual";
            btnKonfirmasiPenjual.Size = new Size(118, 36);
            btnKonfirmasiPenjual.TabIndex = 3;
            btnKonfirmasiPenjual.Text = "button1";
            btnKonfirmasiPenjual.UseVisualStyleBackColor = true;
            // 
            // btnBatalPenjual
            // 
            btnBatalPenjual.Location = new Point(305, 352);
            btnBatalPenjual.Margin = new Padding(4, 4, 4, 4);
            btnBatalPenjual.Name = "btnBatalPenjual";
            btnBatalPenjual.Size = new Size(118, 36);
            btnBatalPenjual.TabIndex = 4;
            btnBatalPenjual.Text = "button2";
            btnBatalPenjual.UseVisualStyleBackColor = true;
            // 
            // FormDialogBeli
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnBatalPenjual);
            Controls.Add(btnKonfirmasiPenjual);
            Controls.Add(lblTotalPenjual);
            Controls.Add(numQtyGramPenjual);
            Controls.Add(txtPelangganPenjual);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormDialogBeli";
            Text = "FormDialogBeli";
            ((System.ComponentModel.ISupportInitialize)numQtyGramPenjual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPelangganPenjual;
        private NumericUpDown numQtyGramPenjual;
        private Label lblTotalPenjual;
        private Button btnKonfirmasiPenjual;
        private Button btnBatalPenjual;
    }
}