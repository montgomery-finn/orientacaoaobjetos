namespace Apresentacao.Visualizacao
{
    partial class AnimalVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalVisualizar));
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.animalDataGridView = new System.Windows.Forms.DataGridView();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExcluirButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirButton.ForeColor = System.Drawing.Color.DimGray;
            this.ExcluirButton.Image = global::Apresentacao.Properties.Resources.iconfinder_basket_18140901;
            this.ExcluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcluirButton.Location = new System.Drawing.Point(324, 446);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(89, 37);
            this.ExcluirButton.TabIndex = 1;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExcluirButton.UseVisualStyleBackColor = false;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarButton.ForeColor = System.Drawing.Color.DimGray;
            this.EditarButton.Image = global::Apresentacao.Properties.Resources.iconfinder_24_7_pet_37752591;
            this.EditarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditarButton.Location = new System.Drawing.Point(451, 446);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(89, 37);
            this.EditarButton.TabIndex = 2;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarButton.UseVisualStyleBackColor = false;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaTextBox.Location = new System.Drawing.Point(483, 35);
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(187, 27);
            this.PesquisaTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Buscar por:";
            // 
            // BuscarComboBox
            // 
            this.BuscarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarComboBox.FormattingEnabled = true;
            this.BuscarComboBox.Items.AddRange(new object[] {
            "ID - Animal",
            "Nome - Animal",
            "Nome - Cliente",
            "Espécie",
            "Raça"});
            this.BuscarComboBox.Location = new System.Drawing.Point(176, 35);
            this.BuscarComboBox.Name = "BuscarComboBox";
            this.BuscarComboBox.Size = new System.Drawing.Size(176, 27);
            this.BuscarComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pesquisar:";
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.buscarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.ForeColor = System.Drawing.Color.DimGray;
            this.buscarButton.Location = new System.Drawing.Point(676, 33);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(97, 30);
            this.buscarButton.TabIndex = 5;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(737, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 6;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // animalDataGridView
            // 
            this.animalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.animalDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.animalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalID,
            this.NomeAnimal,
            this.NomeCliente,
            this.Especie,
            this.Raca,
            this.Peso,
            this.Tamanho});
            this.animalDataGridView.Location = new System.Drawing.Point(33, 97);
            this.animalDataGridView.Name = "animalDataGridView";
            this.animalDataGridView.Size = new System.Drawing.Size(769, 316);
            this.animalDataGridView.TabIndex = 0;
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
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Nome - Cliente";
            this.NomeCliente.Name = "NomeCliente";
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Espécie";
            this.Especie.Name = "Especie";
            // 
            // Raca
            // 
            this.Raca.HeaderText = "Raça";
            this.Raca.Name = "Raca";
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // Tamanho
            // 
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            // 
            // AnimalVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(834, 508);
            this.Controls.Add(this.animalDataGridView);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.PesquisaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuscarComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.EditarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnimalVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ClinVet - Visualizar - Animal";
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.TextBox PesquisaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BuscarComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.DataGridView animalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
    }
}