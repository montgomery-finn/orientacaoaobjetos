namespace Apresentacao
{
    partial class CaixaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaView));
            this.voltar = new System.Windows.Forms.Button();
            this.CaixaDataGridView = new System.Windows.Forms.DataGridView();
            this.IDConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaixaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(958, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 5;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // CaixaDataGridView
            // 
            this.CaixaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CaixaDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CaixaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaixaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDConta,
            this.IDCliente,
            this.Nome,
            this.DataInicio,
            this.ValorTotal,
            this.ValorPago,
            this.FormaPagamento,
            this.Parcelas});
            this.CaixaDataGridView.Location = new System.Drawing.Point(30, 101);
            this.CaixaDataGridView.Name = "CaixaDataGridView";
            this.CaixaDataGridView.Size = new System.Drawing.Size(995, 350);
            this.CaixaDataGridView.TabIndex = 0;
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
            // ValorPago
            // 
            this.ValorPago.HeaderText = "Valor Pago";
            this.ValorPago.Name = "ValorPago";
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.HeaderText = "Forma de Pagamento";
            this.FormaPagamento.Name = "FormaPagamento";
            // 
            // Parcelas
            // 
            this.Parcelas.HeaderText = "Parcelas";
            this.Parcelas.Name = "Parcelas";
            // 
            // DataDateTimePicker
            // 
            this.DataDateTimePicker.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDateTimePicker.Location = new System.Drawing.Point(132, 67);
            this.DataDateTimePicker.Name = "DataDateTimePicker";
            this.DataDateTimePicker.Size = new System.Drawing.Size(126, 27);
            this.DataDateTimePicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Histórico:";
            // 
            // ValorTotalTextBox
            // 
            this.ValorTotalTextBox.Enabled = false;
            this.ValorTotalTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotalTextBox.Location = new System.Drawing.Point(875, 69);
            this.ValorTotalTextBox.Name = "ValorTotalTextBox";
            this.ValorTotalTextBox.Size = new System.Drawing.Size(148, 27);
            this.ValorTotalTextBox.TabIndex = 4;
            this.ValorTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValorTotalTextBox.TextChanged += new System.EventHandler(this.ValorTotalTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor Total em Caixa (R$):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.BuscarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ForeColor = System.Drawing.Color.DimGray;
            this.BuscarButton.Location = new System.Drawing.Point(291, 67);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(97, 30);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CaixaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(1057, 482);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ValorTotalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataDateTimePicker);
            this.Controls.Add(this.CaixaDataGridView);
            this.Controls.Add(this.voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaixaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.CaixaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.DataGridView CaixaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcelas;
        private System.Windows.Forms.DateTimePicker DataDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValorTotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
    }
}