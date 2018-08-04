namespace Brainfuck_Interpreter
{
    partial class frmAbout
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.linkYouTube = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coded with ❤ and ☕ by Arcanecfg";
            // 
            // linkWebsite
            // 
            this.linkWebsite.AutoSize = true;
            this.linkWebsite.Location = new System.Drawing.Point(12, 89);
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.Size = new System.Drawing.Size(89, 13);
            this.linkWebsite.TabIndex = 1;
            this.linkWebsite.TabStop = true;
            this.linkWebsite.Text = "WastedWolf.com";
            this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(147, 89);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkGitHub.TabIndex = 2;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "GitHub";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // linkYouTube
            // 
            this.linkYouTube.AutoSize = true;
            this.linkYouTube.Location = new System.Drawing.Point(271, 89);
            this.linkYouTube.Name = "linkYouTube";
            this.linkYouTube.Size = new System.Drawing.Size(51, 13);
            this.linkYouTube.TabIndex = 3;
            this.linkYouTube.TabStop = true;
            this.linkYouTube.Text = "YouTube";
            this.linkYouTube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYouTube_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.linkYouTube);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.linkWebsite);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Brainfuck Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.LinkLabel linkYouTube;
    }
}