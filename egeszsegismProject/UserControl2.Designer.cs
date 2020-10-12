namespace egeszsegismProject
{
    partial class UserControl2
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
            this.feladatListBox = new System.Windows.Forms.ListBox();
            this.torlesButton = new System.Windows.Forms.Button();
            this.megseTorlesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feladatListBox
            // 
            this.feladatListBox.FormattingEnabled = true;
            this.feladatListBox.ItemHeight = 16;
            this.feladatListBox.Location = new System.Drawing.Point(29, 57);
            this.feladatListBox.Name = "feladatListBox";
            this.feladatListBox.Size = new System.Drawing.Size(279, 580);
            this.feladatListBox.TabIndex = 0;
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(29, 643);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(163, 70);
            this.torlesButton.TabIndex = 1;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
            // 
            // megseTorlesButton
            // 
            this.megseTorlesButton.Location = new System.Drawing.Point(198, 643);
            this.megseTorlesButton.Name = "megseTorlesButton";
            this.megseTorlesButton.Size = new System.Drawing.Size(110, 71);
            this.megseTorlesButton.TabIndex = 2;
            this.megseTorlesButton.Text = "&Mégse";
            this.megseTorlesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feladat és megoldásának törlése";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.megseTorlesButton);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.feladatListBox);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(339, 738);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox feladatListBox;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Button megseTorlesButton;
        private System.Windows.Forms.Label label1;
    }
}
