
namespace Estudio
{
    partial class Form5
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
            this.grbModalidades = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtQtdAlunos = new System.Windows.Forms.TextBox();
            this.txtPrecoMod = new System.Windows.Forms.TextBox();
            this.lblQtdeAulas = new System.Windows.Forms.Label();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            this.lblPrecoMod = new System.Windows.Forms.Label();
            this.txtDescricaoMod = new System.Windows.Forms.TextBox();
            this.lblDescricaoMod = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbModalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbModalidades
            // 
            this.grbModalidades.Controls.Add(this.btnCadastrar);
            this.grbModalidades.Controls.Add(this.txtQtdeAulas);
            this.grbModalidades.Controls.Add(this.txtQtdAlunos);
            this.grbModalidades.Controls.Add(this.txtPrecoMod);
            this.grbModalidades.Controls.Add(this.lblQtdeAulas);
            this.grbModalidades.Controls.Add(this.lblQtdeAlunos);
            this.grbModalidades.Controls.Add(this.lblPrecoMod);
            this.grbModalidades.Controls.Add(this.txtDescricaoMod);
            this.grbModalidades.Controls.Add(this.lblDescricaoMod);
            this.grbModalidades.Location = new System.Drawing.Point(189, 84);
            this.grbModalidades.Name = "grbModalidades";
            this.grbModalidades.Size = new System.Drawing.Size(319, 190);
            this.grbModalidades.TabIndex = 0;
            this.grbModalidades.TabStop = false;
            this.grbModalidades.Text = "Modalidades";
            this.grbModalidades.Enter += new System.EventHandler(this.grbModalidades_Enter);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(93, 142);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(190, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(93, 116);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.Size = new System.Drawing.Size(190, 20);
            this.txtQtdeAulas.TabIndex = 7;
            // 
            // txtQtdAlunos
            // 
            this.txtQtdAlunos.Location = new System.Drawing.Point(93, 90);
            this.txtQtdAlunos.Name = "txtQtdAlunos";
            this.txtQtdAlunos.Size = new System.Drawing.Size(190, 20);
            this.txtQtdAlunos.TabIndex = 6;
            // 
            // txtPrecoMod
            // 
            this.txtPrecoMod.Location = new System.Drawing.Point(93, 64);
            this.txtPrecoMod.Name = "txtPrecoMod";
            this.txtPrecoMod.Size = new System.Drawing.Size(190, 20);
            this.txtPrecoMod.TabIndex = 5;
            // 
            // lblQtdeAulas
            // 
            this.lblQtdeAulas.AutoSize = true;
            this.lblQtdeAulas.Location = new System.Drawing.Point(25, 119);
            this.lblQtdeAulas.Name = "lblQtdeAulas";
            this.lblQtdeAulas.Size = new System.Drawing.Size(62, 13);
            this.lblQtdeAulas.TabIndex = 4;
            this.lblQtdeAulas.Text = "Qtde Aulas:";
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(19, 93);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(68, 13);
            this.lblQtdeAlunos.TabIndex = 3;
            this.lblQtdeAlunos.Text = "Qtde Alunos:";
            // 
            // lblPrecoMod
            // 
            this.lblPrecoMod.AutoSize = true;
            this.lblPrecoMod.Location = new System.Drawing.Point(49, 67);
            this.lblPrecoMod.Name = "lblPrecoMod";
            this.lblPrecoMod.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoMod.TabIndex = 2;
            this.lblPrecoMod.Text = "Preço:";
            // 
            // txtDescricaoMod
            // 
            this.txtDescricaoMod.Location = new System.Drawing.Point(93, 38);
            this.txtDescricaoMod.Name = "txtDescricaoMod";
            this.txtDescricaoMod.Size = new System.Drawing.Size(190, 20);
            this.txtDescricaoMod.TabIndex = 1;
            // 
            // lblDescricaoMod
            // 
            this.lblDescricaoMod.AutoSize = true;
            this.lblDescricaoMod.Location = new System.Drawing.Point(29, 41);
            this.lblDescricaoMod.Name = "lblDescricaoMod";
            this.lblDescricaoMod.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoMod.TabIndex = 0;
            this.lblDescricaoMod.Text = "Descrição:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbModalidades);
            this.Name = "Form5";
            this.Text = "Cadastro de modalidades";
            this.grbModalidades.ResumeLayout(false);
            this.grbModalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbModalidades;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.TextBox txtQtdAlunos;
        private System.Windows.Forms.TextBox txtPrecoMod;
        private System.Windows.Forms.Label lblQtdeAulas;
        private System.Windows.Forms.Label lblQtdeAlunos;
        private System.Windows.Forms.Label lblPrecoMod;
        private System.Windows.Forms.TextBox txtDescricaoMod;
        private System.Windows.Forms.Label lblDescricaoMod;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}