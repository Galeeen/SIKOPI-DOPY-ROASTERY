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
            btnBatalRoaster.Location = new Point(392, 396);
            btnBatalRoaster.Margin = new Padding(4, 4, 4, 4);
            btnBatalRoaster.Name = "btnBatalRoaster";
            btnBatalRoaster.Size = new Size(118, 36);
            btnBatalRoaster.TabIndex = 13;
            btnBatalRoaster.Text = "button2";
            btnBatalRoaster.UseVisualStyleBackColor = true;
            // 
            // btnSimpanRoaster
            // 
            btnSimpanRoaster.Location = new Point(128, 396);
            btnSimpanRoaster.Margin = new Padding(4, 4, 4, 4);
            btnSimpanRoaster.Name = "btnSimpanRoaster";
            btnSimpanRoaster.Size = new Size(118, 36);
            btnSimpanRoaster.TabIndex = 12;
            btnSimpanRoaster.Text = "button1";
            btnSimpanRoaster.UseVisualStyleBackColor = true;
            // 
            // numHasilGramRoaster
            // 
            numHasilGramRoaster.Location = new Point(112, 165);
            numHasilGramRoaster.Margin = new Padding(4, 4, 4, 4);
            numHasilGramRoaster.Name = "numHasilGramRoaster";
            numHasilGramRoaster.Size = new Size(188, 31);
            numHasilGramRoaster.TabIndex = 11;
            // 
            // numGreenDipakaiRoaster
            // 
            numGreenDipakaiRoaster.Location = new Point(112, 109);
            numGreenDipakaiRoaster.Margin = new Padding(4, 4, 4, 4);
            numGreenDipakaiRoaster.Name = "numGreenDipakaiRoaster";
            numGreenDipakaiRoaster.Size = new Size(188, 31);
            numGreenDipakaiRoaster.TabIndex = 10;
            // 
            // cmbLevelRoaster
            // 
            cmbLevelRoaster.FormattingEnabled = true;
            cmbLevelRoaster.Location = new Point(111, 235);
            cmbLevelRoaster.Margin = new Padding(4, 4, 4, 4);
            cmbLevelRoaster.Name = "cmbLevelRoaster";
            cmbLevelRoaster.Size = new Size(188, 33);
            cmbLevelRoaster.TabIndex = 9;
            // 
            // cmbGreenBeanRoaster
            // 
            cmbGreenBeanRoaster.FormattingEnabled = true;
            cmbGreenBeanRoaster.Location = new Point(112, 56);
            cmbGreenBeanRoaster.Margin = new Padding(4, 4, 4, 4);
            cmbGreenBeanRoaster.Name = "cmbGreenBeanRoaster";
            cmbGreenBeanRoaster.Size = new Size(188, 33);
            cmbGreenBeanRoaster.TabIndex = 14;
            // 
            // dtpTanggalRoaster
            // 
            dtpTanggalRoaster.Location = new Point(111, 292);
            dtpTanggalRoaster.Margin = new Padding(4, 4, 4, 4);
            dtpTanggalRoaster.Name = "dtpTanggalRoaster";
            dtpTanggalRoaster.Size = new Size(312, 31);
            dtpTanggalRoaster.TabIndex = 15;
            // 
            // FormDialogBatch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(dtpTanggalRoaster);
            Controls.Add(cmbGreenBeanRoaster);
            Controls.Add(btnBatalRoaster);
            Controls.Add(btnSimpanRoaster);
            Controls.Add(numHasilGramRoaster);
            Controls.Add(numGreenDipakaiRoaster);
            Controls.Add(cmbLevelRoaster);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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