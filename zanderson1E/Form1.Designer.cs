
namespace zanderson1E
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTest1Amount = new System.Windows.Forms.TextBox();
            this.txtTest2Amount = new System.Windows.Forms.TextBox();
            this.txtTest3Amount = new System.Windows.Forms.TextBox();
            this.txtAverageTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average:";
            // 
            // txtTest1Amount
            // 
            this.txtTest1Amount.Location = new System.Drawing.Point(77, 18);
            this.txtTest1Amount.Name = "txtTest1Amount";
            this.txtTest1Amount.Size = new System.Drawing.Size(54, 20);
            this.txtTest1Amount.TabIndex = 0;
            this.txtTest1Amount.Text = "0";
            this.txtTest1Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest2Amount
            // 
            this.txtTest2Amount.Location = new System.Drawing.Point(77, 53);
            this.txtTest2Amount.Name = "txtTest2Amount";
            this.txtTest2Amount.Size = new System.Drawing.Size(54, 20);
            this.txtTest2Amount.TabIndex = 1;
            this.txtTest2Amount.Text = "0";
            this.txtTest2Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest3Amount
            // 
            this.txtTest3Amount.Location = new System.Drawing.Point(77, 87);
            this.txtTest3Amount.Name = "txtTest3Amount";
            this.txtTest3Amount.Size = new System.Drawing.Size(54, 20);
            this.txtTest3Amount.TabIndex = 2;
            this.txtTest3Amount.Text = "0";
            this.txtTest3Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAverageTotal
            // 
            this.txtAverageTotal.Location = new System.Drawing.Point(77, 116);
            this.txtAverageTotal.Name = "txtAverageTotal";
            this.txtAverageTotal.ReadOnly = true;
            this.txtAverageTotal.Size = new System.Drawing.Size(54, 20);
            this.txtAverageTotal.TabIndex = 10;
            this.txtAverageTotal.TabStop = false;
            this.txtAverageTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 161);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAverageTotal);
            this.Controls.Add(this.txtTest3Amount);
            this.Controls.Add(this.txtTest2Amount);
            this.Controls.Add(this.txtTest1Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTest1Amount;
        private System.Windows.Forms.TextBox txtTest2Amount;
        private System.Windows.Forms.TextBox txtTest3Amount;
        private System.Windows.Forms.TextBox txtAverageTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

