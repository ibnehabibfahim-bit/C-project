
namespace MovieR
{
    partial class MovieInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieInstructions));
            this.btnback = new System.Windows.Forms.Button();
            this.lblInst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.PaleGreen;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(230, 372);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(121, 46);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblInst
            // 
            this.lblInst.AutoSize = true;
            this.lblInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInst.Location = new System.Drawing.Point(66, 186);
            this.lblInst.Name = "lblInst";
            this.lblInst.Size = new System.Drawing.Size(423, 150);
            this.lblInst.TabIndex = 0;
            this.lblInst.Text = resources.GetString("lblInst.Text");
            this.lblInst.Click += new System.EventHandler(this.label1_Click);
            // 
            // MovieInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieR.Properties.Resources.Screenshot_2026_01_20_095446;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.lblInst);
            this.Controls.Add(this.btnback);
            this.DoubleBuffered = true;
            this.Name = "MovieInstructions";
            this.Text = "MovieInstructions";
            this.Load += new System.EventHandler(this.MovieInstructions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblInst;
    }
}