namespace BrewingLog
{
    partial class HomeForm
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
            this.ldBrewBtn = new System.Windows.Forms.Button();
            this.nBrewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ldBrewBtn
            // 
            this.ldBrewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ldBrewBtn.Location = new System.Drawing.Point(95, 127);
            this.ldBrewBtn.Name = "ldBrewBtn";
            this.ldBrewBtn.Size = new System.Drawing.Size(102, 33);
            this.ldBrewBtn.TabIndex = 1;
            this.ldBrewBtn.Text = "Load Brew";
            this.ldBrewBtn.UseVisualStyleBackColor = true;
            this.ldBrewBtn.Click += new System.EventHandler(this.ldBrewBtn_Click);
            // 
            // nBrewBtn
            // 
            this.nBrewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nBrewBtn.Location = new System.Drawing.Point(95, 23);
            this.nBrewBtn.Name = "nBrewBtn";
            this.nBrewBtn.Size = new System.Drawing.Size(102, 33);
            this.nBrewBtn.TabIndex = 0;
            this.nBrewBtn.Text = "New Brew";
            this.nBrewBtn.UseVisualStyleBackColor = true;
            this.nBrewBtn.Click += new System.EventHandler(this.nBrewBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.ldBrewBtn);
            this.Controls.Add(this.nBrewBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 226);
            this.MinimumSize = new System.Drawing.Size(300, 226);
            this.Name = "HomeForm";
            this.Text = "Brewing Log Home";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ldBrewBtn;
        private System.Windows.Forms.Button nBrewBtn;
    }
}

