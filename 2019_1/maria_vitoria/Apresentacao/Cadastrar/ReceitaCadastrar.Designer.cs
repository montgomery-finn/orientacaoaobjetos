namespace Apresentacao.Cadastrar
{
    partial class ReceitaCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceitaCadastrar));
            this.cadastrar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.consultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.receitaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.animalComboBox = new System.Windows.Forms.ComboBox();
            this.veterinarioComboBox = new System.Windows.Forms.ComboBox();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Image = global::Apresentacao.Properties.Resources.iconfinder_save_26399121;
            this.cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrar.Location = new System.Drawing.Point(133, 638);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(120, 38);
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
            this.voltar.Location = new System.Drawing.Point(447, 1);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 8;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data da Consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Receita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Observações:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Animal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Veterinário:";
            // 
            // consultaDateTimePicker
            // 
            this.consultaDateTimePicker.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.consultaDateTimePicker.Location = new System.Drawing.Point(205, 99);
            this.consultaDateTimePicker.Name = "consultaDateTimePicker";
            this.consultaDateTimePicker.Size = new System.Drawing.Size(145, 27);
            this.consultaDateTimePicker.TabIndex = 2;
            // 
            // receitaRichTextBox
            // 
            this.receitaRichTextBox.Location = new System.Drawing.Point(36, 225);
            this.receitaRichTextBox.Name = "receitaRichTextBox";
            this.receitaRichTextBox.Size = new System.Drawing.Size(475, 284);
            this.receitaRichTextBox.TabIndex = 4;
            this.receitaRichTextBox.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(36, 543);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(475, 67);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // animalComboBox
            // 
            this.animalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalComboBox.FormattingEnabled = true;
            this.animalComboBox.Location = new System.Drawing.Point(114, 35);
            this.animalComboBox.Name = "animalComboBox";
            this.animalComboBox.Size = new System.Drawing.Size(334, 27);
            this.animalComboBox.TabIndex = 0;
            // 
            // veterinarioComboBox
            // 
            this.veterinarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.veterinarioComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veterinarioComboBox.FormattingEnabled = true;
            this.veterinarioComboBox.Location = new System.Drawing.Point(151, 67);
            this.veterinarioComboBox.Name = "veterinarioComboBox";
            this.veterinarioComboBox.Size = new System.Drawing.Size(297, 27);
            this.veterinarioComboBox.TabIndex = 1;
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Items.AddRange(new object[] {
            "Emergência",
            "Rotina"});
            this.TipoComboBox.Location = new System.Drawing.Point(99, 132);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(158, 27);
            this.TipoComboBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Apresentacao.Properties.Resources.iconfinder_broom_stick_3_896656;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(291, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReceitaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(546, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(this.veterinarioComboBox);
            this.Controls.Add(this.animalComboBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.receitaRichTextBox);
            this.Controls.Add(this.consultaDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReceitaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Cadastrar - Receita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker consultaDateTimePicker;
        private System.Windows.Forms.RichTextBox receitaRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox animalComboBox;
        private System.Windows.Forms.ComboBox veterinarioComboBox;
        private System.Windows.Forms.ComboBox TipoComboBox;
        private System.Windows.Forms.Button button1;
    }
}