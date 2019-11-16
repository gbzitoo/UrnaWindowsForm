namespace UrnaWindowsForm.Interface.CargoEleitoralInterface
{
    partial class Presidente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumPresidente = new System.Windows.Forms.TextBox();
            this.txtNomePresidente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumBuscaPresidente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero do Candidato: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Candidato: ";
            // 
            // txtNumPresidente
            // 
            this.txtNumPresidente.Location = new System.Drawing.Point(494, 188);
            this.txtNumPresidente.Name = "txtNumPresidente";
            this.txtNumPresidente.Size = new System.Drawing.Size(100, 20);
            this.txtNumPresidente.TabIndex = 3;
            // 
            // txtNomePresidente
            // 
            this.txtNomePresidente.Location = new System.Drawing.Point(494, 225);
            this.txtNomePresidente.Name = "txtNomePresidente";
            this.txtNomePresidente.Size = new System.Drawing.Size(100, 20);
            this.txtNomePresidente.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtNumBuscaPresidente
            // 
            this.txtNumBuscaPresidente.Location = new System.Drawing.Point(411, 101);
            this.txtNumBuscaPresidente.Name = "txtNumBuscaPresidente";
            this.txtNumBuscaPresidente.Size = new System.Drawing.Size(55, 20);
            this.txtNumBuscaPresidente.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pesquisar Candidato: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Informações do Candidato: ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(348, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Votar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UrnaWindowsForm.Properties.Resources.candidata;
            this.pictureBox1.Location = new System.Drawing.Point(233, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 97);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Votação para Presidente";
            // 
            // Presidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumBuscaPresidente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomePresidente);
            this.Controls.Add(this.txtNumPresidente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Presidente";
            this.Text = "Presidente";
            this.Load += new System.EventHandler(this.Presidente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumPresidente;
        private System.Windows.Forms.TextBox txtNomePresidente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumBuscaPresidente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}