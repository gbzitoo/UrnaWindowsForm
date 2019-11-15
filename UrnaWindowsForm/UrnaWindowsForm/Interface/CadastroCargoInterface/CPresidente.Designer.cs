namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    partial class CPresidente
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
            this.bntCadastrarPresidente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumPresidente = new System.Windows.Forms.TextBox();
            this.txtNomePresidente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntCadastrarPresidente
            // 
            this.bntCadastrarPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastrarPresidente.Location = new System.Drawing.Point(341, 301);
            this.bntCadastrarPresidente.Name = "bntCadastrarPresidente";
            this.bntCadastrarPresidente.Size = new System.Drawing.Size(111, 36);
            this.bntCadastrarPresidente.TabIndex = 0;
            this.bntCadastrarPresidente.Text = "Cadastrar";
            this.bntCadastrarPresidente.UseVisualStyleBackColor = true;
            this.bntCadastrarPresidente.Click += new System.EventHandler(this.BntCadastrarPresidente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Candidato: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero do Candidato: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cadastrando Presidente";
            // 
            // txtNumPresidente
            // 
            this.txtNumPresidente.Location = new System.Drawing.Point(390, 178);
            this.txtNumPresidente.Name = "txtNumPresidente";
            this.txtNumPresidente.Size = new System.Drawing.Size(62, 20);
            this.txtNumPresidente.TabIndex = 4;
            // 
            // txtNomePresidente
            // 
            this.txtNomePresidente.Location = new System.Drawing.Point(374, 228);
            this.txtNomePresidente.Name = "txtNomePresidente";
            this.txtNomePresidente.Size = new System.Drawing.Size(267, 20);
            this.txtNomePresidente.TabIndex = 5;
            // 
            // CPresidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomePresidente);
            this.Controls.Add(this.txtNumPresidente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCadastrarPresidente);
            this.Name = "CPresidente";
            this.Text = "CPresidente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCadastrarPresidente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumPresidente;
        private System.Windows.Forms.TextBox txtNomePresidente;
    }
}