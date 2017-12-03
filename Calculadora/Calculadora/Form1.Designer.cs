namespace Calculadora
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
            this.components = new System.ComponentModel.Container();
            this.lbCalculo = new System.Windows.Forms.Label();
            this.tbCalculo = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCalculo
            // 
            this.lbCalculo.AutoSize = true;
            this.lbCalculo.Location = new System.Drawing.Point(12, 41);
            this.lbCalculo.Name = "lbCalculo";
            this.lbCalculo.Size = new System.Drawing.Size(0, 13);
            this.lbCalculo.TabIndex = 0;
            this.lbCalculo.Text = Linguagem.Calculo;
            // 
            // tbCalculo
            // 
            this.tbCalculo.Location = new System.Drawing.Point(86, 38);
            this.tbCalculo.Multiline = true;
            this.tbCalculo.Name = "tbCalculo";
            this.helpProvider1.SetShowHelp(this.tbCalculo, true);
            this.tbCalculo.Size = new System.Drawing.Size(311, 102);
            this.tbCalculo.TabIndex = 1;
            this.tbCalculo.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.tbCalculo_HelpRequested);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(249, 146);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(148, 22);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = Linguagem.Calcular;
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 190);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbCalculo);
            this.Controls.Add(this.lbCalculo);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = Linguagem.Calcular;
            this.helpProvider1.SetShowHelp(this, true);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCalculo;
        private System.Windows.Forms.TextBox tbCalculo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

