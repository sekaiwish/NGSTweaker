
namespace NGSTweaker
{
    partial class FormSettings
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
            this.Icon = NGSTweaker.Properties.Resources.NGS;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.BinLabel = new System.Windows.Forms.Label();
            this.BinText = new System.Windows.Forms.TextBox();
            this.BinButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BinLabel
            // 
            this.BinLabel.AutoSize = true;
            this.BinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinLabel.Location = new System.Drawing.Point(12, 34);
            this.BinLabel.Name = "BinLabel";
            this.BinLabel.Size = new System.Drawing.Size(81, 17);
            this.BinLabel.TabIndex = 0;
            this.BinLabel.Text = "Binary Path";
            // 
            // BinText
            // 
            this.BinText.Location = new System.Drawing.Point(99, 34);
            this.BinText.Name = "BinText";
            this.BinText.ReadOnly = true;
            this.BinText.Size = new System.Drawing.Size(284, 20);
            this.BinText.TabIndex = 1;
            // 
            // BinButton
            // 
            this.BinButton.Location = new System.Drawing.Point(389, 34);
            this.BinButton.Name = "BinButton";
            this.BinButton.Size = new System.Drawing.Size(63, 20);
            this.BinButton.TabIndex = 2;
            this.BinButton.Text = "Choose...";
            this.BinButton.UseVisualStyleBackColor = true;
            this.BinButton.Click += new System.EventHandler(this.BinButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Smut Filter";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BinButton);
            this.Controls.Add(this.BinText);
            this.Controls.Add(this.BinLabel);
            this.Name = "FormSettings";
            this.Text = "Tweaker Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BinLabel;
        private System.Windows.Forms.TextBox BinText;
        private System.Windows.Forms.Button BinButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}