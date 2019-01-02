namespace WindowsFormsApplication1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Sumbutton3 = new System.Windows.Forms.Button();
            this.Minesbutton4 = new System.Windows.Forms.Button();
            this.Multiplictionbutton5 = new System.Windows.Forms.Button();
            this.Dividedbutton6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(115, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(115, 182);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // Sumbutton3
            // 
            this.Sumbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Sumbutton3.Location = new System.Drawing.Point(12, 101);
            this.Sumbutton3.Name = "Sumbutton3";
            this.Sumbutton3.Size = new System.Drawing.Size(75, 23);
            this.Sumbutton3.TabIndex = 8;
            this.Sumbutton3.Text = "+";
            this.Sumbutton3.UseVisualStyleBackColor = true;
            this.Sumbutton3.Click += new System.EventHandler(this.Sumbutton3_Click);
            // 
            // Minesbutton4
            // 
            this.Minesbutton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Minesbutton4.Location = new System.Drawing.Point(12, 128);
            this.Minesbutton4.Name = "Minesbutton4";
            this.Minesbutton4.Size = new System.Drawing.Size(75, 23);
            this.Minesbutton4.TabIndex = 9;
            this.Minesbutton4.Text = "-";
            this.Minesbutton4.UseVisualStyleBackColor = true;
            this.Minesbutton4.Click += new System.EventHandler(this.Minesbutton4_Click);
            // 
            // Multiplictionbutton5
            // 
            this.Multiplictionbutton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Multiplictionbutton5.Location = new System.Drawing.Point(12, 153);
            this.Multiplictionbutton5.Name = "Multiplictionbutton5";
            this.Multiplictionbutton5.Size = new System.Drawing.Size(75, 23);
            this.Multiplictionbutton5.TabIndex = 10;
            this.Multiplictionbutton5.Text = "*";
            this.Multiplictionbutton5.UseVisualStyleBackColor = true;
            this.Multiplictionbutton5.Click += new System.EventHandler(this.Multiplictionbutton5_Click);
            // 
            // Dividedbutton6
            // 
            this.Dividedbutton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Dividedbutton6.Location = new System.Drawing.Point(12, 179);
            this.Dividedbutton6.Name = "Dividedbutton6";
            this.Dividedbutton6.Size = new System.Drawing.Size(75, 23);
            this.Dividedbutton6.TabIndex = 11;
            this.Dividedbutton6.Text = "/";
            this.Dividedbutton6.UseVisualStyleBackColor = true;
            this.Dividedbutton6.Click += new System.EventHandler(this.Dividedbutton6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "num2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dividedbutton6);
            this.Controls.Add(this.Multiplictionbutton5);
            this.Controls.Add(this.Minesbutton4);
            this.Controls.Add(this.Sumbutton3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Sumbutton3;
        private System.Windows.Forms.Button Minesbutton4;
        private System.Windows.Forms.Button Multiplictionbutton5;
        private System.Windows.Forms.Button Dividedbutton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

