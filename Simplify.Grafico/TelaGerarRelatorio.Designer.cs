namespace Simplify.Grafico
{
    partial class TelaGerarRelatorio
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.dtpDataFimRelatorio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicioRelatorio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSuatusProcesso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnResultado = new System.Windows.Forms.Panel();
            this.btImprimirRelatorio = new System.Windows.Forms.Button();
            this.pdRelatorio = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.pnResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btGerarRelatorio);
            this.panel1.Controls.Add(this.dtpDataFimRelatorio);
            this.panel1.Controls.Add(this.dtpDataInicioRelatorio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSuatusProcesso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 599);
            this.panel1.TabIndex = 0;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(291, 564);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 25);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Location = new System.Drawing.Point(212, 564);
            this.btGerarRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(75, 25);
            this.btGerarRelatorio.TabIndex = 7;
            this.btGerarRelatorio.Text = "Gerar";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // dtpDataFimRelatorio
            // 
            this.dtpDataFimRelatorio.Location = new System.Drawing.Point(134, 275);
            this.dtpDataFimRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataFimRelatorio.Name = "dtpDataFimRelatorio";
            this.dtpDataFimRelatorio.Size = new System.Drawing.Size(151, 20);
            this.dtpDataFimRelatorio.TabIndex = 6;
            // 
            // dtpDataInicioRelatorio
            // 
            this.dtpDataInicioRelatorio.Location = new System.Drawing.Point(134, 194);
            this.dtpDataInicioRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataInicioRelatorio.Name = "dtpDataInicioRelatorio";
            this.dtpDataInicioRelatorio.Size = new System.Drawing.Size(151, 20);
            this.dtpDataInicioRelatorio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Início:";
            // 
            // cbSuatusProcesso
            // 
            this.cbSuatusProcesso.FormattingEnabled = true;
            this.cbSuatusProcesso.Location = new System.Drawing.Point(134, 113);
            this.cbSuatusProcesso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSuatusProcesso.Name = "cbSuatusProcesso";
            this.cbSuatusProcesso.Size = new System.Drawing.Size(151, 21);
            this.cbSuatusProcesso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status do Processo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatórios";
            // 
            // pnResultado
            // 
            this.pnResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.pnResultado.Controls.Add(this.btImprimirRelatorio);
            this.pnResultado.Location = new System.Drawing.Point(378, 2);
            this.pnResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnResultado.Name = "pnResultado";
            this.pnResultado.Size = new System.Drawing.Size(357, 599);
            this.pnResultado.TabIndex = 1;
            this.pnResultado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnResultado_Paint);
            // 
            // btImprimirRelatorio
            // 
            this.btImprimirRelatorio.Location = new System.Drawing.Point(274, 566);
            this.btImprimirRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btImprimirRelatorio.Name = "btImprimirRelatorio";
            this.btImprimirRelatorio.Size = new System.Drawing.Size(75, 25);
            this.btImprimirRelatorio.TabIndex = 0;
            this.btImprimirRelatorio.Text = "Imprimir";
            this.btImprimirRelatorio.UseVisualStyleBackColor = true;
            // 
            // pdRelatorio
            // 
            this.pdRelatorio.UseEXDialog = true;
            // 
            // TelaGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(738, 602);
            this.Controls.Add(this.pnResultado);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 648);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 605);
            this.Name = "TelaGerarRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaGerarRelatorio_FormClosing);
            this.Load += new System.EventHandler(this.TelaGerarRelatorio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataFimRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataInicioRelatorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSuatusProcesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnResultado;
        private System.Windows.Forms.Button btImprimirRelatorio;
        private System.Windows.Forms.PrintDialog pdRelatorio;
    }
}