namespace SIKOPI_DOPY_ROASTERY.Views.Dialog
{
    partial class FormDialogBatch
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
            btnBatalRoaster = new Button();
            btnSimpanRoaster = new Button();
            numHasilGramRoaster = new NumericUpDown();
            numGreenDipakaiRoaster = new NumericUpDown();
            cmbLevelRoaster = new ComboBox();
            cmbGreenBeanRoaster = new ComboBox();
            dtpTanggalRoaster = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numHasilGramRoaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGreenDipakaiRoaster).BeginInit();
            SuspendLayout();
            // 
            // btnBatalRoaster
            // 
            btnBatalRoaster.Location = new Point(314, 317);
            btnBatalRoaster.Name = "btnBatalRoaster";
            btnBatalRoaster.Size = new Size(94, 29);
            btnBatalRoaster.TabIndex = 13;
            btnBatalRoaster.Text = "button2";
            btnBatalRoaster.UseVisualStyleBackColor = true;
            // 
            // btnSimpanRoaster
            // 
            btnSimpanRoaster.Location = new Point(102, 317);
            btnSimpanRoaster.Name = "btnSimpanRoaster";
            btnSimpanRoaster.Size = new Size(94, 29);
            btnSimpanRoaster.TabIndex = 12;
            btnSimpanRoaster.Text = "button1";
            btnSimpanRoaster.UseVisualStyleBackColor = true;
            // 
            // numHasilGramRoaster
            // 
            numHasilGramRoaster.Location = new Point(90, 132);
            numHasilGramRoaster.Name = "numHasilGramRoaster";
            numHasilGramRoaster.Size = new Size(150, 27);
            numHasilGramRoaster.TabIndex = 11;
            // 
            // numGreenDipakaiRoaster
            // 
            numGreenDipakaiRoaster.Location = new Point(90, 87);
            numGreenDipakaiRoaster.Name = "numGreenDipakaiRoaster";
            numGreenDipakaiRoaster.Size = new Size(150, 27);
            numGreenDipakaiRoaster.TabIndex = 10;
            // 
            // cmbLevelRoaster
            // 
            cmbLevelRoaster.FormattingEnabled = true;
            cmbLevelRoaster.Location = new Point(89, 188);
            cmbLevelRoaster.Name = "cmbLevelRoaster";
            cmbLevelRoaster.Size = new Size(151, 28);
            cmbLevelRoaster.TabIndex = 9;
            // 
            // cmbGreenBeanRoaster
            // 
            cmbGreenBeanRoaster.FormattingEnabled = true;
            cmbGreenBeanRoaster.Location = new Point(90, 45);
            cmbGreenBeanRoaster.Name = "cmbGreenBeanRoaster";
            cmbGreenBeanRoaster.Size = new Size(151, 28);
            cmbGreenBeanRoaster.TabIndex = 14;
            // 
            // dtpTanggalRoaster
            // 
            dtpTanggalRoaster.Location = new Point(89, 234);
            dtpTanggalRoaster.Name = "dtpTanggalRoaster";
            dtpTanggalRoaster.Size = new Size(250, 27);
            dtpTanggalRoaster.TabIndex = 15;
            // 
            // FormDialogBatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpTanggalRoaster);
            Controls.Add(cmbGreenBeanRoaster);
            Controls.Add(btnBatalRoaster);
            Controls.Add(btnSimpanRoaster);
            Controls.Add(numHasilGramRoaster);
            Controls.Add(numGreenDipakaiRoaster);
            Controls.Add(cmbLevelRoaster);
            Name = "FormDialogBatch";
            Text = "FormDialogBatch";
            ((System.ComponentModel.ISupportInitialize)numHasilGramRoaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGreenDipakaiRoaster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBatalRoaster;
        private Button btnSimpanRoaster;
        private NumericUpDown numHasilGramRoaster;
        private NumericUpDown numGreenDipakaiRoaster;
        private ComboBox cmbLevelRoaster;
        private ComboBox cmbGreenBeanRoaster;
        private DateTimePicker dtpTanggalRoaster;
    }
}