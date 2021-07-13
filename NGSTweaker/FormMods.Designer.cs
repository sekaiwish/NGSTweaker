
namespace NGSTweaker
{
    partial class FormMods
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
            this.ListActive = new System.Windows.Forms.ListBox();
            this.ListInactive = new System.Windows.Forms.ListBox();
            this.ButtonDisable = new System.Windows.Forms.Button();
            this.ButtonEnable = new System.Windows.Forms.Button();
            this.LabelActive = new System.Windows.Forms.Label();
            this.LabelInactive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListActive
            // 
            this.ListActive.FormattingEnabled = true;
            this.ListActive.Location = new System.Drawing.Point(12, 25);
            this.ListActive.Name = "ListActive";
            this.ListActive.Size = new System.Drawing.Size(195, 277);
            this.ListActive.TabIndex = 0;
            // 
            // ListInactive
            // 
            this.ListInactive.FormattingEnabled = true;
            this.ListInactive.Location = new System.Drawing.Point(257, 25);
            this.ListInactive.Name = "ListInactive";
            this.ListInactive.Size = new System.Drawing.Size(195, 277);
            this.ListInactive.TabIndex = 1;
            // 
            // ButtonDisable
            // 
            this.ButtonDisable.Location = new System.Drawing.Point(213, 124);
            this.ButtonDisable.Name = "ButtonDisable";
            this.ButtonDisable.Size = new System.Drawing.Size(29, 27);
            this.ButtonDisable.TabIndex = 2;
            this.ButtonDisable.Text = ">>";
            this.ButtonDisable.UseVisualStyleBackColor = true;
            this.ButtonDisable.Click += new System.EventHandler(this.ButtonDisable_Click);
            // 
            // ButtonEnable
            // 
            this.ButtonEnable.Location = new System.Drawing.Point(222, 157);
            this.ButtonEnable.Name = "ButtonEnable";
            this.ButtonEnable.Size = new System.Drawing.Size(29, 27);
            this.ButtonEnable.TabIndex = 3;
            this.ButtonEnable.Text = "<<";
            this.ButtonEnable.UseVisualStyleBackColor = true;
            this.ButtonEnable.Click += new System.EventHandler(this.ButtonEnable_Click);
            // 
            // LabelActive
            // 
            this.LabelActive.AutoSize = true;
            this.LabelActive.Location = new System.Drawing.Point(12, 9);
            this.LabelActive.Name = "LabelActive";
            this.LabelActive.Size = new System.Drawing.Size(66, 13);
            this.LabelActive.TabIndex = 4;
            this.LabelActive.Text = "Active Mods";
            // 
            // LabelInactive
            // 
            this.LabelInactive.AutoSize = true;
            this.LabelInactive.Location = new System.Drawing.Point(254, 9);
            this.LabelInactive.Name = "LabelInactive";
            this.LabelInactive.Size = new System.Drawing.Size(74, 13);
            this.LabelInactive.TabIndex = 5;
            this.LabelInactive.Text = "Inactive Mods";
            // 
            // FormMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.LabelInactive);
            this.Controls.Add(this.LabelActive);
            this.Controls.Add(this.ButtonEnable);
            this.Controls.Add(this.ButtonDisable);
            this.Controls.Add(this.ListInactive);
            this.Controls.Add(this.ListActive);
            this.Icon = global::NGSTweaker.Properties.Resources.NGS;
            this.Name = "FormMods";
            this.Text = "Mod Manager";
            this.Load += new System.EventHandler(this.FormMods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListActive;
        private System.Windows.Forms.ListBox ListInactive;
        private System.Windows.Forms.Button ButtonDisable;
        private System.Windows.Forms.Button ButtonEnable;
        private System.Windows.Forms.Label LabelActive;
        private System.Windows.Forms.Label LabelInactive;
    }
}