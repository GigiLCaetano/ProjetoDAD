namespace Estudio
{
    partial class Form4
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
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.mskCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.AutoSize = true;
            this.lblCpfAluno.Location = new System.Drawing.Point(62, 51);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(30, 13);
            this.lblCpfAluno.TabIndex = 0;
            this.lblCpfAluno.Text = "CPF:";
            this.lblCpfAluno.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskCpfAluno
            // 
            this.mskCpfAluno.Location = new System.Drawing.Point(98, 48);
            this.mskCpfAluno.Mask = "999.999.99-99";
            this.mskCpfAluno.Name = "mskCpfAluno";
            this.mskCpfAluno.Size = new System.Drawing.Size(78, 20);
            this.mskCpfAluno.TabIndex = 1;
            this.mskCpfAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCpfAluno_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskCpfAluno);
            this.Controls.Add(this.lblCpfAluno);
            this.Name = "Form4";
            this.Text = "Excluir Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.MaskedTextBox mskCpfAluno;
    }
}