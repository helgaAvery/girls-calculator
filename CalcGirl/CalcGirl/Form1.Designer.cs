namespace CalcGirl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.multyply = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sqrt);
            this.panel1.Controls.Add(this.Tan);
            this.panel1.Controls.Add(this.Cos);
            this.panel1.Controls.Add(this.Sin);
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.multyply);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 259);
            this.panel1.TabIndex = 0;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(159, 108);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(37, 40);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Calculate);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(109, 108);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(37, 38);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Calculate);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 13;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(64, 108);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(39, 40);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Calculate);
            // 
            // multyply
            // 
            this.multyply.Location = new System.Drawing.Point(15, 108);
            this.multyply.Name = "multyply";
            this.multyply.Size = new System.Drawing.Size(43, 39);
            this.multyply.TabIndex = 11;
            this.multyply.Text = "*";
            this.multyply.UseVisualStyleBackColor = true;
            this.multyply.Click += new System.EventHandler(this.Calculate);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(15, 153);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(88, 42);
            this.Sin.TabIndex = 18;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(109, 152);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(88, 42);
            this.Cos.TabIndex = 19;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(15, 201);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(88, 42);
            this.Tan.TabIndex = 20;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(108, 200);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(88, 42);
            this.Sqrt.TabIndex = 21;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 281);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multyply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sin;
    }
}

