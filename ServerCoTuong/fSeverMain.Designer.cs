﻿namespace ServerCoTuong
{
    partial class fSeverMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btStarServer = new System.Windows.Forms.Button();
            this.txtTerminal = new System.Windows.Forms.RichTextBox();
            this.btCloseServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStarServer
            // 
            this.btStarServer.BackgroundImage = global::ServerCoTuong.Properties.Resources.YelloLable;
            this.btStarServer.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btStarServer.Location = new System.Drawing.Point(76, 553);
            this.btStarServer.Name = "btStarServer";
            this.btStarServer.Size = new System.Drawing.Size(305, 69);
            this.btStarServer.TabIndex = 1;
            this.btStarServer.Text = "Start Server";
            this.btStarServer.UseVisualStyleBackColor = true;
            this.btStarServer.Click += new System.EventHandler(this.btStarServer_Click);
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(76, 45);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(770, 476);
            this.txtTerminal.TabIndex = 2;
            this.txtTerminal.Text = "";
            // 
            // btCloseServer
            // 
            this.btCloseServer.BackgroundImage = global::ServerCoTuong.Properties.Resources.YelloLable;
            this.btCloseServer.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCloseServer.Location = new System.Drawing.Point(575, 553);
            this.btCloseServer.Name = "btCloseServer";
            this.btCloseServer.Size = new System.Drawing.Size(272, 69);
            this.btCloseServer.TabIndex = 3;
            this.btCloseServer.Text = "Close Server";
            this.btCloseServer.UseVisualStyleBackColor = true;
            this.btCloseServer.Click += new System.EventHandler(this.btCloseServer_Click);
            // 
            // fSeverMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServerCoTuong.Properties.Resources.Server;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 661);
            this.Controls.Add(this.btCloseServer);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.btStarServer);
            this.DoubleBuffered = true;
            this.Name = "fSeverMain";
            this.Text = "Sever cờ tướng";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btStarServer;
        private RichTextBox txtTerminal;
        private Button btCloseServer;
    }
}