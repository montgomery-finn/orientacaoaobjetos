namespace Apresentacao.Cadastrar
{
    partial class AnimalCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalCadastro));
            this.nome = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.raca = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.tamanho = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.especieBox = new System.Windows.Forms.TextBox();
            this.racaBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voltar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.nomeCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TamanhoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PesoTextBox = new System.Windows.Forms.TextBox();
            this.SexoAnimalComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nome.Location = new System.Drawing.Point(32, 69);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(71, 26);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome:";
            // 
            // dataNascimento
            // 
            this.dataNascimento.AutoSize = true;
            this.dataNascimento.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimento.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataNascimento.Location = new System.Drawing.Point(32, 99);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(199, 26);
            this.dataNascimento.TabIndex = 2;
            this.dataNascimento.Text = "Data de Nascimento:";
            // 
            // especie
            // 
            this.especie.AutoSize = true;
            this.especie.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.especie.Location = new System.Drawing.Point(32, 133);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(85, 26);
            this.especie.TabIndex = 3;
            this.especie.Text = "Espécie:";
            // 
            // raca
            // 
            this.raca.AutoSize = true;
            this.raca.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.raca.Location = new System.Drawing.Point(32, 164);
            this.raca.Name = "raca";
            this.raca.Size = new System.Drawing.Size(59, 26);
            this.raca.TabIndex = 4;
            this.raca.Text = "Raça:";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sexo.Location = new System.Drawing.Point(32, 196);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(67, 26);
            this.sexo.TabIndex = 5;
            this.sexo.Text = "Sexo: ";
            // 
            // tamanho
            // 
            this.tamanho.AutoSize = true;
            this.tamanho.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tamanho.Location = new System.Drawing.Point(32, 260);
            this.tamanho.Name = "tamanho";
            this.tamanho.Size = new System.Drawing.Size(185, 26);
            this.tamanho.TabIndex = 6;
            this.tamanho.Text = "Tamanho (Metros):";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.peso.Location = new System.Drawing.Point(32, 228);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(104, 26);
            this.peso.TabIndex = 7;
            this.peso.Text = "Peso (Kg):";
            // 
            // nomeBox
            // 
            this.nomeBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeBox.Location = new System.Drawing.Point(99, 68);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(223, 27);
            this.nomeBox.TabIndex = 1;
            // 
            // especieBox
            // 
            this.especieBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.especieBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especieBox.Location = new System.Drawing.Point(117, 131);
            this.especieBox.Name = "especieBox";
            this.especieBox.Size = new System.Drawing.Size(131, 27);
            this.especieBox.TabIndex = 3;
            // 
            // racaBox
            // 
            this.racaBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.racaBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racaBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.racaBox.Location = new System.Drawing.Point(94, 163);
            this.racaBox.Name = "racaBox";
            this.racaBox.Size = new System.Drawing.Size(133, 27);
            this.racaBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(349, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 160);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(642, 3);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 10;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Image = global::Apresentacao.Properties.Resources.iconfinder_save_26399121;
            this.cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrar.Location = new System.Drawing.Point(230, 318);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(120, 38);
            this.cadastrar.TabIndex = 8;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // nomeCliente
            // 
            this.nomeCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomeCliente.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCliente.FormattingEnabled = true;
            this.nomeCliente.Location = new System.Drawing.Point(248, 33);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(388, 27);
            this.nomeCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome do Proprietário:";
            // 
            // DataDateTimePicker
            // 
            this.DataDateTimePicker.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDateTimePicker.Location = new System.Drawing.Point(230, 100);
            this.DataDateTimePicker.Name = "DataDateTimePicker";
            this.DataDateTimePicker.Size = new System.Drawing.Size(113, 27);
            this.DataDateTimePicker.TabIndex = 2;
            // 
            // TamanhoMaskedTextBox
            // 
            this.TamanhoMaskedTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamanhoMaskedTextBox.Location = new System.Drawing.Point(217, 259);
            this.TamanhoMaskedTextBox.Mask = "0.00";
            this.TamanhoMaskedTextBox.Name = "TamanhoMaskedTextBox";
            this.TamanhoMaskedTextBox.Size = new System.Drawing.Size(30, 27);
            this.TamanhoMaskedTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Apresentacao.Properties.Resources.iconfinder_broom_stick_3_896656;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(388, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PesoTextBox
            // 
            this.PesoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PesoTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PesoTextBox.Location = new System.Drawing.Point(132, 230);
            this.PesoTextBox.Name = "PesoTextBox";
            this.PesoTextBox.Size = new System.Drawing.Size(63, 27);
            this.PesoTextBox.TabIndex = 6;
            // 
            // SexoAnimalComboBox
            // 
            this.SexoAnimalComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SexoAnimalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexoAnimalComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexoAnimalComboBox.FormattingEnabled = true;
            this.SexoAnimalComboBox.Items.AddRange(new object[] {
            "Fêmea",
            "Macho"});
            this.SexoAnimalComboBox.Location = new System.Drawing.Point(94, 195);
            this.SexoAnimalComboBox.Name = "SexoAnimalComboBox";
            this.SexoAnimalComboBox.Size = new System.Drawing.Size(133, 27);
            this.SexoAnimalComboBox.TabIndex = 5;
            // 
            // AnimalCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(739, 386);
            this.Controls.Add(this.SexoAnimalComboBox);
            this.Controls.Add(this.PesoTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TamanhoMaskedTextBox);
            this.Controls.Add(this.DataDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racaBox);
            this.Controls.Add(this.especieBox);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.tamanho);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.raca);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnimalCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Cadastrar - Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label dataNascimento;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label raca;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label tamanho;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.TextBox especieBox;
        private System.Windows.Forms.TextBox racaBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.ComboBox nomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataDateTimePicker;
        private System.Windows.Forms.MaskedTextBox TamanhoMaskedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PesoTextBox;
        private System.Windows.Forms.ComboBox SexoAnimalComboBox;
    }
}