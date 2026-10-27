namespace calculadoraprogra
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            num1 = new Label();
            op = new Label();
            num2 = new Label();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            pj2 = new Label();
            errores1 = new Label();
            puntajej1 = new Label();
            errores2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 17);
            label1.Name = "label1";
            label1.Size = new Size(281, 39);
            label1.TabIndex = 0;
            label1.Text = "Juego De Aritmetica";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(num1);
            panel1.Controls.Add(op);
            panel1.Controls.Add(num2);
            panel1.Controls.Add(label7);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(35, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 283);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Desktop;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(213, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 39);
            textBox2.TabIndex = 8;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // num1
            // 
            num1.BackColor = SystemColors.Desktop;
            num1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1.ForeColor = SystemColors.ControlLightLight;
            num1.Location = new Point(14, 83);
            num1.Name = "num1";
            num1.Size = new Size(49, 32);
            num1.TabIndex = 7;
            // 
            // op
            // 
            op.BackColor = SystemColors.Desktop;
            op.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            op.ForeColor = SystemColors.ControlLightLight;
            op.Location = new Point(79, 83);
            op.Name = "op";
            op.Size = new Size(26, 32);
            op.TabIndex = 6;
            // 
            // num2
            // 
            num2.BackColor = SystemColors.Desktop;
            num2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2.ForeColor = SystemColors.ControlLightLight;
            num2.Location = new Point(122, 83);
            num2.Name = "num2";
            num2.Size = new Size(53, 32);
            num2.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Highlight;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(14, 11);
            label7.Name = "label7";
            label7.Size = new Size(332, 32);
            label7.TabIndex = 0;
            label7.Text = "Agregue El Resultado Operación";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ActiveCaptionText;
            radioButton1.ForeColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(501, 139);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "uno";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ActiveCaptionText;
            radioButton2.ForeColor = SystemColors.ControlLight;
            radioButton2.Location = new Point(501, 174);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "dos";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Desktop;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(238, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 35);
            textBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Desktop;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(501, 70);
            label5.Name = "label5";
            label5.Size = new Size(278, 34);
            label5.TabIndex = 8;
            label5.Text = "cantidad de jugadores ";
            // 
            // label9
            // 
            label9.BackColor = Color.Black;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(512, 217);
            label9.Name = "label9";
            label9.Size = new Size(35, 27);
            label9.TabIndex = 11;
            label9.Text = "j1:";
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(704, 220);
            label10.Name = "label10";
            label10.Size = new Size(40, 27);
            label10.TabIndex = 12;
            label10.Text = "j2:";
            // 
            // pj2
            // 
            pj2.AutoSize = true;
            pj2.BackColor = Color.Lime;
            pj2.BorderStyle = BorderStyle.Fixed3D;
            pj2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pj2.Location = new Point(696, 266);
            pj2.Name = "pj2";
            pj2.Size = new Size(87, 27);
            pj2.TabIndex = 16;
            pj2.Text = "puntaje:";
            // 
            // errores1
            // 
            errores1.AutoSize = true;
            errores1.BackColor = Color.Red;
            errores1.BorderStyle = BorderStyle.Fixed3D;
            errores1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errores1.ForeColor = SystemColors.ButtonHighlight;
            errores1.Location = new Point(501, 329);
            errores1.Name = "errores1";
            errores1.Size = new Size(78, 27);
            errores1.TabIndex = 17;
            errores1.Text = "errores";
            // 
            // puntajej1
            // 
            puntajej1.AutoSize = true;
            puntajej1.BackColor = Color.Lime;
            puntajej1.BorderStyle = BorderStyle.Fixed3D;
            puntajej1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            puntajej1.ForeColor = SystemColors.ButtonHighlight;
            puntajej1.Location = new Point(501, 266);
            puntajej1.Name = "puntajej1";
            puntajej1.Size = new Size(87, 27);
            puntajej1.TabIndex = 18;
            puntajej1.Text = "puntaje:";
            // 
            // errores2
            // 
            errores2.AutoSize = true;
            errores2.BackColor = Color.Red;
            errores2.BorderStyle = BorderStyle.Fixed3D;
            errores2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errores2.ForeColor = SystemColors.ButtonHighlight;
            errores2.Location = new Point(696, 329);
            errores2.Name = "errores2";
            errores2.Size = new Size(83, 27);
            errores2.TabIndex = 19;
            errores2.Text = "errores:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 516);
            Controls.Add(errores2);
            Controls.Add(puntajej1);
            Controls.Add(errores1);
            Controls.Add(pj2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            //Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label pj2;
        private TextBox textBox2;
        private Label num1;
        private Label op;
        private Label num2;
        private Label errores1;
        private Label puntajej1;
        private Label errores2;
    }
}
