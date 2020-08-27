namespace UnificadorAccera
{
    partial class UnificadorAccera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnificadorAccera));
            this.btnBuscaM = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnBuscaF = new System.Windows.Forms.Button();
            this.lbLocalM = new System.Windows.Forms.Label();
            this.lbLocalF = new System.Windows.Forms.Label();
            this.lbLocalFinal = new System.Windows.Forms.Label();
            this.btnDestino = new System.Windows.Forms.Button();
            this.lbLocalD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscaM
            // 
            this.btnBuscaM.Location = new System.Drawing.Point(12, 18);
            this.btnBuscaM.Name = "btnBuscaM";
            this.btnBuscaM.Size = new System.Drawing.Size(274, 23);
            this.btnBuscaM.TabIndex = 0;
            this.btnBuscaM.Text = "Buscar Local da Matriz";
            this.btnBuscaM.UseVisualStyleBackColor = true;
            this.btnBuscaM.Click += new System.EventHandler(this.btnBuscaM_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 162);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(274, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar Arquivo Unificado";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnBuscaF
            // 
            this.btnBuscaF.Location = new System.Drawing.Point(12, 65);
            this.btnBuscaF.Name = "btnBuscaF";
            this.btnBuscaF.Size = new System.Drawing.Size(274, 23);
            this.btnBuscaF.TabIndex = 4;
            this.btnBuscaF.Text = "Buscar Local da Filial";
            this.btnBuscaF.UseVisualStyleBackColor = true;
            this.btnBuscaF.Click += new System.EventHandler(this.btnBuscaF_Click);
            // 
            // lbLocalM
            // 
            this.lbLocalM.AutoSize = true;
            this.lbLocalM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalM.Location = new System.Drawing.Point(12, 46);
            this.lbLocalM.Name = "lbLocalM";
            this.lbLocalM.Size = new System.Drawing.Size(0, 17);
            this.lbLocalM.TabIndex = 5;
            // 
            // lbLocalF
            // 
            this.lbLocalF.AutoSize = true;
            this.lbLocalF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalF.Location = new System.Drawing.Point(12, 95);
            this.lbLocalF.Name = "lbLocalF";
            this.lbLocalF.Size = new System.Drawing.Size(0, 17);
            this.lbLocalF.TabIndex = 6;
            // 
            // lbLocalFinal
            // 
            this.lbLocalFinal.AutoSize = true;
            this.lbLocalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalFinal.Location = new System.Drawing.Point(12, 142);
            this.lbLocalFinal.Name = "lbLocalFinal";
            this.lbLocalFinal.Size = new System.Drawing.Size(0, 17);
            this.lbLocalFinal.TabIndex = 7;
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(12, 115);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(274, 23);
            this.btnDestino.TabIndex = 8;
            this.btnDestino.Text = "Local de Destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // lbLocalD
            // 
            this.lbLocalD.AutoSize = true;
            this.lbLocalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalD.Location = new System.Drawing.Point(19, 143);
            this.lbLocalD.Name = "lbLocalD";
            this.lbLocalD.Size = new System.Drawing.Size(0, 17);
            this.lbLocalD.TabIndex = 9;
            // 
            // UnificadorAccera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 215);
            this.Controls.Add(this.lbLocalD);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.lbLocalFinal);
            this.Controls.Add(this.lbLocalF);
            this.Controls.Add(this.lbLocalM);
            this.Controls.Add(this.btnBuscaF);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnBuscaM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnificadorAccera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unificador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaM;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnBuscaF;
        private System.Windows.Forms.Label lbLocalM;
        private System.Windows.Forms.Label lbLocalF;
        private System.Windows.Forms.Label lbLocalFinal;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Label lbLocalD;
    }
}

