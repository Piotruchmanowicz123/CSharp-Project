
namespace Click1
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
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Label();
            this.plus10 = new System.Windows.Forms.Button();
            this.min10 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.sqaure = new System.Windows.Forms.Button();
            this.sqroot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(134, 180);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(102, 33);
            this.BtnPlus.TabIndex = 0;
            this.BtnPlus.Text = "Plus";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Location = new System.Drawing.Point(364, 180);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(102, 33);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.Text = "Min";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(294, 268);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(0, 17);
            this.Counter.TabIndex = 2;
            // 
            // plus10
            // 
            this.plus10.Location = new System.Drawing.Point(134, 240);
            this.plus10.Name = "plus10";
            this.plus10.Size = new System.Drawing.Size(102, 33);
            this.plus10.TabIndex = 3;
            this.plus10.Text = "Plus 10";
            this.plus10.UseVisualStyleBackColor = true;
            this.plus10.Click += new System.EventHandler(this.plus10_Click);
            // 
            // min10
            // 
            this.min10.Location = new System.Drawing.Point(364, 240);
            this.min10.Name = "min10";
            this.min10.Size = new System.Drawing.Size(102, 33);
            this.min10.TabIndex = 4;
            this.min10.Text = "Min 10";
            this.min10.UseVisualStyleBackColor = true;
            this.min10.Click += new System.EventHandler(this.min10_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(261, 114);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(94, 34);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // sqaure
            // 
            this.sqaure.Location = new System.Drawing.Point(134, 295);
            this.sqaure.Name = "sqaure";
            this.sqaure.Size = new System.Drawing.Size(102, 30);
            this.sqaure.TabIndex = 7;
            this.sqaure.Text = "Sqaure";
            this.sqaure.UseVisualStyleBackColor = true;
            this.sqaure.Click += new System.EventHandler(this.sqaure_Click);
            // 
            // sqroot
            // 
            this.sqroot.Location = new System.Drawing.Point(364, 295);
            this.sqroot.Name = "sqroot";
            this.sqroot.Size = new System.Drawing.Size(102, 30);
            this.sqroot.TabIndex = 8;
            this.sqroot.Text = "SqaureRoot";
            this.sqroot.UseVisualStyleBackColor = true;
            this.sqroot.Click += new System.EventHandler(this.sqroot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sqroot);
            this.Controls.Add(this.sqaure);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.min10);
            this.Controls.Add(this.plus10);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button plus10;
        private System.Windows.Forms.Button min10;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button sqaure;
        private System.Windows.Forms.Button sqroot;
    }
}

