﻿namespace Sistema_de_Registro_de_almacen
{
    partial class Login
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14.25F);
            button1.Location = new Point(384, 324);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14.25F);
            textBox1.Location = new Point(343, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 29);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F);
            label1.Location = new Point(343, 162);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F);
            label2.Location = new Point(343, 239);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14.25F);
            textBox2.Location = new Point(343, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 29);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(384, 82);
            label3.Name = "label3";
            label3.Size = new Size(110, 40);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 405);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}
