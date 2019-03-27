using ClassLibrary1;

namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblValA = new System.Windows.Forms.Label();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOperacion);
            this.groupBox1.Controls.Add(this.txtBoxA);
            this.groupBox1.Controls.Add(this.txtBoxB);
            this.groupBox1.Controls.Add(this.txtBoxResultado);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblValB);
            this.groupBox1.Controls.Add(this.lblValA);
            this.groupBox1.Controls.Add(this.buttonDiv);
            this.groupBox1.Controls.Add(this.buttonMult);
            this.groupBox1.Controls.Add(this.buttonResta);
            this.groupBox1.Controls.Add(this.buttonSuma);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(150, 105);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(95, 24);
            this.lblOperacion.TabIndex = 10;
            this.lblOperacion.Text = "operacion";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(65, 70);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 22);
            this.txtBoxA.TabIndex = 9;
            this.txtBoxA.Text = "5";
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(238, 70);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 22);
            this.txtBoxB.TabIndex = 8;
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(454, 120);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(100, 22);
            this.txtBoxResultado.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(449, 92);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(115, 25);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Resultado:";
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(235, 50);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(54, 17);
            this.lblValB.TabIndex = 5;
            this.lblValB.Text = "Valor B";
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(73, 50);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(54, 17);
            this.lblValA.TabIndex = 4;
            this.lblValA.Text = "Valor A";
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(266, 132);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(45, 23);
            this.buttonDiv.TabIndex = 3;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(201, 132);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(44, 23);
            this.buttonMult.TabIndex = 2;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Location = new System.Drawing.Point(143, 132);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(42, 23);
            this.buttonResta.TabIndex = 1;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.Location = new System.Drawing.Point(86, 132);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(41, 23);
            this.buttonSuma.TabIndex = 0;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 232);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonSuma;


    }



}

