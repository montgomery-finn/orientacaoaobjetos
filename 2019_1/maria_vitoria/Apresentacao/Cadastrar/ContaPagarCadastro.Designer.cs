namespace Apresentacao.Cadastrar
{
    partial class ContaPagarCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContaPagarCadastro));
            this.button1 = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.ParcelasComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FormaPagComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ValorPagoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.ValorTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Apresentacao.Properties.Resources.iconfinder_broom_stick_3_896656;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(260, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Image = global::Apresentacao.Properties.Resources.iconfinder_save_26399121;
            this.cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrar.Location = new System.Drawing.Point(100, 254);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(122, 38);
            this.cadastrar.TabIndex = 6;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // ParcelasComboBox
            // 
            this.ParcelasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParcelasComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelasComboBox.FormattingEnabled = true;
            this.ParcelasComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ParcelasComboBox.Location = new System.Drawing.Point(128, 195);
            this.ParcelasComboBox.Name = "ParcelasComboBox";
            this.ParcelasComboBox.Size = new System.Drawing.Size(158, 27);
            this.ParcelasComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "Parcelas:";
            // 
            // FormaPagComboBox
            // 
            this.FormaPagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaPagComboBox.FormattingEnabled = true;
            this.FormaPagComboBox.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão - Débito",
            "Cartão - Crédito"});
            this.FormaPagComboBox.Location = new System.Drawing.Point(244, 164);
            this.FormaPagComboBox.Name = "FormaPagComboBox";
            this.FormaPagComboBox.Size = new System.Drawing.Size(207, 27);
            this.FormaPagComboBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // ValorPagoTextBox
            // 
            this.ValorPagoTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorPagoTextBox.Location = new System.Drawing.Point(149, 133);
            this.ValorPagoTextBox.Name = "ValorPagoTextBox";
            this.ValorPagoTextBox.Size = new System.Drawing.Size(137, 27);
            this.ValorPagoTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor Pago:";
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(381, 1);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 8;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // ValorTotalTextBox
            // 
            this.ValorTotalTextBox.Enabled = false;
            this.ValorTotalTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotalTextBox.Location = new System.Drawing.Point(149, 100);
            this.ValorTotalTextBox.Name = "ValorTotalTextBox";
            this.ValorTotalTextBox.Size = new System.Drawing.Size(137, 27);
            this.ValorTotalTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Valor Total:";
            // 
            // ContaDateTimePicker
            // 
            this.ContaDateTimePicker.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ContaDateTimePicker.Location = new System.Drawing.Point(100, 67);
            this.ContaDateTimePicker.Name = "ContaDateTimePicker";
            this.ContaDateTimePicker.Size = new System.Drawing.Size(127, 27);
            this.ContaDateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Conta Cliente:";
            // 
            // NomeClienteTextBox
            // 
            this.NomeClienteTextBox.Enabled = false;
            this.NomeClienteTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeClienteTextBox.Location = new System.Drawing.Point(173, 34);
            this.NomeClienteTextBox.Name = "NomeClienteTextBox";
            this.NomeClienteTextBox.Size = new System.Drawing.Size(278, 27);
            this.NomeClienteTextBox.TabIndex = 0;
            // 
            // ContaPagarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(481, 323);
            this.Controls.Add(this.NomeClienteTextBox);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.ValorTotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.ParcelasComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FormaPagComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValorPagoTextBox);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContaPagarCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.ComboBox ParcelasComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FormaPagComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ValorPagoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox ValorTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ContaDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeClienteTextBox;
    }
}