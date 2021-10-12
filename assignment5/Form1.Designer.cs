
namespace assignment5
{
    partial class Form1
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
            this.Number1StaticLbl = new System.Windows.Forms.Label();
            this.Number2StaticLbl = new System.Windows.Forms.Label();
            this.ResultStaticLbl = new System.Windows.Forms.Label();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.KeerBtn = new System.Windows.Forms.Button();
            this.DelenBtn = new System.Windows.Forms.Button();
            this.Number1InputTxt = new System.Windows.Forms.TextBox();
            this.Number2InputTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Number1StaticLbl
            // 
            this.Number1StaticLbl.AutoSize = true;
            this.Number1StaticLbl.Location = new System.Drawing.Point(28, 25);
            this.Number1StaticLbl.Name = "Number1StaticLbl";
            this.Number1StaticLbl.Size = new System.Drawing.Size(92, 25);
            this.Number1StaticLbl.TabIndex = 0;
            this.Number1StaticLbl.Text = "Number 1";
            // 
            // Number2StaticLbl
            // 
            this.Number2StaticLbl.AutoSize = true;
            this.Number2StaticLbl.Location = new System.Drawing.Point(28, 72);
            this.Number2StaticLbl.Name = "Number2StaticLbl";
            this.Number2StaticLbl.Size = new System.Drawing.Size(92, 25);
            this.Number2StaticLbl.TabIndex = 1;
            this.Number2StaticLbl.Text = "Number 2";
            // 
            // ResultStaticLbl
            // 
            this.ResultStaticLbl.AutoSize = true;
            this.ResultStaticLbl.Location = new System.Drawing.Point(28, 294);
            this.ResultStaticLbl.Name = "ResultStaticLbl";
            this.ResultStaticLbl.Size = new System.Drawing.Size(59, 25);
            this.ResultStaticLbl.TabIndex = 2;
            this.ResultStaticLbl.Text = "Result";
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(277, 294);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(17, 25);
            this.ResultLbl.TabIndex = 3;
            this.ResultLbl.Text = " ";
            this.ResultLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(28, 180);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(92, 84);
            this.PlusBtn.TabIndex = 4;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Location = new System.Drawing.Point(137, 180);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(92, 84);
            this.MinBtn.TabIndex = 5;
            this.MinBtn.Text = "-";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // KeerBtn
            // 
            this.KeerBtn.Location = new System.Drawing.Point(249, 180);
            this.KeerBtn.Name = "KeerBtn";
            this.KeerBtn.Size = new System.Drawing.Size(84, 84);
            this.KeerBtn.TabIndex = 6;
            this.KeerBtn.Text = "X";
            this.KeerBtn.UseVisualStyleBackColor = true;
            this.KeerBtn.Click += new System.EventHandler(this.KeerBtn_Click);
            // 
            // DelenBtn
            // 
            this.DelenBtn.Location = new System.Drawing.Point(356, 180);
            this.DelenBtn.Name = "DelenBtn";
            this.DelenBtn.Size = new System.Drawing.Size(95, 84);
            this.DelenBtn.TabIndex = 7;
            this.DelenBtn.Text = ":";
            this.DelenBtn.UseVisualStyleBackColor = true;
            this.DelenBtn.Click += new System.EventHandler(this.DelenBtn_Click);
            // 
            // Number1InputTxt
            // 
            this.Number1InputTxt.Location = new System.Drawing.Point(249, 25);
            this.Number1InputTxt.Name = "Number1InputTxt";
            this.Number1InputTxt.Size = new System.Drawing.Size(150, 31);
            this.Number1InputTxt.TabIndex = 8;
            // 
            // Number2InputTxt
            // 
            this.Number2InputTxt.Location = new System.Drawing.Point(249, 72);
            this.Number2InputTxt.Name = "Number2InputTxt";
            this.Number2InputTxt.Size = new System.Drawing.Size(150, 31);
            this.Number2InputTxt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 343);
            this.Controls.Add(this.Number2InputTxt);
            this.Controls.Add(this.Number1InputTxt);
            this.Controls.Add(this.DelenBtn);
            this.Controls.Add(this.KeerBtn);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.ResultStaticLbl);
            this.Controls.Add(this.Number2StaticLbl);
            this.Controls.Add(this.Number1StaticLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1StaticLbl;
        private System.Windows.Forms.Label Number2StaticLbl;
        private System.Windows.Forms.Label ResultStaticLbl;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button KeerBtn;
        private System.Windows.Forms.Button DelenBtn;
        private System.Windows.Forms.TextBox Number1InputTxt;
        private System.Windows.Forms.TextBox Number2InputTxt;
    }
}

