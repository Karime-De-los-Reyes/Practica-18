﻿namespace Practica_18
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(-4, 9);
            label1.Name = "label1";
            label1.Size = new Size(736, 22);
            label1.TabIndex = 0;
            label1.Text = "Diagrama que pida los 3 lados de un triangulo y diga si es eqilatero, isocele o escaleno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 77);
            label2.Name = "label2";
            label2.Size = new Size(144, 22);
            label2.TabIndex = 1;
            label2.Text = "Longitud lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(37, 117);
            label3.Name = "label3";
            label3.Size = new Size(143, 22);
            label3.TabIndex = 2;
            label3.Text = "Longitud lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(38, 158);
            label4.Name = "label4";
            label4.Size = new Size(145, 22);
            label4.TabIndex = 3;
            label4.Text = "Longitud lado C";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(38, 235);
            label5.Name = "label5";
            label5.Size = new Size(155, 22);
            label5.TabIndex = 7;
            label5.Text = "Tipo de triangulo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(207, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(359, 111);
            button1.Name = "button1";
            button1.Size = new Size(93, 29);
            button1.TabIndex = 9;
            button1.Text = "Decisión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
    }
}