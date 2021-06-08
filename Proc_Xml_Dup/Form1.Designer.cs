namespace Proc_Xml_Dup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.Txt_Arq = new System.Windows.Forms.TextBox();
            this.Txt_Caminho = new System.Windows.Forms.TextBox();
            this.Txt_Arq_dup = new System.Windows.Forms.TextBox();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.Lbl_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.Location = new System.Drawing.Point(12, 24);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Iniciar.TabIndex = 0;
            this.Btn_Iniciar.Text = "Pesquisar";
            this.Btn_Iniciar.UseVisualStyleBackColor = true;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // Txt_Arq
            // 
            this.Txt_Arq.Location = new System.Drawing.Point(12, 107);
            this.Txt_Arq.Multiline = true;
            this.Txt_Arq.Name = "Txt_Arq";
            this.Txt_Arq.Size = new System.Drawing.Size(386, 321);
            this.Txt_Arq.TabIndex = 1;
            // 
            // Txt_Caminho
            // 
            this.Txt_Caminho.Location = new System.Drawing.Point(12, 64);
            this.Txt_Caminho.Name = "Txt_Caminho";
            this.Txt_Caminho.Size = new System.Drawing.Size(349, 20);
            this.Txt_Caminho.TabIndex = 2;
            // 
            // Txt_Arq_dup
            // 
            this.Txt_Arq_dup.Location = new System.Drawing.Point(404, 107);
            this.Txt_Arq_dup.Multiline = true;
            this.Txt_Arq_dup.Name = "Txt_Arq_dup";
            this.Txt_Arq_dup.Size = new System.Drawing.Size(534, 321);
            this.Txt_Arq_dup.TabIndex = 3;
            // 
            // Lbl_1
            // 
            this.Lbl_1.AutoSize = true;
            this.Lbl_1.Location = new System.Drawing.Point(16, 91);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(88, 13);
            this.Lbl_1.TabIndex = 4;
            this.Lbl_1.Text = "Lista de Arquivos";
            // 
            // Lbl_2
            // 
            this.Lbl_2.AutoSize = true;
            this.Lbl_2.Location = new System.Drawing.Point(401, 91);
            this.Lbl_2.Name = "Lbl_2";
            this.Lbl_2.Size = new System.Drawing.Size(100, 13);
            this.Lbl_2.TabIndex = 5;
            this.Lbl_2.Text = "Lista de Duplicados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.Lbl_2);
            this.Controls.Add(this.Lbl_1);
            this.Controls.Add(this.Txt_Arq_dup);
            this.Controls.Add(this.Txt_Caminho);
            this.Controls.Add(this.Txt_Arq);
            this.Controls.Add(this.Btn_Iniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Procura XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.TextBox Txt_Arq;
        private System.Windows.Forms.TextBox Txt_Caminho;
        private System.Windows.Forms.TextBox Txt_Arq_dup;
        private System.Windows.Forms.Label Lbl_1;
        private System.Windows.Forms.Label Lbl_2;
    }
}

