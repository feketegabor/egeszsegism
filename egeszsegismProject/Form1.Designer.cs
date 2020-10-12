namespace egeszsegismProject
{
    partial class Form1
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
            this.evComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.honapComboBox = new System.Windows.Forms.ComboBox();
            this.tipusListBox = new System.Windows.Forms.ListBox();
            this.temaListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.szuresButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fajtaComboBox = new System.Windows.Forms.ComboBox();
            this.temakorComboBox = new System.Windows.Forms.ComboBox();
            this.temakorCheckBox = new System.Windows.Forms.CheckBox();
            this.feladatFajtaCheckBox = new System.Windows.Forms.CheckBox();
            this.evCheckBox = new System.Windows.Forms.CheckBox();
            this.honapCheckBox = new System.Windows.Forms.CheckBox();
            this.feladatTipusCheckBox = new System.Windows.Forms.CheckBox();
            this.temaCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.megoldasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evComboBox
            // 
            this.evComboBox.FormattingEnabled = true;
            this.evComboBox.Location = new System.Drawing.Point(25, 47);
            this.evComboBox.Name = "evComboBox";
            this.evComboBox.Size = new System.Drawing.Size(151, 24);
            this.evComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Év";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hónap";
            // 
            // honapComboBox
            // 
            this.honapComboBox.FormattingEnabled = true;
            this.honapComboBox.Location = new System.Drawing.Point(25, 111);
            this.honapComboBox.Name = "honapComboBox";
            this.honapComboBox.Size = new System.Drawing.Size(151, 24);
            this.honapComboBox.TabIndex = 6;
            // 
            // tipusListBox
            // 
            this.tipusListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipusListBox.FormattingEnabled = true;
            this.tipusListBox.ItemHeight = 16;
            this.tipusListBox.Location = new System.Drawing.Point(455, 111);
            this.tipusListBox.Name = "tipusListBox";
            this.tipusListBox.Size = new System.Drawing.Size(297, 276);
            this.tipusListBox.TabIndex = 7;
            // 
            // temaListBox
            // 
            this.temaListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.temaListBox.FormattingEnabled = true;
            this.temaListBox.ItemHeight = 16;
            this.temaListBox.Location = new System.Drawing.Point(185, 111);
            this.temaListBox.Name = "temaListBox";
            this.temaListBox.Size = new System.Drawing.Size(261, 276);
            this.temaListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Feladattípus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Téma";
            // 
            // szuresButton
            // 
            this.szuresButton.Location = new System.Drawing.Point(27, 159);
            this.szuresButton.Name = "szuresButton";
            this.szuresButton.Size = new System.Drawing.Size(140, 62);
            this.szuresButton.TabIndex = 11;
            this.szuresButton.Text = "Feladatok";
            this.szuresButton.UseVisualStyleBackColor = true;
            this.szuresButton.Click += new System.EventHandler(this.SzuresButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Feladat fajta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Témakör";
            // 
            // fajtaComboBox
            // 
            this.fajtaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fajtaComboBox.FormattingEnabled = true;
            this.fajtaComboBox.Location = new System.Drawing.Point(452, 47);
            this.fajtaComboBox.Name = "fajtaComboBox";
            this.fajtaComboBox.Size = new System.Drawing.Size(300, 24);
            this.fajtaComboBox.TabIndex = 14;
            this.fajtaComboBox.SelectedIndexChanged += new System.EventHandler(this.FajtaComboBox_SelectedIndexChanged);
            // 
            // temakorComboBox
            // 
            this.temakorComboBox.FormattingEnabled = true;
            this.temakorComboBox.Location = new System.Drawing.Point(182, 47);
            this.temakorComboBox.Name = "temakorComboBox";
            this.temakorComboBox.Size = new System.Drawing.Size(264, 24);
            this.temakorComboBox.TabIndex = 15;
            this.temakorComboBox.SelectedIndexChanged += new System.EventHandler(this.TemakorComboBox_SelectedIndexChanged);
            // 
            // temakorCheckBox
            // 
            this.temakorCheckBox.AutoSize = true;
            this.temakorCheckBox.Location = new System.Drawing.Point(274, 28);
            this.temakorCheckBox.Name = "temakorCheckBox";
            this.temakorCheckBox.Size = new System.Drawing.Size(18, 17);
            this.temakorCheckBox.TabIndex = 16;
            this.temakorCheckBox.UseVisualStyleBackColor = true;
            this.temakorCheckBox.CheckedChanged += new System.EventHandler(this.temakorCheckBox_CheckedChanged);
            // 
            // feladatFajtaCheckBox
            // 
            this.feladatFajtaCheckBox.AutoSize = true;
            this.feladatFajtaCheckBox.Location = new System.Drawing.Point(543, 28);
            this.feladatFajtaCheckBox.Name = "feladatFajtaCheckBox";
            this.feladatFajtaCheckBox.Size = new System.Drawing.Size(18, 17);
            this.feladatFajtaCheckBox.TabIndex = 17;
            this.feladatFajtaCheckBox.UseVisualStyleBackColor = true;
            this.feladatFajtaCheckBox.CheckedChanged += new System.EventHandler(this.feladatFajtaCheckBox_CheckedChanged);
            // 
            // evCheckBox
            // 
            this.evCheckBox.AutoSize = true;
            this.evCheckBox.Location = new System.Drawing.Point(54, 27);
            this.evCheckBox.Name = "evCheckBox";
            this.evCheckBox.Size = new System.Drawing.Size(18, 17);
            this.evCheckBox.TabIndex = 18;
            this.evCheckBox.UseVisualStyleBackColor = true;
            this.evCheckBox.CheckedChanged += new System.EventHandler(this.evCheckBox_CheckedChanged);
            // 
            // honapCheckBox
            // 
            this.honapCheckBox.AutoSize = true;
            this.honapCheckBox.Location = new System.Drawing.Point(78, 92);
            this.honapCheckBox.Name = "honapCheckBox";
            this.honapCheckBox.Size = new System.Drawing.Size(18, 17);
            this.honapCheckBox.TabIndex = 19;
            this.honapCheckBox.UseVisualStyleBackColor = true;
            this.honapCheckBox.CheckedChanged += new System.EventHandler(this.honapCheckBox_CheckedChanged);
            // 
            // feladatTipusCheckBox
            // 
            this.feladatTipusCheckBox.AutoSize = true;
            this.feladatTipusCheckBox.Location = new System.Drawing.Point(543, 90);
            this.feladatTipusCheckBox.Name = "feladatTipusCheckBox";
            this.feladatTipusCheckBox.Size = new System.Drawing.Size(18, 17);
            this.feladatTipusCheckBox.TabIndex = 20;
            this.feladatTipusCheckBox.UseVisualStyleBackColor = true;
            this.feladatTipusCheckBox.CheckedChanged += new System.EventHandler(this.feladatTipusCheckBox_CheckedChanged);
            // 
            // temaCheckBox
            // 
            this.temaCheckBox.AutoSize = true;
            this.temaCheckBox.Location = new System.Drawing.Point(232, 91);
            this.temaCheckBox.Name = "temaCheckBox";
            this.temaCheckBox.Size = new System.Drawing.Size(18, 17);
            this.temaCheckBox.TabIndex = 21;
            this.temaCheckBox.UseVisualStyleBackColor = true;
            this.temaCheckBox.CheckedChanged += new System.EventHandler(this.temaCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 65);
            this.button1.TabIndex = 22;
            this.button1.Text = "Adatbázisadatok szerkesztése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // megoldasButton
            // 
            this.megoldasButton.Location = new System.Drawing.Point(27, 227);
            this.megoldasButton.Name = "megoldasButton";
            this.megoldasButton.Size = new System.Drawing.Size(140, 62);
            this.megoldasButton.TabIndex = 23;
            this.megoldasButton.Text = "Megoldások";
            this.megoldasButton.UseVisualStyleBackColor = true;
            this.megoldasButton.Click += new System.EventHandler(this.megoldasButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 426);
            this.Controls.Add(this.megoldasButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temaCheckBox);
            this.Controls.Add(this.feladatTipusCheckBox);
            this.Controls.Add(this.honapCheckBox);
            this.Controls.Add(this.evCheckBox);
            this.Controls.Add(this.feladatFajtaCheckBox);
            this.Controls.Add(this.temakorCheckBox);
            this.Controls.Add(this.temakorComboBox);
            this.Controls.Add(this.fajtaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.szuresButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.temaListBox);
            this.Controls.Add(this.tipusListBox);
            this.Controls.Add(this.honapComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox evComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox honapComboBox;
        private System.Windows.Forms.ListBox tipusListBox;
        private System.Windows.Forms.ListBox temaListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button szuresButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fajtaComboBox;
        private System.Windows.Forms.ComboBox temakorComboBox;
        private System.Windows.Forms.CheckBox temakorCheckBox;
        private System.Windows.Forms.CheckBox feladatFajtaCheckBox;
        private System.Windows.Forms.CheckBox evCheckBox;
        private System.Windows.Forms.CheckBox honapCheckBox;
        private System.Windows.Forms.CheckBox feladatTipusCheckBox;
        private System.Windows.Forms.CheckBox temaCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button megoldasButton;
    }
}

