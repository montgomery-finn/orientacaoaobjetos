namespace Apresentacao
{
    partial class Conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conta));
            this.voltar = new System.Windows.Forms.Button();
            this.NomeClienteComboBox = new System.Windows.Forms.ComboBox();
            this.ContaClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ContaClienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(958, 3);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 3;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // NomeClienteComboBox
            // 
            this.NomeClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomeClienteComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeClienteComboBox.FormattingEnabled = true;
            this.NomeClienteComboBox.Location = new System.Drawing.Point(307, 35);
            this.NomeClienteComboBox.Name = "NomeClienteComboBox";
            this.NomeClienteComboBox.Size = new System.Drawing.Size(521, 27);
            this.NomeClienteComboBox.TabIndex = 1;
            // 
            // ContaClienteDataGridView
            // 
            this.ContaClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContaClienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContaClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContaClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDConta,
            this.IDCliente,
            this.Nome,
            this.DataInicio,
            this.ValorTotal,
            this.Status});
            this.ContaClienteDataGridView.Location = new System.Drawing.Point(31, 129);
            this.ContaClienteDataGridView.Name = "ContaClienteDataGridView";
            this.ContaClienteDataGridView.Size = new System.Drawing.Size(995, 320);
            this.ContaClienteDataGridView.TabIndex = 0;
            this.ContaClienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContaClienteDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente:";
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.buscarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.ForeColor = System.Drawing.Color.DimGray;
            this.buscarButton.Location = new System.Drawing.Point(510, 66);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(97, 30);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(446, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar - Pagamento";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDConta
            // 
            this.IDConta.HeaderText = "ID - Conta";
            this.IDConta.Name = "IDConta";
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "ID - Cliente";
            this.IDCliente.Name = "IDCliente";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome - Cliente";
            this.Nome.Name = "Nome";
            // 
            // DataInicio
            // 
            this.DataInicio.HeaderText = "Data - Compra";
            this.DataInicio.Name = "DataInicio";
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(1056, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContaClienteDataGridView);
            this.Controls.Add(this.NomeClienteComboBox);
            this.Controls.Add(this.voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Conta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ContaClienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.ComboBox NomeClienteComboBox;
        private System.Windows.Forms.DataGridView ContaClienteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}