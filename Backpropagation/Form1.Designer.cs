namespace Backpropagation
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            epochTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(153, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 61);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(153, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 61);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(153, 327);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 61);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(195, 526);
            button1.Name = "button1";
            button1.Size = new Size(144, 68);
            button1.TabIndex = 3;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(472, 526);
            button2.Name = "button2";
            button2.Size = new Size(144, 68);
            button2.TabIndex = 4;
            button2.Text = "Train";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(752, 526);
            button3.Name = "button3";
            button3.Size = new Size(144, 68);
            button3.TabIndex = 5;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(153, 425);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 61);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(563, 233);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(509, 61);
            textBox5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 84);
            label1.Name = "label1";
            label1.Size = new Size(179, 31);
            label1.TabIndex = 8;
            label1.Text = "AND OPERATOR";
            // 
            // button4
            // 
            button4.Location = new Point(121, 636);
            button4.Name = "button4";
            button4.Size = new Size(144, 68);
            button4.TabIndex = 9;
            button4.Text = "Estimate Error";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(353, 636);
            button5.Name = "button5";
            button5.Size = new Size(144, 68);
            button5.TabIndex = 10;
            button5.Text = "Find Min Epoch";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // epochTextBox
            // 
            epochTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            epochTextBox.Location = new Point(579, 653);
            epochTextBox.Name = "epochTextBox";
            epochTextBox.Size = new Size(449, 61);
            epochTextBox.TabIndex = 11;
            epochTextBox.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(692, 609);
            label2.Name = "label2";
            label2.Size = new Size(232, 31);
            label2.TabIndex = 12;
            label2.Text = "TRAIN EPOCHS DATA:";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 748);
            Controls.Add(label2);
            Controls.Add(epochTextBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Button button4;
        private Button button5;
        private TextBox epochTextBox;
        private Label label2;
    }
}
