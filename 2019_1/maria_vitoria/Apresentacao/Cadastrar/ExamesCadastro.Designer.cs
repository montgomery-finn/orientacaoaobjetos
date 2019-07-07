namespace Apresentacao.Cadastrar
{
    partial class ExamesCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamesCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeExameTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.exameDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.animalComboBox = new System.Windows.Forms.ComboBox();
            this.medicoComboBox = new System.Windows.Forms.ComboBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.horarioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Exame:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data do Exame:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Animal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Médico Veterinário:";
            // 
            // nomeExameTextBox
            // 
            this.nomeExameTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeExameTextBox.Location = new System.Drawing.Point(229, 35);
            this.nomeExameTextBox.Name = "nomeExameTextBox";
            this.nomeExameTextBox.Size = new System.Drawing.Size(158, 27);
            this.nomeExameTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTextBox.Location = new System.Drawing.Point(138, 67);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(121, 27);
            this.precoTextBox.TabIndex = 1;
            // 
            // exameDateTimePicker
            // 
            this.exameDateTimePicker.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exameDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.exameDateTimePicker.Location = new System.Drawing.Point(221, 100);
            this.exameDateTimePicker.Name = "exameDateTimePicker";
            this.exameDateTimePicker.Size = new System.Drawing.Size(127, 27);
            this.exameDateTimePicker.TabIndex = 2;
            // 
            // animalComboBox
            // 
            this.animalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalComboBox.FormattingEnabled = true;
            this.animalComboBox.Location = new System.Drawing.Point(146, 162);
            this.animalComboBox.Name = "animalComboBox";
            this.animalComboBox.Size = new System.Drawing.Size(174, 27);
            this.animalComboBox.TabIndex = 4;
            // 
            // medicoComboBox
            // 
            this.medicoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicoComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicoComboBox.FormattingEnabled = true;
            this.medicoComboBox.Location = new System.Drawing.Point(258, 196);
            this.medicoComboBox.Name = "medicoComboBox";
            this.medicoComboBox.Size = new System.Drawing.Size(154, 27);
            this.medicoComboBox.TabIndex = 5;
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
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(382, 1);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 8;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // horarioDateTimePicker
            // 
            this.horarioDateTimePicker.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horarioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horarioDateTimePicker.Location = new System.Drawing.Point(154, 131);
            this.horarioDateTimePicker.Name = "horarioDateTimePicker";
            this.horarioDateTimePicker.ShowUpDown = true;
            this.horarioDateTimePicker.Size = new System.Drawing.Size(85, 27);
            this.horarioDateTimePicker.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 26);
            this.label7.TabIndex = 60;
            this.label7.Text = "Horário:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Apresentacao.Properties.Resources.iconfinder_broom_stick_3_896656;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(256, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExamesCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(481, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horarioDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.medicoComboBox);
            this.Controls.Add(this.animalComboBox);
            this.Controls.Add(this.exameDateTimePicker);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.nomeExameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExamesCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Cadastrar - Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeExameTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.DateTimePicker exameDateTimePicker;
        private System.Windows.Forms.ComboBox animalComboBox;
        private System.Windows.Forms.ComboBox medicoComboBox;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.DateTimePicker horarioDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}