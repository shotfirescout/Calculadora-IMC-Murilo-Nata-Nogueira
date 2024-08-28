namespace Calculadora_IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.resultadoImcText = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoCondicao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura(m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso(Kg)";
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(165, 29);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(100, 22);
            this.textAltura.TabIndex = 2;
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(165, 72);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(100, 22);
            this.textPeso.TabIndex = 3;
            // 
            // resultadoImcText
            // 
            this.resultadoImcText.AutoSize = true;
            this.resultadoImcText.Location = new System.Drawing.Point(116, 186);
            this.resultadoImcText.Name = "resultadoImcText";
            this.resultadoImcText.Size = new System.Drawing.Size(31, 16);
            this.resultadoImcText.TabIndex = 4;
            this.resultadoImcText.Text = "0,00";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(122, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Efetuar Calculo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor do IMC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Condição:";
            // 
            // resultadoCondicao
            // 
            this.resultadoCondicao.AutoSize = true;
            this.resultadoCondicao.Location = new System.Drawing.Point(86, 230);
            this.resultadoCondicao.Name = "resultadoCondicao";
            this.resultadoCondicao.Size = new System.Drawing.Size(0, 16);
            this.resultadoCondicao.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(215, 200);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 57);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 285);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultadoCondicao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.resultadoImcText);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.Label resultadoImcText;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultadoCondicao;
        private System.Windows.Forms.Button btnLimpar;
    }
}

