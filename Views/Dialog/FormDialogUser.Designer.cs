namespace SIKOPI_DOPY_ROASTERY.Views.Dialog
{
    partial class FormDialogUser
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtUsernameAdmin = new TextBox();
            txtNamaAdmin = new TextBox();
            txtPasswordAdmin = new TextBox();
            cmbPeranAdmin = new ComboBox();
            btnSimpanAdmin = new Button();
            btnBatalAdmin = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtUsernameAdmin
            // 
            txtUsernameAdmin.Location = new Point(89, 36);
            txtUsernameAdmin.Name = "txtUsernameAdmin";
            txtUsernameAdmin.Size = new Size(125, 27);
            txtUsernameAdmin.TabIndex = 1;
            // 
            // txtNamaAdmin
            // 
            txtNamaAdmin.Location = new Point(89, 87);
            txtNamaAdmin.Name = "txtNamaAdmin";
            txtNamaAdmin.Size = new Size(125, 27);
            txtNamaAdmin.TabIndex = 2;
            // 
            // txtPasswordAdmin
            // 
            txtPasswordAdmin.Location = new Point(89, 180);
            txtPasswordAdmin.Name = "txtPasswordAdmin";
            txtPasswordAdmin.Size = new Size(125, 27);
            txtPasswordAdmin.TabIndex = 3;
            // 
            // cmbPeranAdmin
            // 
            cmbPeranAdmin.FormattingEnabled = true;
            cmbPeranAdmin.Location = new Point(89, 134);
            cmbPeranAdmin.Name = "cmbPeranAdmin";
            cmbPeranAdmin.Size = new Size(151, 28);
            cmbPeranAdmin.TabIndex = 4;
            // 
            // btnSimpanAdmin
            // 
            btnSimpanAdmin.Location = new Point(101, 231);
            btnSimpanAdmin.Name = "btnSimpanAdmin";
            btnSimpanAdmin.Size = new Size(94, 29);
            btnSimpanAdmin.TabIndex = 6;
            btnSimpanAdmin.Text = "button2";
            btnSimpanAdmin.UseVisualStyleBackColor = true;
            // 
            // btnBatalAdmin
            // 
            btnBatalAdmin.Location = new Point(242, 237);
            btnBatalAdmin.Name = "btnBatalAdmin";
            btnBatalAdmin.Size = new Size(94, 29);
            btnBatalAdmin.TabIndex = 7;
            btnBatalAdmin.Text = "button3";
            btnBatalAdmin.UseVisualStyleBackColor = true;
            // 
            // FormDialogUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatalAdmin);
            Controls.Add(btnSimpanAdmin);
            Controls.Add(cmbPeranAdmin);
            Controls.Add(txtPasswordAdmin);
            Controls.Add(txtNamaAdmin);
            Controls.Add(txtUsernameAdmin);
            Name = "FormDialogUser";
            Text = "FormDialogUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtUsernameAdmin;
        private TextBox txtNamaAdmin;
        private TextBox txtPasswordAdmin;
        private ComboBox cmbPeranAdmin;
        private Button btnSimpanAdmin;
        private Button btnBatalAdmin;
    }
}