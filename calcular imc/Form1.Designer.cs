namespace calcular_imc
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
            altura = new TextBox();
            peso = new TextBox();
            IMC = new Button();
            imc1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 93);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "ALTURA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 140);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 1;
            label2.Text = "PESO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 9);
            label3.Name = "label3";
            label3.Size = new Size(275, 47);
            label3.TabIndex = 2;
            label3.Text = "CALCULAR IMC";
            label3.Click += label3_Click;
            // 
            // altura
            // 
            altura.Location = new Point(170, 102);
            altura.Name = "altura";
            altura.Size = new Size(249, 23);
            altura.TabIndex = 3;
            // 
            // peso
            // 
            peso.Location = new Point(164, 149);
            peso.Name = "peso";
            peso.Size = new Size(251, 23);
            peso.TabIndex = 4;
            // 
            // IMC
            // 
            IMC.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IMC.Location = new Point(164, 204);
            IMC.Name = "IMC";
            IMC.Size = new Size(255, 45);
            IMC.TabIndex = 5;
            IMC.Text = "IMC";
            IMC.UseVisualStyleBackColor = true;
            IMC.Click += IMC_Click;
            // 
            // imc1
            // 
            imc1.Location = new Point(164, 273);
            imc1.Name = "imc1";
            imc1.Size = new Size(257, 23);
            imc1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 264);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 7;
            label4.Text = "IMC:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(476, 373);
            Controls.Add(label4);
            Controls.Add(imc1);
            Controls.Add(IMC);
            Controls.Add(peso);
            Controls.Add(altura);
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
        private TextBox altura;
        private TextBox peso;
        private Button IMC;
        private TextBox imc1;
        private Label label4;
    }
}
