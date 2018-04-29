namespace SistemaBanco
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFormPrincipal = new System.Windows.Forms.GroupBox();
            this.lbNenhumRegistro = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxformprincipal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFormPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.contaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaContaToolStripMenuItem,
            this.saqueToolStripMenuItem,
            this.depósitoToolStripMenuItem,
            this.verificarSaldoToolStripMenuItem});
            this.contaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // novaContaToolStripMenuItem
            // 
            this.novaContaToolStripMenuItem.Name = "novaContaToolStripMenuItem";
            this.novaContaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.novaContaToolStripMenuItem.Text = "Nova Conta";
            this.novaContaToolStripMenuItem.Click += new System.EventHandler(this.novaContaToolStripMenuItem_Click);
            // 
            // saqueToolStripMenuItem
            // 
            this.saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            this.saqueToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saqueToolStripMenuItem.Text = "Saque";
            this.saqueToolStripMenuItem.Click += new System.EventHandler(this.saqueToolStripMenuItem_Click);
            // 
            // depósitoToolStripMenuItem
            // 
            this.depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            this.depósitoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.depósitoToolStripMenuItem.Text = "Depósito";
            this.depósitoToolStripMenuItem.Click += new System.EventHandler(this.depósitoToolStripMenuItem_Click);
            // 
            // verificarSaldoToolStripMenuItem
            // 
            this.verificarSaldoToolStripMenuItem.Name = "verificarSaldoToolStripMenuItem";
            this.verificarSaldoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.verificarSaldoToolStripMenuItem.Text = "Verificar Saldo";
            this.verificarSaldoToolStripMenuItem.Click += new System.EventHandler(this.verificarSaldoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupBoxFormPrincipal
            // 
            this.groupBoxFormPrincipal.Controls.Add(this.lbNenhumRegistro);
            this.groupBoxFormPrincipal.Controls.Add(this.dataGridView1);
            this.groupBoxFormPrincipal.Controls.Add(this.button2);
            this.groupBoxFormPrincipal.Controls.Add(this.button1);
            this.groupBoxFormPrincipal.Controls.Add(this.textBoxformprincipal);
            this.groupBoxFormPrincipal.Controls.Add(this.label1);
            this.groupBoxFormPrincipal.Location = new System.Drawing.Point(36, 68);
            this.groupBoxFormPrincipal.Name = "groupBoxFormPrincipal";
            this.groupBoxFormPrincipal.Size = new System.Drawing.Size(817, 351);
            this.groupBoxFormPrincipal.TabIndex = 1;
            this.groupBoxFormPrincipal.TabStop = false;
            this.groupBoxFormPrincipal.Text = "FormPrincipal";
            this.groupBoxFormPrincipal.Visible = false;
            this.groupBoxFormPrincipal.Enter += new System.EventHandler(this.groupBoxFormPrincipal_Enter);
            // 
            // lbNenhumRegistro
            // 
            this.lbNenhumRegistro.AutoSize = true;
            this.lbNenhumRegistro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNenhumRegistro.ForeColor = System.Drawing.Color.Maroon;
            this.lbNenhumRegistro.Location = new System.Drawing.Point(212, 129);
            this.lbNenhumRegistro.Name = "lbNenhumRegistro";
            this.lbNenhumRegistro.Size = new System.Drawing.Size(270, 18);
            this.lbNenhumRegistro.TabIndex = 5;
            this.lbNenhumRegistro.Text = "Nenhum nome encontrado na lista.";
            this.lbNenhumRegistro.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone,
            this.Endereço});
            this.dataGridView1.Location = new System.Drawing.Point(55, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 275;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.Width = 250;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(646, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxformprincipal
            // 
            this.textBoxformprincipal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxformprincipal.Location = new System.Drawing.Point(116, 75);
            this.textBoxformprincipal.Name = "textBoxformprincipal";
            this.textBoxformprincipal.Size = new System.Drawing.Size(609, 23);
            this.textBoxformprincipal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(912, 458);
            this.Controls.Add(this.groupBoxFormPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formulário Banco";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFormPrincipal.ResumeLayout(false);
            this.groupBoxFormPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarSaldoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFormPrincipal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxformprincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNenhumRegistro;
    }
}

