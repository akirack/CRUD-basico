
namespace CRUD_basico
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(61, 54);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(61, 89);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(61, 126);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(47, 13);
            this.lbNumero.TabIndex = 2;
            this.lbNumero.Text = "Numero:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(125, 46);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(147, 20);
            this.tbID.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(125, 86);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(147, 20);
            this.tbNome.TabIndex = 4;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(125, 123);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(147, 20);
            this.tbNumero.TabIndex = 5;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(43, 186);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(84, 27);
            this.btNovo.TabIndex = 6;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(147, 186);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(84, 27);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(251, 186);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(84, 27);
            this.btConsultar.TabIndex = 8;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(358, 186);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(84, 27);
            this.btExibir.TabIndex = 9;
            this.btExibir.Text = "Exibir";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(467, 186);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(84, 27);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(13, 235);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(583, 317);
            this.dgvDados.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 564);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbID);
            this.Name = "Form1";
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}

