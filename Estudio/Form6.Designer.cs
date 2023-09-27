
namespace Estudio
{
    partial class Form6
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
            this.btnExcluirMod = new System.Windows.Forms.Button();
            this.cmbDescricaoMod = new System.Windows.Forms.ComboBox();
            this.lblDescricaoMod = new System.Windows.Forms.Label();
            this.grpbModalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbModalidades
            // 
            this.grpbModalidades.Controls.Add(this.btnExcluirMod);
            this.grpbModalidades.Controls.Add(this.cmbDescricaoMod);
            this.grpbModalidades.Controls.Add(this.lblDescricaoMod);
            this.grpbModalidades.Location = new System.Drawing.Point(156, 110);
            this.grpbModalidades.Name = "grpbModalidades";
            this.grpbModalidades.Size = new System.Drawing.Size(328, 133);
            this.grpbModalidades.TabIndex = 0;
            this.grpbModalidades.TabStop = false;
            this.grpbModalidades.Text = "Modalidades";
            this.grpbModalidades.Enter += new System.EventHandler(this.grpbModalidades_Enter);
            // 
            // btnExcluirMod
            // 
            this.btnExcluirMod.Location = new System.Drawing.Point(79, 78);
            this.btnExcluirMod.Name = "btnExcluirMod";
            this.btnExcluirMod.Size = new System.Drawing.Size(212, 23);
            this.btnExcluirMod.TabIndex = 2;
            this.btnExcluirMod.Text = "Excluir";
            this.btnExcluirMod.UseVisualStyleBackColor = true;
            this.btnExcluirMod.Click += new System.EventHandler(this.btnExcluirMod_Click);
            // 
            // cmbDescricaoMod
            // 
            this.cmbDescricaoMod.FormattingEnabled = true;
            this.cmbDescricaoMod.Location = new System.Drawing.Point(79, 51);
            this.cmbDescricaoMod.Name = "cmbDescricaoMod";
            this.cmbDescricaoMod.Size = new System.Drawing.Size(212, 21);
            this.cmbDescricaoMod.TabIndex = 1;
            // 
            // lblDescricaoMod
            // 
            this.lblDescricaoMod.AutoSize = true;
            this.lblDescricaoMod.Location = new System.Drawing.Point(18, 51);
            this.lblDescricaoMod.Name = "lblDescricaoMod";
            this.lblDescricaoMod.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoMod.TabIndex = 1;
            this.lblDescricaoMod.Text = "Descrição:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbModalidades);
            this.Name = "Form6";
            this.Text = "Excluir Modalidade";
            this.grpbModalidades.ResumeLayout(false);
            this.grpbModalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbModalidades;
        private System.Windows.Forms.Button btnExcluirMod;
        private System.Windows.Forms.ComboBox cmbDescricaoMod;
        private System.Windows.Forms.Label lblDescricaoMod;
    }
}