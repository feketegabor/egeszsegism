namespace egeszsegismProject
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.moPdfTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hozzaadasButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flMagassagTextBox = new System.Windows.Forms.TextBox();
            this.flSzelessegTextBox = new System.Windows.Forms.TextBox();
            this.flTipusTextBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flHonapComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flSorszamTextBox = new System.Windows.Forms.TextBox();
            this.flEvTextBox = new System.Windows.Forms.TextBox();
            this.flPdfTextBox = new System.Windows.Forms.TextBox();
            this.moMagassagTextBox = new System.Windows.Forms.TextBox();
            this.moSzelessegTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flKepTextBox = new System.Windows.Forms.TextBox();
            this.moKepTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flFileButton = new System.Windows.Forms.Button();
            this.moFileButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // moPdfTextBox
            // 
            this.moPdfTextBox.Location = new System.Drawing.Point(504, 62);
            this.moPdfTextBox.Name = "moPdfTextBox";
            this.moPdfTextBox.Size = new System.Drawing.Size(121, 22);
            this.moPdfTextBox.TabIndex = 55;
            this.moPdfTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moPdfTextBox_Validating);
            this.moPdfTextBox.Validated += new System.EventHandler(this.moPdfTextBox_Validated);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(373, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "Megoldás kép";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Megoldás pdf URL";
            // 
            // hozzaadasButton
            // 
            this.hozzaadasButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.hozzaadasButton.Location = new System.Drawing.Point(406, 421);
            this.hozzaadasButton.Name = "hozzaadasButton";
            this.hozzaadasButton.Size = new System.Drawing.Size(143, 42);
            this.hozzaadasButton.TabIndex = 48;
            this.hozzaadasButton.Text = "Hozzáadás";
            this.hozzaadasButton.UseVisualStyleBackColor = true;
            this.hozzaadasButton.Click += new System.EventHandler(this.hozzaadasButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Feladat és megoldás hozzáadás";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Feladat kép";
            // 
            // flMagassagTextBox
            // 
            this.flMagassagTextBox.Location = new System.Drawing.Point(188, 381);
            this.flMagassagTextBox.Name = "flMagassagTextBox";
            this.flMagassagTextBox.Size = new System.Drawing.Size(121, 22);
            this.flMagassagTextBox.TabIndex = 44;
            this.flMagassagTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.flMagassagTextBox_Validating);
            this.flMagassagTextBox.Validated += new System.EventHandler(this.flMagassagTextBox_Validated);
            // 
            // flSzelessegTextBox
            // 
            this.flSzelessegTextBox.Location = new System.Drawing.Point(188, 327);
            this.flSzelessegTextBox.Name = "flSzelessegTextBox";
            this.flSzelessegTextBox.Size = new System.Drawing.Size(121, 22);
            this.flSzelessegTextBox.TabIndex = 43;
            this.flSzelessegTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.flSzelessegTextBox_Validating);
            this.flSzelessegTextBox.Validated += new System.EventHandler(this.flSzelessegTextBox_Validated);
            // 
            // flTipusTextBox
            // 
            this.flTipusTextBox.FormattingEnabled = true;
            this.flTipusTextBox.Location = new System.Drawing.Point(188, 274);
            this.flTipusTextBox.Name = "flTipusTextBox";
            this.flTipusTextBox.Size = new System.Drawing.Size(121, 24);
            this.flTipusTextBox.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Feladat magasság";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Feladat szélesség";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Feladat típusa";
            // 
            // flHonapComboBox
            // 
            this.flHonapComboBox.FormattingEnabled = true;
            this.flHonapComboBox.Location = new System.Drawing.Point(188, 174);
            this.flHonapComboBox.Name = "flHonapComboBox";
            this.flHonapComboBox.Size = new System.Drawing.Size(121, 24);
            this.flHonapComboBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Feladat sorszáma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hónap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Év";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Feladat pdf URL";
            // 
            // flSorszamTextBox
            // 
            this.flSorszamTextBox.Location = new System.Drawing.Point(188, 223);
            this.flSorszamTextBox.Name = "flSorszamTextBox";
            this.flSorszamTextBox.Size = new System.Drawing.Size(121, 22);
            this.flSorszamTextBox.TabIndex = 33;
            this.flSorszamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.flSorszamTextBox_Validating);
            this.flSorszamTextBox.Validated += new System.EventHandler(this.flSorszamTextBox_Validated);
            // 
            // flEvTextBox
            // 
            this.flEvTextBox.Location = new System.Drawing.Point(188, 113);
            this.flEvTextBox.Name = "flEvTextBox";
            this.flEvTextBox.Size = new System.Drawing.Size(121, 22);
            this.flEvTextBox.TabIndex = 32;
            this.flEvTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.flEvTextBox_Validating);
            this.flEvTextBox.Validated += new System.EventHandler(this.flEvTextBox_Validated);
            // 
            // flPdfTextBox
            // 
            this.flPdfTextBox.Location = new System.Drawing.Point(188, 62);
            this.flPdfTextBox.Name = "flPdfTextBox";
            this.flPdfTextBox.Size = new System.Drawing.Size(121, 22);
            this.flPdfTextBox.TabIndex = 31;
            this.flPdfTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.flPdfTextBox_Validating);
            this.flPdfTextBox.Validated += new System.EventHandler(this.flPdfTextBox_Validated);
            // 
            // moMagassagTextBox
            // 
            this.moMagassagTextBox.Location = new System.Drawing.Point(504, 174);
            this.moMagassagTextBox.Name = "moMagassagTextBox";
            this.moMagassagTextBox.Size = new System.Drawing.Size(121, 22);
            this.moMagassagTextBox.TabIndex = 62;
            this.moMagassagTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moMagassagTextBox_Validating);
            this.moMagassagTextBox.Validated += new System.EventHandler(this.moMagassagTextBox_Validated);
            // 
            // moSzelessegTextBox
            // 
            this.moSzelessegTextBox.Location = new System.Drawing.Point(504, 113);
            this.moSzelessegTextBox.Name = "moSzelessegTextBox";
            this.moSzelessegTextBox.Size = new System.Drawing.Size(121, 22);
            this.moSzelessegTextBox.TabIndex = 61;
            this.moSzelessegTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moSzelessegTextBox_Validating);
            this.moSzelessegTextBox.Validated += new System.EventHandler(this.moSzelessegTextBox_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Megoldás magasság";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(362, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "Megoldás szélesség";
            // 
            // flKepTextBox
            // 
            this.flKepTextBox.Location = new System.Drawing.Point(188, 431);
            this.flKepTextBox.Name = "flKepTextBox";
            this.flKepTextBox.Size = new System.Drawing.Size(55, 22);
            this.flKepTextBox.TabIndex = 44;
            // 
            // moKepTextBox
            // 
            this.moKepTextBox.Location = new System.Drawing.Point(504, 224);
            this.moKepTextBox.Name = "moKepTextBox";
            this.moKepTextBox.Size = new System.Drawing.Size(55, 22);
            this.moKepTextBox.TabIndex = 44;
            // 
            // flFileButton
            // 
            this.flFileButton.Location = new System.Drawing.Point(249, 431);
            this.flFileButton.Name = "flFileButton";
            this.flFileButton.Size = new System.Drawing.Size(60, 23);
            this.flFileButton.TabIndex = 63;
            this.flFileButton.Text = "Keres";
            this.flFileButton.UseVisualStyleBackColor = true;
            this.flFileButton.Click += new System.EventHandler(this.flFileButton_Click);
            // 
            // moFileButton
            // 
            this.moFileButton.Location = new System.Drawing.Point(565, 223);
            this.moFileButton.Name = "moFileButton";
            this.moFileButton.Size = new System.Drawing.Size(60, 23);
            this.moFileButton.TabIndex = 64;
            this.moFileButton.Text = "Keres";
            this.moFileButton.UseVisualStyleBackColor = true;
            this.moFileButton.Click += new System.EventHandler(this.moFileButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(1563, 1250);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(0, 0);
            this.cancelButton.TabIndex = 65;
            this.cancelButton.Text = "button1";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.moFileButton);
            this.Controls.Add(this.flFileButton);
            this.Controls.Add(this.moMagassagTextBox);
            this.Controls.Add(this.moSzelessegTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.moPdfTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.hozzaadasButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.moKepTextBox);
            this.Controls.Add(this.flKepTextBox);
            this.Controls.Add(this.flMagassagTextBox);
            this.Controls.Add(this.flSzelessegTextBox);
            this.Controls.Add(this.flTipusTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flHonapComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flSorszamTextBox);
            this.Controls.Add(this.flEvTextBox);
            this.Controls.Add(this.flPdfTextBox);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(657, 493);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox moPdfTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button hozzaadasButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox flMagassagTextBox;
        private System.Windows.Forms.TextBox flSzelessegTextBox;
        private System.Windows.Forms.ComboBox flTipusTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox flHonapComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flSorszamTextBox;
        private System.Windows.Forms.TextBox flEvTextBox;
        private System.Windows.Forms.TextBox flPdfTextBox;
        private System.Windows.Forms.TextBox moMagassagTextBox;
        private System.Windows.Forms.TextBox moSzelessegTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox flKepTextBox;
        private System.Windows.Forms.TextBox moKepTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button flFileButton;
        private System.Windows.Forms.Button moFileButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cancelButton;
    }
}
