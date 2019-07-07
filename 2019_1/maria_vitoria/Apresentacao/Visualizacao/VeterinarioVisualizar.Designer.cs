﻿namespace Apresentacao.Visualizacao
{
    partial class VeterinarioVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeterinarioVisualizar));
            this.vetDataGridView = new System.Windows.Forms.DataGridView();
            this.VetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltar = new System.Windows.Forms.Button();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vetDataGridView
            // 
            this.vetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vetDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.vetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VetID,
            this.NomeVet,
            this.CRMV,
            this.Email,
            this.Celular});
            this.vetDataGridView.Location = new System.Drawing.Point(33, 96);
            this.vetDataGridView.Name = "vetDataGridView";
            this.vetDataGridView.Size = new System.Drawing.Size(769, 316);
            this.vetDataGridView.TabIndex = 0;
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
            // CRMV
            // 
            this.CRMV.HeaderText = "CRMV";
            this.CRMV.Name = "CRMV";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.GreenYellow;
            this.voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DimGray;
            this.voltar.Location = new System.Drawing.Point(737, 1);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(97, 30);
            this.voltar.TabIndex = 6;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaTextBox.Location = new System.Drawing.Point(483, 34);
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(187, 27);
            this.PesquisaTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Buscar por:";
            // 
            // BuscarComboBox
            // 
            this.BuscarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarComboBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarComboBox.FormattingEnabled = true;
            this.BuscarComboBox.Items.AddRange(new object[] {
            "ID - Veterinário",
            "Nome - Veterinário",
            "CRMV"});
            this.BuscarComboBox.Location = new System.Drawing.Point(176, 34);
            this.BuscarComboBox.Name = "BuscarComboBox";
            this.BuscarComboBox.Size = new System.Drawing.Size(176, 27);
            this.BuscarComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pesquisar:";
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.buscarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.ForeColor = System.Drawing.Color.DimGray;
            this.buscarButton.Location = new System.Drawing.Point(676, 32);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(97, 30);
            this.buscarButton.TabIndex = 5;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExcluirButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirButton.ForeColor = System.Drawing.Color.DimGray;
            this.ExcluirButton.Image = global::Apresentacao.Properties.Resources.iconfinder_basket_18140901;
            this.ExcluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcluirButton.Location = new System.Drawing.Point(324, 445);
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
            this.EditarButton.Location = new System.Drawing.Point(451, 445);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(89, 37);
            this.EditarButton.TabIndex = 2;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarButton.UseVisualStyleBackColor = false;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // VeterinarioVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.iconfinder_Pet_hospital_3775242;
            this.ClientSize = new System.Drawing.Size(834, 508);
            this.Controls.Add(this.vetDataGridView);
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
            this.Name = "VeterinarioVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema - ClinVet - Visualizar - Veterinário";
            ((System.ComponentModel.ISupportInitialize)(this.vetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vetDataGridView;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox PesquisaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BuscarComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn VetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeVet;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}