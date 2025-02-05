namespace projeto_calendario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.txt_inicial = new System.Windows.Forms.TextBox();
            this.txt_atual = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_inicial2 = new System.Windows.Forms.TextBox();
            this.txt_final2 = new System.Windows.Forms.TextBox();
            this.txt_atual2 = new System.Windows.Forms.TextBox();
            this.CalendarioIcone = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 49);
            this.monthCalendar.MaxSelectionCount = 30;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Inicial:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Atual:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Final:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.BackColor = System.Drawing.Color.HotPink;
            this.btn_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionar.ForeColor = System.Drawing.Color.White;
            this.btn_selecionar.Location = new System.Drawing.Point(260, 163);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(199, 31);
            this.btn_selecionar.TabIndex = 5;
            this.btn_selecionar.Text = "Selecionar Dia";
            this.btn_selecionar.UseVisualStyleBackColor = false;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // txt_inicial
            // 
            this.txt_inicial.Location = new System.Drawing.Point(359, 62);
            this.txt_inicial.Name = "txt_inicial";
            this.txt_inicial.Size = new System.Drawing.Size(100, 20);
            this.txt_inicial.TabIndex = 6;
            this.txt_inicial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_atual
            // 
            this.txt_atual.Location = new System.Drawing.Point(359, 126);
            this.txt_atual.Name = "txt_atual";
            this.txt_atual.Size = new System.Drawing.Size(100, 20);
            this.txt_atual.TabIndex = 7;
            this.txt_atual.TextChanged += new System.EventHandler(this.txt_atual_TextChanged);
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(359, 94);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(100, 20);
            this.txt_final.TabIndex = 8;
            this.txt_final.TextChanged += new System.EventHandler(this.txt_final_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleção automática:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Atual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data Inicial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Seleção pelo calendário:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_inicial2
            // 
            this.txt_inicial2.Location = new System.Drawing.Point(127, 283);
            this.txt_inicial2.Name = "txt_inicial2";
            this.txt_inicial2.Size = new System.Drawing.Size(100, 20);
            this.txt_inicial2.TabIndex = 14;
            // 
            // txt_final2
            // 
            this.txt_final2.Location = new System.Drawing.Point(127, 315);
            this.txt_final2.Name = "txt_final2";
            this.txt_final2.Size = new System.Drawing.Size(100, 20);
            this.txt_final2.TabIndex = 15;
            // 
            // txt_atual2
            // 
            this.txt_atual2.Location = new System.Drawing.Point(127, 349);
            this.txt_atual2.Name = "txt_atual2";
            this.txt_atual2.Size = new System.Drawing.Size(100, 20);
            this.txt_atual2.TabIndex = 16;
            // 
            // CalendarioIcone
            // 
            this.CalendarioIcone.ContextMenuStrip = this.contextMenuStrip1;
            this.CalendarioIcone.Icon = ((System.Drawing.Icon)(resources.GetObject("CalendarioIcone.Icon")));
            this.CalendarioIcone.Text = "Calendario";
            this.CalendarioIcone.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restaurar,
            this.Mensagem,
            this.Fechar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // Restaurar
            // 
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(180, 22);
            this.Restaurar.Text = "Restaurar";
            // 
            // Mensagem
            // 
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(180, 22);
            this.Mensagem.Text = "Mensagem";
            // 
            // Fechar
            // 
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(180, 22);
            this.Fechar.Text = "Fechar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 386);
            this.Controls.Add(this.txt_atual2);
            this.Controls.Add(this.txt_final2);
            this.Controls.Add(this.txt_inicial2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.txt_atual);
            this.Controls.Add(this.txt_inicial);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.TextBox txt_inicial;
        private System.Windows.Forms.TextBox txt_atual;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_inicial2;
        private System.Windows.Forms.TextBox txt_final2;
        private System.Windows.Forms.TextBox txt_atual2;
        private System.Windows.Forms.NotifyIcon CalendarioIcone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Restaurar;
        private System.Windows.Forms.ToolStripMenuItem Mensagem;
        private System.Windows.Forms.ToolStripMenuItem Fechar;
    }
}

