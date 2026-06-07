namespace SIKOPI_DOPY_ROASTERY.Views.Penjual
{
    partial class FormDasboardPenjual
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
            lblKartu1Penjual = new Label();
            lblKartu2Penjual = new Label();
            SuspendLayout();
            // 
            // lblKartu1Penjual
            // 
            lblKartu1Penjual.AutoSize = true;
            lblKartu1Penjual.Location = new Point(255, 192);
            lblKartu1Penjual.Name = "lblKartu1Penjual";
            lblKartu1Penjual.Size = new Size(50, 20);
            lblKartu1Penjual.TabIndex = 0;
            lblKartu1Penjual.Text = "label1";
            // 
            // lblKartu2Penjual
            // 
            lblKartu2Penjual.AutoSize = true;
            lblKartu2Penjual.Location = new Point(438, 213);
            lblKartu2Penjual.Name = "lblKartu2Penjual";
            lblKartu2Penjual.Size = new Size(50, 20);
            lblKartu2Penjual.TabIndex = 1;
            lblKartu2Penjual.Text = "label2";
            // 
            // FormDasboardPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKartu2Penjual);
            Controls.Add(lblKartu1Penjual);
            Name = "FormDasboardPenjual";
            Text = "FormDasboardPenjual";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKartu1Penjual;
        private Label lblKartu2Penjual;
    }
}