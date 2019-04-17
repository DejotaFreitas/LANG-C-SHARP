namespace NumerosAleatórios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.btnGeraNumeros = new System.Windows.Forms.Button();
            this.btnGerarNumerosComSeed = new System.Windows.Forms.Button();
            this.btnGerarNumerosDouble = new System.Windows.Forms.Button();
            this.btnGerarNumeroNextByte = new System.Windows.Forms.Button();
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.btnGerarNumerosNext2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(13, 13);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(320, 173);
            this.listaResultado.TabIndex = 0;
            // 
            // btnGeraNumeros
            // 
            this.btnGeraNumeros.Location = new System.Drawing.Point(13, 191);
            this.btnGeraNumeros.Name = "btnGeraNumeros";
            this.btnGeraNumeros.Size = new System.Drawing.Size(138, 38);
            this.btnGeraNumeros.TabIndex = 1;
            this.btnGeraNumeros.Text = "Gerar Números (Next)";
            this.btnGeraNumeros.UseVisualStyleBackColor = true;
            this.btnGeraNumeros.Click += new System.EventHandler(this.btnGeraNumeros_Click);
            // 
            // btnGerarNumerosComSeed
            // 
            this.btnGerarNumerosComSeed.Location = new System.Drawing.Point(179, 191);
            this.btnGerarNumerosComSeed.Name = "btnGerarNumerosComSeed";
            this.btnGerarNumerosComSeed.Size = new System.Drawing.Size(154, 38);
            this.btnGerarNumerosComSeed.TabIndex = 2;
            this.btnGerarNumerosComSeed.Text = "Gerando Números com Seed Next(inteiro)";
            this.btnGerarNumerosComSeed.UseVisualStyleBackColor = true;
            this.btnGerarNumerosComSeed.Click += new System.EventHandler(this.btnGerarNumerosComSeed_Click);
            // 
            // btnGerarNumerosDouble
            // 
            this.btnGerarNumerosDouble.Location = new System.Drawing.Point(13, 236);
            this.btnGerarNumerosDouble.Name = "btnGerarNumerosDouble";
            this.btnGerarNumerosDouble.Size = new System.Drawing.Size(138, 34);
            this.btnGerarNumerosDouble.TabIndex = 3;
            this.btnGerarNumerosDouble.Text = "Gerar Números (NextDouble)";
            this.btnGerarNumerosDouble.UseVisualStyleBackColor = true;
            this.btnGerarNumerosDouble.Click += new System.EventHandler(this.btnGerarNumerosDouble_Click);
            // 
            // btnGerarNumeroNextByte
            // 
            this.btnGerarNumeroNextByte.Location = new System.Drawing.Point(179, 236);
            this.btnGerarNumeroNextByte.Name = "btnGerarNumeroNextByte";
            this.btnGerarNumeroNextByte.Size = new System.Drawing.Size(154, 34);
            this.btnGerarNumeroNextByte.TabIndex = 4;
            this.btnGerarNumeroNextByte.Text = "Gerar Números (NextBytes)";
            this.btnGerarNumeroNextByte.UseVisualStyleBackColor = true;
            this.btnGerarNumeroNextByte.Click += new System.EventHandler(this.btnGerarNumeroNextByte_Click);
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.Location = new System.Drawing.Point(179, 277);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(154, 33);
            this.btnGerarSenha.TabIndex = 5;
            this.btnGerarSenha.Text = "Gerar Senha";
            this.btnGerarSenha.UseVisualStyleBackColor = true;
            this.btnGerarSenha.Click += new System.EventHandler(this.btnGerarSenha_Click);
            // 
            // btnGerarNumerosNext2
            // 
            this.btnGerarNumerosNext2.Location = new System.Drawing.Point(13, 277);
            this.btnGerarNumerosNext2.Name = "btnGerarNumerosNext2";
            this.btnGerarNumerosNext2.Size = new System.Drawing.Size(138, 32);
            this.btnGerarNumerosNext2.TabIndex = 6;
            this.btnGerarNumerosNext2.Text = "Gerar Numeros (Next(a,b)";
            this.btnGerarNumerosNext2.UseVisualStyleBackColor = true;
            this.btnGerarNumerosNext2.Click += new System.EventHandler(this.btnGerarNumerosNext2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 320);
            this.Controls.Add(this.btnGerarNumerosNext2);
            this.Controls.Add(this.btnGerarSenha);
            this.Controls.Add(this.btnGerarNumeroNextByte);
            this.Controls.Add(this.btnGerarNumerosDouble);
            this.Controls.Add(this.btnGerarNumerosComSeed);
            this.Controls.Add(this.btnGeraNumeros);
            this.Controls.Add(this.listaResultado);
            this.Name = "Form1";
            this.Text = "Números Aleatórios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button btnGeraNumeros;
        private System.Windows.Forms.Button btnGerarNumerosComSeed;
        private System.Windows.Forms.Button btnGerarNumerosDouble;
        private System.Windows.Forms.Button btnGerarNumeroNextByte;
        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.Button btnGerarNumerosNext2;
    }
}

