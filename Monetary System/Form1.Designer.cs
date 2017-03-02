namespace Monetary_System
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
            this.btnCoins = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCoins
            // 
            this.btnCoins.Location = new System.Drawing.Point(94, 111);
            this.btnCoins.Name = "btnCoins";
            this.btnCoins.Size = new System.Drawing.Size(75, 23);
            this.btnCoins.TabIndex = 0;
            this.btnCoins.Text = "Coins";
            this.btnCoins.UseVisualStyleBackColor = true;
            this.btnCoins.Click += new System.EventHandler(this.btnCoins_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(85, 63);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCoins);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCoins;
        private System.Windows.Forms.TextBox txtInput;
    }
}

