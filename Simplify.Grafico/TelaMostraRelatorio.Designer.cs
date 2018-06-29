namespace Simplify.Grafico
{
    partial class TelaMostraRelatorio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbProcessoCadastrados = new System.Windows.Forms.Label();
            this.lbProcessoAprovados = new System.Windows.Forms.Label();
            this.lbProcessoNegados = new System.Windows.Forms.Label();
            this.lbProcessoEnviados = new System.Windows.Forms.Label();
            this.lbProcessoPendentes = new System.Windows.Forms.Label();
            this.lbProcessoConcluidos = new System.Windows.Forms.Label();
            this.lbDTInicio = new System.Windows.Forms.Label();
            this.lbDTFinal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDTFinal);
            this.panel1.Controls.Add(this.lbDTInicio);
            this.panel1.Controls.Add(this.lbProcessoConcluidos);
            this.panel1.Controls.Add(this.lbProcessoPendentes);
            this.panel1.Controls.Add(this.lbProcessoEnviados);
            this.panel1.Controls.Add(this.lbProcessoNegados);
            this.panel1.Controls.Add(this.lbProcessoAprovados);
            this.panel1.Controls.Add(this.lbProcessoCadastrados);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 395);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Ínicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Processos Cadastrados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Processos Concluídos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Processos Pendentes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Processos Negados";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Processos Aprovados";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Processos Enviados";
            // 
            // lbProcessoCadastrados
            // 
            this.lbProcessoCadastrados.AutoSize = true;
            this.lbProcessoCadastrados.Location = new System.Drawing.Point(169, 135);
            this.lbProcessoCadastrados.Name = "lbProcessoCadastrados";
            this.lbProcessoCadastrados.Size = new System.Drawing.Size(10, 13);
            this.lbProcessoCadastrados.TabIndex = 9;
            this.lbProcessoCadastrados.Text = "-";
            // 
            // lbProcessoAprovados
            // 
            this.lbProcessoAprovados.AutoSize = true;
            this.lbProcessoAprovados.Location = new System.Drawing.Point(169, 162);
            this.lbProcessoAprovados.Name = "lbProcessoAprovados";
            this.lbProcessoAprovados.Size = new System.Drawing.Size(10, 13);
            this.lbProcessoAprovados.TabIndex = 10;
            this.lbProcessoAprovados.Text = "-";
            // 
            // lbProcessoNegados
            // 
            this.lbProcessoNegados.AutoSize = true;
            this.lbProcessoNegados.Location = new System.Drawing.Point(169, 184);
            this.lbProcessoNegados.Name = "lbProcessoNegados";
            this.lbProcessoNegados.Size = new System.Drawing.Size(10, 13);
            this.lbProcessoNegados.TabIndex = 11;
            this.lbProcessoNegados.Text = "-";
            // 
            // lbProcessoEnviados
            // 
            this.lbProcessoEnviados.AutoSize = true;
            this.lbProcessoEnviados.Location = new System.Drawing.Point(169, 206);
            this.lbProcessoEnviados.Name = "lbProcessoEnviados";
            this.lbProcessoEnviados.Size = new System.Drawing.Size(10, 13);
            this.lbProcessoEnviados.TabIndex = 12;
            this.lbProcessoEnviados.Text = "-";
            // 
            // lbProcessoPendentes
            // 
            this.lbProcessoPendentes.AutoSize = true;
            this.lbProcessoPendentes.Location = new System.Drawing.Point(169, 230);
            this.lbProcessoPendentes.Name = "lbProcessoPendentes";
            this.lbProcessoPendentes.Size = new System.Drawing.Size(10, 13);
            this.lbProcessoPendentes.TabIndex = 13;
            this.lbProcessoPendentes.Text = "-";
            // 
            // lbProcessoConcluidos
            // 
            this.lbProcessoConcluidos.AutoSize = true;
            this.lbProcessoConcluidos.Location = new System.Drawing.Point(169, 258);
            this.lbProcessoConcluidos.Name = "lbProcessoConcluidos";
            this.lbProcessoConcluidos.Size = new System.Drawing.Size(10, 13);
            this.lbProcessoConcluidos.TabIndex = 14;
            this.lbProcessoConcluidos.Text = "-";
            // 
            // lbDTInicio
            // 
            this.lbDTInicio.AutoSize = true;
            this.lbDTInicio.Location = new System.Drawing.Point(94, 56);
            this.lbDTInicio.Name = "lbDTInicio";
            this.lbDTInicio.Size = new System.Drawing.Size(41, 13);
            this.lbDTInicio.TabIndex = 15;
            this.lbDTInicio.Text = "--/--/----";
            // 
            // lbDTFinal
            // 
            this.lbDTFinal.AutoSize = true;
            this.lbDTFinal.Location = new System.Drawing.Point(321, 56);
            this.lbDTFinal.Name = "lbDTFinal";
            this.lbDTFinal.Size = new System.Drawing.Size(41, 13);
            this.lbDTFinal.TabIndex = 16;
            this.lbDTFinal.Text = "--/--/----";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salvar PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaMostraRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(423, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "TelaMostraRelatorio";
            this.Text = "TelaMostraRelatorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDTFinal;
        private System.Windows.Forms.Label lbDTInicio;
        private System.Windows.Forms.Label lbProcessoConcluidos;
        private System.Windows.Forms.Label lbProcessoPendentes;
        private System.Windows.Forms.Label lbProcessoEnviados;
        private System.Windows.Forms.Label lbProcessoNegados;
        private System.Windows.Forms.Label lbProcessoAprovados;
        private System.Windows.Forms.Label lbProcessoCadastrados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}