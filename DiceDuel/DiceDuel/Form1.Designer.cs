
namespace DiceDuel
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(322, 130);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PicBox1
            // 
            this.PicBox1.Location = new System.Drawing.Point(122, 130);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(137, 89);
            this.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBox1.TabIndex = 1;
            this.PicBox1.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(322, 196);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // PicBox2
            // 
            this.PicBox2.Location = new System.Drawing.Point(475, 130);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(121, 89);
            this.PicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBox2.TabIndex = 4;
            this.PicBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 1";
            // 
            // LbWinner
            // 
            this.LbWinner.AutoSize = true;
            this.LbWinner.Location = new System.Drawing.Point(335, 166);
            this.LbWinner.Name = "LbWinner";
            this.LbWinner.Size = new System.Drawing.Size(0, 17);
            this.LbWinner.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 490);
            this.Controls.Add(this.LbWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.PicBox1);
            this.Controls.Add(this.BtnStart);
            this.Name = "Form1";
            this.Text = "Dice Battle";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.PictureBox PicBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbWinner;
    }
}

