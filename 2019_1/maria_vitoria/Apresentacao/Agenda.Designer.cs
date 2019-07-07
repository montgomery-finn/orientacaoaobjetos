namespace Apresentacao
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.voltar = new System.Windows.Forms.Button();
            this.agendaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarComboBox = new System.Windows.Forms.ComboBox();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarDataButton = new System.Windows.Forms.Button();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(859, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 7;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // agendaDataGridView
            // 
            this.agendaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agendaDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.agendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalID,
            this.NomeAnimal,
            this.Data,
            this.Horario,
            this.Preco,
            this.Tipo,
            this.VetID,
            this.NomeVet});
            this.agendaDataGridView.Location = new System.Drawing.Point(30, 162);
            this.agendaDataGridView.Name = "agendaDataGridView";
            this.agendaDataGridView.Size = new System.Drawing.Size(870, 316);
            this.agendaDataGridView.TabIndex = 6;
            this.agendaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.agendaDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data:";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Consulta",
            "Exame"});
            this.categoriaComboBox.Location = new System.Drawing.Point(230, 67);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(183, 27);
            this.categoriaComboBox.TabIndex = 0;
            this.categoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox_SelectedIndexChanged);
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.buscarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.ForeColor = System.Drawing.Color.DimGray;
            this.buscarButton.Location = new System.Drawing.Point(737, 95);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(97, 30);
            this.buscarButton.TabIndex = 5;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pesquisar:";
            // 
            // DataDateTimePicker
            // 
            this.DataDateTimePicker.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDateTimePicker.Location = new System.Drawing.Point(498, 64);
            this.DataDateTimePicker.Name = "DataDateTimePicker";
            this.DataDateTimePicker.Size = new System.Drawing.Size(137, 27);
            this.DataDateTimePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buscar por:";
            // 
            // BuscarComboBox
            // 
            this.BuscarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarComboBox.FormattingEnabled = true;
            this.BuscarComboBox.Items.AddRange(new object[] {
            "ID - Animal",
            "ID - Veterinário",
            "Nome - Animal",
            "Nome - Veterinário"});
            this.BuscarComboBox.Location = new System.Drawing.Point(237, 97);
            this.BuscarComboBox.Name = "BuscarComboBox";
            this.BuscarComboBox.Size = new System.Drawing.Size(176, 27);
            this.BuscarComboBox.TabIndex = 3;
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaTextBox.Location = new System.Drawing.Point(544, 97);
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(187, 27);
            this.PesquisaTextBox.TabIndex = 4;
            // 
            // BuscarDataButton
            // 
            this.BuscarDataButton.BackColor = System.Drawing.Color.GreenYellow;
            this.BuscarDataButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarDataButton.ForeColor = System.Drawing.Color.DimGray;
            this.BuscarDataButton.Location = new System.Drawing.Point(640, 62);
            this.BuscarDataButton.Name = "BuscarDataButton";
            this.BuscarDataButton.Size = new System.Drawing.Size(130, 30);
            this.BuscarDataButton.TabIndex = 2;
            this.BuscarDataButton.Text = "Buscar Data";
            this.BuscarDataButton.UseVisualStyleBackColor = false;
            this.BuscarDataButton.Click += new System.EventHandler(this.BuscarDataButton_Click);
            // 
            // AnimalID
            // 
            this.AnimalID.HeaderText = "Animal ID";
            this.AnimalID.Name = "AnimalID";
            // 
            // NomeAnimal
            // 
            this.NomeAnimal.HeaderText = "Nome - Animal";
            this.NomeAnimal.Name = "NomeAnimal";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // VetID
            // 
            this.VetID.HeaderText = "Veterinário ID";
            this.VetID.Name = "VetID";
            // 
            // NomeVet
            // 
            this.NomeVet.HeaderText = "Nome - Veterinário";
            this.NomeVet.Name = "NomeVet";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(957, 510);
            this.Controls.Add(this.BuscarDataButton);
            this.Controls.Add(this.PesquisaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuscarComboBox);
            this.Controls.Add(this.DataDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agendaDataGridView);
            this.Controls.Add(this.voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.DataGridView agendaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BuscarComboBox;
        private System.Windows.Forms.TextBox PesquisaTextBox;
        private System.Windows.Forms.Button BuscarDataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeVet;
    }
}