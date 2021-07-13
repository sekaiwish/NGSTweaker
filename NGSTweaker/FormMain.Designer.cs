
namespace NGSTweaker
{
    partial class FormMain
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
            this.LaunchButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ModsButton = new System.Windows.Forms.Button();
            this.LabelSubtitle = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.Enabled = false;
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.Location = new System.Drawing.Point(284, 230);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(168, 79);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 243);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(108, 30);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(218, 37);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "NGS Tweaker";
            // 
            // ModsButton
            // 
            this.ModsButton.Enabled = false;
            this.ModsButton.Location = new System.Drawing.Point(12, 207);
            this.ModsButton.Name = "ModsButton";
            this.ModsButton.Size = new System.Drawing.Size(108, 30);
            this.ModsButton.TabIndex = 3;
            this.ModsButton.Text = "Manage Mods";
            this.ModsButton.UseVisualStyleBackColor = true;
            this.ModsButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // LabelSubtitle
            // 
            this.LabelSubtitle.AutoSize = true;
            this.LabelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubtitle.Location = new System.Drawing.Point(15, 46);
            this.LabelSubtitle.Name = "LabelSubtitle";
            this.LabelSubtitle.Size = new System.Drawing.Size(199, 20);
            this.LabelSubtitle.TabIndex = 4;
            this.LabelSubtitle.Text = "20 thousand dollars edition";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 279);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LabelSubtitle);
            this.Controls.Add(this.ModsButton);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.LaunchButton);
            this.Icon = global::NGSTweaker.Properties.Resources.IconNGS;
            this.Name = "FormMain";
            this.Text = "NGS Tweaker";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ModsButton;
        private System.Windows.Forms.Label LabelSubtitle;
        private System.Windows.Forms.Button ExitButton;
    }
}

