namespace SIKOPI_DOPY_ROASTERY.Views.Admin
{
    partial class FormDasboardAdmin
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
            lblKartu1Admin = new Label();
            lblKartu2Admin = new Label();
            lblKartu3Admin = new Label();
            SuspendLayout();
            // 
            // lblKartu1Admin
            // 
            lblKartu1Admin.AutoSize = true;
            lblKartu1Admin.Location = new Point(125, 195);
            lblKartu1Admin.Name = "lblKartu1Admin";
            lblKartu1Admin.Size = new Size(50, 20);
            lblKartu1Admin.TabIndex = 0;
            lblKartu1Admin.Text = "label1";
            // 
            // lblKartu2Admin
            // 
            lblKartu2Admin.AutoSize = true;
            lblKartu2Admin.Location = new Point(246, 196);
            lblKartu2Admin.Name = "lblKartu2Admin";
            lblKartu2Admin.Size = new Size(50, 20);
            lblKartu2Admin.TabIndex = 1;
            lblKartu2Admin.Text = "label2";
            // 
            // lblKartu3Admin
            // 
            lblKartu3Admin.AutoSize = true;
            lblKartu3Admin.Location = new Point(358, 198);
            lblKartu3Admin.Name = "lblKartu3Admin";
            lblKartu3Admin.Size = new Size(50, 20);
            lblKartu3Admin.TabIndex = 2;
            lblKartu3Admin.Text = "label3";
            // 
            // FormDasboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKartu3Admin);
            Controls.Add(lblKartu2Admin);
            Controls.Add(lblKartu1Admin);
            Name = "FormDasboardAdmin";
            Text = "FormDasboardAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKartu1Admin;
        private Label lblKartu2Admin;
        private Label lblKartu3Admin;
    }
}