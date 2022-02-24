﻿
namespace CoTuong
{
    partial class fBanCo
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
            this.undo = new System.Windows.Forms.PictureBox();
            this.NewGame = new System.Windows.Forms.Button();
            this.HienThiNuocDiDo = new System.Windows.Forms.TextBox();
            this.HienThiNuocDiDen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.undo)).BeginInit();
            this.SuspendLayout();
            // 
            // undo
            // 
            this.undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.undo.BackColor = System.Drawing.Color.Transparent;
            this.undo.Image = global::CoTuong.Properties.Resources.Undo1;
            this.undo.Location = new System.Drawing.Point(569, 37);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(48, 48);
            this.undo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.undo.TabIndex = 0;
            this.undo.TabStop = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // NewGame
            // 
            this.NewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewGame.AutoSize = true;
            this.NewGame.BackColor = System.Drawing.Color.SaddleBrown;
            this.NewGame.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewGame.Location = new System.Drawing.Point(660, 37);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(120, 48);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "NEWGAME";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // HienThiNuocDiDo
            // 
            this.HienThiNuocDiDo.Enabled = false;
            this.HienThiNuocDiDo.Location = new System.Drawing.Point(478, 394);
            this.HienThiNuocDiDo.Name = "HienThiNuocDiDo";
            this.HienThiNuocDiDo.Size = new System.Drawing.Size(130, 27);
            this.HienThiNuocDiDo.TabIndex = 2;
            // 
            // HienThiNuocDiDen
            // 
            this.HienThiNuocDiDen.Enabled = false;
            this.HienThiNuocDiDen.Location = new System.Drawing.Point(478, 188);
            this.HienThiNuocDiDen.Name = "HienThiNuocDiDen";
            this.HienThiNuocDiDen.Size = new System.Drawing.Size(130, 27);
            this.HienThiNuocDiDen.TabIndex = 2;
            // 
            // fBanCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::CoTuong.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(813, 569);
            this.Controls.Add(this.HienThiNuocDiDen);
            this.Controls.Add(this.HienThiNuocDiDo);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.undo);
            this.MaximizeBox = false;
            this.Name = "fBanCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoTuong";
            ((System.ComponentModel.ISupportInitialize)(this.undo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox undo;
        private System.Windows.Forms.Button NewGame;
        public System.Windows.Forms.TextBox HienThiNuocDiDo;
        public System.Windows.Forms.TextBox HienThiNuocDiDen;
    }
}
