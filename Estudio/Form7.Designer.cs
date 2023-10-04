
namespace Estudio
{
    partial class FormConsultar
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
            this.grpbModalidades = new System.Windows.Forms.GroupBox();
            this.btnConsultarMod = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunos = new System.Windows.Forms.TextBox();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.cmbDescricao = new System.Windows.Forms.ComboBox();
            this.lblQtdeAulas = new System.Windows.Forms.Label();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpbModalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbModalidades
            // 
            this.grpbModalidades.Controls.Add(this.btnConsultarMod);
            this.grpbModalidades.Controls.Add(this.btnAtualizar);
            this.grpbModalidades.Controls.Add(this.txtPreco);
            this.grpbModalidades.Controls.Add(this.txtQtdeAlunos);
            this.grpbModalidades.Controls.Add(this.txtQtdeAulas);
            this.grpbModalidades.Controls.Add(this.cmbDescricao);
            this.grpbModalidades.Controls.Add(this.lblQtdeAulas);
            this.grpbModalidades.Controls.Add(this.lblQtdeAlunos);
            this.grpbModalidades.Controls.Add(this.lblPreco);
            this.grpbModalidades.Controls.Add(this.lblDescricao);
            this.grpbModalidades.Location = new System.Drawing.Point(117, 111);
            this.grpbModalidades.Name = "grpbModalidades";
            this.grpbModalidades.Size = new System.Drawing.Size(374, 220);
            this.grpbModalidades.TabIndex = 0;
            this.grpbModalidades.TabStop = false;
            this.grpbModalidades.Text = "Modalidades";
            this.grpbModalidades.Enter += new System.EventHandler(this.grpbModalidades_Enter);
            // 
            // btnConsultarMod
            // 
            this.btnConsultarMod.Location = new System.Drawing.Point(98, 172);
            this.btnConsultarMod.Name = "btnConsultarMod";
            this.btnConsultarMod.Size = new System.Drawing.Size(227, 23);
            this.btnConsultarMod.TabIndex = 1;
            this.btnConsultarMod.Text = "Consultar";
            this.btnConsultarMod.UseVisualStyleBackColor = true;
            this.btnConsultarMod.Click += new System.EventHandler(this.btnConsultarMod_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(98, 144);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(227, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(98, 66);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(227, 20);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtQtdeAlunos
            // 
            this.txtQtdeAlunos.Location = new System.Drawing.Point(98, 92);
            this.txtQtdeAlunos.Name = "txtQtdeAlunos";
            this.txtQtdeAlunos.Size = new System.Drawing.Size(227, 20);
            this.txtQtdeAlunos.TabIndex = 6;
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(98, 118);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.Size = new System.Drawing.Size(227, 20);
            this.txtQtdeAulas.TabIndex = 5;
            // 
            // cmbDescricao
            // 
            this.cmbDescricao.FormattingEnabled = true;
            this.cmbDescricao.Location = new System.Drawing.Point(98, 39);
            this.cmbDescricao.Name = "cmbDescricao";
            this.cmbDescricao.Size = new System.Drawing.Size(227, 21);
            this.cmbDescricao.TabIndex = 4;
            // 
            // lblQtdeAulas
            // 
            this.lblQtdeAulas.AutoSize = true;
            this.lblQtdeAulas.Location = new System.Drawing.Point(30, 121);
            this.lblQtdeAulas.Name = "lblQtdeAulas";
            this.lblQtdeAulas.Size = new System.Drawing.Size(62, 13);
            this.lblQtdeAulas.TabIndex = 3;
            this.lblQtdeAulas.Text = "Qtde Aulas:";
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(24, 95);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(68, 13);
            this.lblQtdeAlunos.TabIndex = 2;
            this.lblQtdeAlunos.Text = "Qtde Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(54, 69);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(34, 42);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbModalidades);
            this.Name = "FormConsultar";
            this.Text = "Consultar Modalidade";
            this.Load += new System.EventHandler(this.FormConsultar_Load);
            this.grpbModalidades.ResumeLayout(false);
            this.grpbModalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbModalidades;
        private System.Windows.Forms.Label lblQtdeAulas;
        private System.Windows.Forms.Label lblQtdeAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtdeAlunos;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnConsultarMod;
    }
}