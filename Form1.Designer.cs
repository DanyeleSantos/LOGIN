
namespace Aula03Login
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
            this.Lblusuario = new System.Windows.Forms.Label();
            this.Lblsenha = new System.Windows.Forms.Label();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtsenha = new System.Windows.Forms.TextBox();
            this.Btnconectar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lblusuario
            // 
            this.Lblusuario.AutoSize = true;
            this.Lblusuario.Location = new System.Drawing.Point(187, 102);
            this.Lblusuario.Name = "Lblusuario";
            this.Lblusuario.Size = new System.Drawing.Size(94, 13);
            this.Lblusuario.TabIndex = 0;
            this.Lblusuario.Text = "Digite seu usuário:";
            this.Lblusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblsenha
            // 
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.Location = new System.Drawing.Point(187, 175);
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(89, 13);
            this.Lblsenha.TabIndex = 1;
            this.Lblsenha.Text = "Digite sua senha:";
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(190, 135);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(155, 20);
            this.Txtusuario.TabIndex = 4;
            // 
            // Txtsenha
            // 
            this.Txtsenha.Location = new System.Drawing.Point(190, 208);
            this.Txtsenha.Name = "Txtsenha";
            this.Txtsenha.PasswordChar = '$';
            this.Txtsenha.Size = new System.Drawing.Size(155, 20);
            this.Txtsenha.TabIndex = 5;
            // 
            // Btnconectar
            // 
            this.Btnconectar.Location = new System.Drawing.Point(190, 249);
            this.Btnconectar.Name = "Btnconectar";
            this.Btnconectar.Size = new System.Drawing.Size(161, 30);
            this.Btnconectar.TabIndex = 6;
            this.Btnconectar.Text = "Conectar";
            this.Btnconectar.UseVisualStyleBackColor = true;
            this.Btnconectar.Click += new System.EventHandler(this.Btnconectar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(496, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 161);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "seu saldo R$ 0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(16, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btnconectar);
            this.Controls.Add(this.Txtsenha);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Lblsenha);
            this.Controls.Add(this.Lblusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblusuario;
        private System.Windows.Forms.Label Lblsenha;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.TextBox Txtsenha;
        private System.Windows.Forms.Button Btnconectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

