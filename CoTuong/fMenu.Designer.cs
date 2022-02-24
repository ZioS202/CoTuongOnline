﻿
namespace CoTuong
{
    partial class fMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitGame = new System.Windows.Forms.Button();
            this.PlayGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ExitGame);
            this.panel1.Controls.Add(this.PlayGame);
            this.panel1.Location = new System.Drawing.Point(189, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 178);
            this.panel1.TabIndex = 0;
            // 
            // ExitGame
            // 
            this.ExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitGame.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitGame.Location = new System.Drawing.Point(65, 121);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(200, 51);
            this.ExitGame.TabIndex = 1;
            this.ExitGame.Text = "EXIT";
            this.ExitGame.UseVisualStyleBackColor = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // PlayGame
            // 
            this.PlayGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayGame.BackColor = System.Drawing.Color.Red;
            this.PlayGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayGame.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayGame.Location = new System.Drawing.Point(65, 12);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(200, 92);
            this.PlayGame.TabIndex = 0;
            this.PlayGame.Text = "PLAY";
            this.PlayGame.UseVisualStyleBackColor = false;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // fMenu
            // 
            this.AccessibleName = "Co Tuong";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoTuong.Properties.Resources.menu;
            this.ClientSize = new System.Drawing.Size(700, 589);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Game Cờ Tướng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMenu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.Button PlayGame;
    }
}