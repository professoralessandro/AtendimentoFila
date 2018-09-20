namespace TPAtendimentoFila
{
    partial class FormProjetoAtendimento
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
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.labelQuantidadeGuiches = new System.Windows.Forms.Label();
            this.listBoxAtendimento = new System.Windows.Forms.ListBox();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelNumGuiches = new System.Windows.Forms.Label();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.buttonListarAtendimentos = new System.Windows.Forms.Button();
            this.labelGuiche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.ItemHeight = 16;
            this.listBoxSenhas.Location = new System.Drawing.Point(46, 78);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(372, 340);
            this.listBoxSenhas.TabIndex = 0;
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(118, 31);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(121, 32);
            this.buttonGerar.TabIndex = 1;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Location = new System.Drawing.Point(703, 36);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(100, 22);
            this.textBoxGuiche.TabIndex = 7;
            // 
            // labelQuantidadeGuiches
            // 
            this.labelQuantidadeGuiches.AutoSize = true;
            this.labelQuantidadeGuiches.Location = new System.Drawing.Point(489, 177);
            this.labelQuantidadeGuiches.Name = "labelQuantidadeGuiches";
            this.labelQuantidadeGuiches.Size = new System.Drawing.Size(95, 17);
            this.labelQuantidadeGuiches.TabIndex = 3;
            this.labelQuantidadeGuiches.Text = "Qtde Guiches";
            // 
            // listBoxAtendimento
            // 
            this.listBoxAtendimento.FormattingEnabled = true;
            this.listBoxAtendimento.ItemHeight = 16;
            this.listBoxAtendimento.Location = new System.Drawing.Point(643, 78);
            this.listBoxAtendimento.Name = "listBoxAtendimento";
            this.listBoxAtendimento.Size = new System.Drawing.Size(561, 340);
            this.listBoxAtendimento.TabIndex = 9;
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Location = new System.Drawing.Point(118, 439);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(164, 32);
            this.buttonListarSenhas.TabIndex = 2;
            this.buttonListarSenhas.Text = "Listar Senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.buttonListarSenhas_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(456, 282);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(158, 40);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelNumGuiches
            // 
            this.labelNumGuiches.AutoSize = true;
            this.labelNumGuiches.Location = new System.Drawing.Point(522, 233);
            this.labelNumGuiches.Name = "labelNumGuiches";
            this.labelNumGuiches.Size = new System.Drawing.Size(16, 17);
            this.labelNumGuiches.TabIndex = 4;
            this.labelNumGuiches.Text = "0";
            this.labelNumGuiches.Click += new System.EventHandler(this.labelNumGuiches_Click);
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(864, 36);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(117, 23);
            this.buttonChamar.TabIndex = 8;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // buttonListarAtendimentos
            // 
            this.buttonListarAtendimentos.Location = new System.Drawing.Point(703, 439);
            this.buttonListarAtendimentos.Name = "buttonListarAtendimentos";
            this.buttonListarAtendimentos.Size = new System.Drawing.Size(282, 32);
            this.buttonListarAtendimentos.TabIndex = 10;
            this.buttonListarAtendimentos.Text = "Listar Atendimentos";
            this.buttonListarAtendimentos.UseVisualStyleBackColor = true;
            this.buttonListarAtendimentos.Click += new System.EventHandler(this.buttonListarAtendimentos_Click);
            // 
            // labelGuiche
            // 
            this.labelGuiche.AutoSize = true;
            this.labelGuiche.Location = new System.Drawing.Point(640, 39);
            this.labelGuiche.Name = "labelGuiche";
            this.labelGuiche.Size = new System.Drawing.Size(57, 17);
            this.labelGuiche.TabIndex = 6;
            this.labelGuiche.Text = "Guiche:";
            // 
            // FormProjetoAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 515);
            this.Controls.Add(this.labelGuiche);
            this.Controls.Add(this.buttonListarAtendimentos);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.labelNumGuiches);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.listBoxAtendimento);
            this.Controls.Add(this.labelQuantidadeGuiches);
            this.Controls.Add(this.textBoxGuiche);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.listBoxSenhas);
            this.Name = "FormProjetoAtendimento";
            this.Text = "Guiche Atentimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.TextBox textBoxGuiche;
        private System.Windows.Forms.Label labelQuantidadeGuiches;
        private System.Windows.Forms.ListBox listBoxAtendimento;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelNumGuiches;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Button buttonListarAtendimentos;
        private System.Windows.Forms.Label labelGuiche;
    }
}

