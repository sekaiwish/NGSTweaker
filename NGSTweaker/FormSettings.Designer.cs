
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
            this.BinLabel = new System.Windows.Forms.Label();
            this.BinText = new System.Windows.Forms.TextBox();
            this.BinButton = new System.Windows.Forms.Button();
            this.NumericRendering = new System.Windows.Forms.NumericUpDown();
            this.LabelRendering = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ComboFiltering = new System.Windows.Forms.ComboBox();
            this.LabelFiltering = new System.Windows.Forms.Label();
            this.LabelResolution = new System.Windows.Forms.Label();
            this.ComboResolution = new System.Windows.Forms.ComboBox();
            this.LabelFramerate = new System.Windows.Forms.Label();
            this.ComboFramerate = new System.Windows.Forms.ComboBox();
            this.LabelSize = new System.Windows.Forms.Label();
            this.ComboSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRendering)).BeginInit();
            this.SuspendLayout();
            // 
            // BinLabel
            // 
            this.BinLabel.AutoSize = true;
            this.BinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinLabel.Location = new System.Drawing.Point(12, 9);
            this.BinLabel.Name = "BinLabel";
            this.BinLabel.Size = new System.Drawing.Size(81, 17);
            this.BinLabel.TabIndex = 0;
            this.BinLabel.Text = "Binary Path";
            // 
            // BinText
            // 
            this.BinText.Location = new System.Drawing.Point(99, 9);
            this.BinText.Name = "BinText";
            this.BinText.ReadOnly = true;
            this.BinText.Size = new System.Drawing.Size(284, 20);
            this.BinText.TabIndex = 1;
            // 
            // BinButton
            // 
            this.BinButton.Location = new System.Drawing.Point(389, 9);
            this.BinButton.Name = "BinButton";
            this.BinButton.Size = new System.Drawing.Size(63, 20);
            this.BinButton.TabIndex = 2;
            this.BinButton.Text = "Choose...";
            this.BinButton.UseVisualStyleBackColor = true;
            this.BinButton.Click += new System.EventHandler(this.BinButton_Click);
            // 
            // NumericRendering
            // 
            this.NumericRendering.Location = new System.Drawing.Point(15, 38);
            this.NumericRendering.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericRendering.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericRendering.Name = "NumericRendering";
            this.NumericRendering.Size = new System.Drawing.Size(35, 20);
            this.NumericRendering.TabIndex = 4;
            this.NumericRendering.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelRendering
            // 
            this.LabelRendering.AutoSize = true;
            this.LabelRendering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRendering.Location = new System.Drawing.Point(56, 38);
            this.LabelRendering.Name = "LabelRendering";
            this.LabelRendering.Size = new System.Drawing.Size(112, 17);
            this.LabelRendering.TabIndex = 5;
            this.LabelRendering.Text = "Rendering Level";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Disable Smut Filter",
            "Disable Lobby Videos",
            "Disable UI"});
            this.checkedListBox1.Location = new System.Drawing.Point(282, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(170, 58);
            this.checkedListBox1.TabIndex = 6;
            // 
            // ComboFiltering
            // 
            this.ComboFiltering.FormattingEnabled = true;
            this.ComboFiltering.Items.AddRange(new object[] {
            "Bilinear",
            "Trilinear",
            "4x",
            "8x",
            "16x"});
            this.ComboFiltering.Location = new System.Drawing.Point(15, 64);
            this.ComboFiltering.Name = "ComboFiltering";
            this.ComboFiltering.Size = new System.Drawing.Size(89, 21);
            this.ComboFiltering.TabIndex = 7;
            // 
            // LabelFiltering
            // 
            this.LabelFiltering.AutoSize = true;
            this.LabelFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltering.Location = new System.Drawing.Point(110, 65);
            this.LabelFiltering.Name = "LabelFiltering";
            this.LabelFiltering.Size = new System.Drawing.Size(110, 17);
            this.LabelFiltering.TabIndex = 8;
            this.LabelFiltering.Text = "Texture Filtering";
            // 
            // LabelResolution
            // 
            this.LabelResolution.AutoSize = true;
            this.LabelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResolution.Location = new System.Drawing.Point(110, 92);
            this.LabelResolution.Name = "LabelResolution";
            this.LabelResolution.Size = new System.Drawing.Size(127, 17);
            this.LabelResolution.TabIndex = 10;
            this.LabelResolution.Text = "Texture Resolution";
            // 
            // ComboResolution
            // 
            this.ComboResolution.FormattingEnabled = true;
            this.ComboResolution.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Maximum"});
            this.ComboResolution.Location = new System.Drawing.Point(15, 91);
            this.ComboResolution.Name = "ComboResolution";
            this.ComboResolution.Size = new System.Drawing.Size(89, 21);
            this.ComboResolution.TabIndex = 9;
            // 
            // LabelFramerate
            // 
            this.LabelFramerate.AutoSize = true;
            this.LabelFramerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFramerate.Location = new System.Drawing.Point(110, 119);
            this.LabelFramerate.Name = "LabelFramerate";
            this.LabelFramerate.Size = new System.Drawing.Size(135, 17);
            this.LabelFramerate.TabIndex = 12;
            this.LabelFramerate.Text = "Maximum Framerate";
            // 
            // ComboFramerate
            // 
            this.ComboFramerate.FormattingEnabled = true;
            this.ComboFramerate.Items.AddRange(new object[] {
            "Unlimited",
            "30 FPS",
            "60 FPS",
            "90 FPS",
            "120 FPS",
            "144 FPS",
            "165 FPS"});
            this.ComboFramerate.Location = new System.Drawing.Point(15, 118);
            this.ComboFramerate.Name = "ComboFramerate";
            this.ComboFramerate.Size = new System.Drawing.Size(89, 21);
            this.ComboFramerate.TabIndex = 11;
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSize.Location = new System.Drawing.Point(110, 146);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(66, 17);
            this.LabelSize.TabIndex = 14;
            this.LabelSize.Text = "Text Size";
            // 
            // ComboSize
            // 
            this.ComboSize.FormattingEnabled = true;
            this.ComboSize.Items.AddRange(new object[] {
            "0.4x (640p)",
            "0.6x (854p)",
            "0.8x (1024p)",
            "1.0x (1280p)",
            "1.1x (1366p)",
            "1.2x (1600p)",
            "1.4x (1920p)",
            "1.8x (2560p)",
            "2.2x (3840p)"});
            this.ComboSize.Location = new System.Drawing.Point(15, 145);
            this.ComboSize.Name = "ComboSize";
            this.ComboSize.Size = new System.Drawing.Size(89, 21);
            this.ComboSize.TabIndex = 13;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.ComboSize);
            this.Controls.Add(this.LabelFramerate);
            this.Controls.Add(this.ComboFramerate);
            this.Controls.Add(this.LabelResolution);
            this.Controls.Add(this.ComboResolution);
            this.Controls.Add(this.LabelFiltering);
            this.Controls.Add(this.ComboFiltering);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LabelRendering);
            this.Controls.Add(this.NumericRendering);
            this.Controls.Add(this.BinButton);
            this.Controls.Add(this.BinText);
            this.Controls.Add(this.BinLabel);
            this.Icon = global::NGSTweaker.Properties.Resources.IconNGS;
            this.Name = "FormSettings";
            this.Text = "Tweaker Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericRendering)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BinLabel;
        private System.Windows.Forms.TextBox BinText;
        private System.Windows.Forms.Button BinButton;
        private System.Windows.Forms.NumericUpDown NumericRendering;
        private System.Windows.Forms.Label LabelRendering;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox ComboFiltering;
        private System.Windows.Forms.Label LabelFiltering;
        private System.Windows.Forms.Label LabelResolution;
        private System.Windows.Forms.ComboBox ComboResolution;
        private System.Windows.Forms.Label LabelFramerate;
        private System.Windows.Forms.ComboBox ComboFramerate;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.ComboBox ComboSize;
    }
}