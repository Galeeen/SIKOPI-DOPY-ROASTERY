namespace SIKOPI_DOPY_ROASTERY.Views.Dialog
{
    partial class FormDialogSeHarga
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
            numHargaAdmin = new NumericUpDown();
            btnSimpanAdmin = new Button();
            btnBatalAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)numHargaAdmin).BeginInit();
            SuspendLayout();
            // 
            // numHargaAdmin
            // 
            numHargaAdmin.Location = new Point(142, 118);
            numHargaAdmin.Margin = new Padding(4, 4, 4, 4);
            numHargaAdmin.Name = "numHargaAdmin";
            numHargaAdmin.Size = new Size(188, 31);
            numHargaAdmin.TabIndex = 0;
            // 
            // btnSimpanAdmin
            // 
            btnSimpanAdmin.Location = new Point(142, 221);
            btnSimpanAdmin.Margin = new Padding(4, 4, 4, 4);
            btnSimpanAdmin.Name = "btnSimpanAdmin";
            btnSimpanAdmin.Size = new Size(118, 36);
            btnSimpanAdmin.TabIndex = 1;
            btnSimpanAdmin.Text = "button1";
            btnSimpanAdmin.UseVisualStyleBackColor = true;
            // 
            // btnBatalAdmin
            // 
            btnBatalAdmin.Location = new Point(304, 221);
            btnBatalAdmin.Margin = new Padding(4, 4, 4, 4);
            btnBatalAdmin.Name = "btnBatalAdmin";
            btnBatalAdmin.Size = new Size(118, 36);
            btnBatalAdmin.TabIndex = 2;
            btnBatalAdmin.Text = "button2";
            btnBatalAdmin.UseVisualStyleBackColor = true;
            btnBatalAdmin.Click += button2_Click;
            // 
            // FormDialogSeHarga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(btnBatalAdmin);
            Controls.Add(btnSimpanAdmin);
            Controls.Add(numHargaAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormDialogSeHarga";
            Text = "FormDialogSeHarga";
            ((System.ComponentModel.ISupportInitialize)numHargaAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numHargaAdmin;
        private Button btnSimpanAdmin;
        private Button btnBatalAdmin;
    }
}