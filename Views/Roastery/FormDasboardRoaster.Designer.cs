namespace SIKOPI_DOPY_ROASTERY.Views.Roastery
{
    partial class FormDasboardRoaster
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
            lblKartu1Roaster = new Label();
            lblKartu2Roaster = new Label();
            SuspendLayout();
            // 
            // lblKartu1Roaster
            // 
            lblKartu1Roaster.AutoSize = true;
            lblKartu1Roaster.Location = new Point(365, 251);
            lblKartu1Roaster.Margin = new Padding(4, 0, 4, 0);
            lblKartu1Roaster.Name = "lblKartu1Roaster";
            lblKartu1Roaster.Size = new Size(59, 25);
            lblKartu1Roaster.TabIndex = 0;
            lblKartu1Roaster.Text = "label1";
            // 
            // lblKartu2Roaster
            // 
            lblKartu2Roaster.AutoSize = true;
            lblKartu2Roaster.Location = new Point(550, 245);
            lblKartu2Roaster.Margin = new Padding(4, 0, 4, 0);
            lblKartu2Roaster.Name = "lblKartu2Roaster";
            lblKartu2Roaster.Size = new Size(59, 25);
            lblKartu2Roaster.TabIndex = 1;
            lblKartu2Roaster.Text = "label2";
            // 
            // FormDasboardRoaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(lblKartu2Roaster);
            Controls.Add(lblKartu1Roaster);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormDasboardRoaster";
            Text = "FormDasboardRoaster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKartu1Roaster;
        private Label lblKartu2Roaster;
    }
}