
namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label222222 = new System.Windows.Forms.Label();
            this.lblnota222 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAprovados = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.lblRecuperacao = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.limparlistas = new System.Windows.Forms.Button();
            this.listaRecuperacao = new System.Windows.Forms.ListBox();
            this.listaAprovados = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label222222
            // 
            this.label222222.AutoSize = true;
            this.label222222.BackColor = System.Drawing.Color.Transparent;
            this.label222222.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label222222.ForeColor = System.Drawing.SystemColors.Control;
            this.label222222.Location = new System.Drawing.Point(9, 127);
            this.label222222.Name = "label222222";
            this.label222222.Size = new System.Drawing.Size(49, 13);
            this.label222222.TabIndex = 0;
            this.label222222.Text = "Nota 1:";
            // 
            // lblnota222
            // 
            this.lblnota222.AutoSize = true;
            this.lblnota222.BackColor = System.Drawing.Color.Transparent;
            this.lblnota222.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota222.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnota222.Location = new System.Drawing.Point(9, 167);
            this.lblnota222.Name = "lblnota222";
            this.lblnota222.Size = new System.Drawing.Size(49, 13);
            this.lblnota222.TabIndex = 0;
            this.lblnota222.Text = "Nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nota 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.Location = new System.Drawing.Point(273, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Aprovados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label7.Location = new System.Drawing.Point(438, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Recuperação";
            // 
            // lblAprovados
            // 
            this.lblAprovados.AutoSize = true;
            this.lblAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblAprovados.Location = new System.Drawing.Point(320, 397);
            this.lblAprovados.Name = "lblAprovados";
            this.lblAprovados.Size = new System.Drawing.Size(27, 29);
            this.lblAprovados.TabIndex = 4;
            this.lblAprovados.Text = "0";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(61, 124);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(83, 20);
            this.txtNota1.TabIndex = 2;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(61, 165);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(83, 20);
            this.txtNota2.TabIndex = 3;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(61, 203);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(83, 20);
            this.txtNota3.TabIndex = 4;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(61, 246);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(83, 20);
            this.txtNota4.TabIndex = 5;
            // 
            // lblRecuperacao
            // 
            this.lblRecuperacao.AutoSize = true;
            this.lblRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblRecuperacao.Location = new System.Drawing.Point(501, 397);
            this.lblRecuperacao.Name = "lblRecuperacao";
            this.lblRecuperacao.Size = new System.Drawing.Size(27, 29);
            this.lblRecuperacao.TabIndex = 4;
            this.lblRecuperacao.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(54, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar notas";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(54, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // limparlistas
            // 
            this.limparlistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.limparlistas.ForeColor = System.Drawing.SystemColors.Control;
            this.limparlistas.Location = new System.Drawing.Point(54, 355);
            this.limparlistas.Name = "limparlistas";
            this.limparlistas.Size = new System.Drawing.Size(181, 23);
            this.limparlistas.TabIndex = 8;
            this.limparlistas.Text = "Limpar listas";
            this.limparlistas.UseVisualStyleBackColor = false;
            this.limparlistas.Click += new System.EventHandler(this.limparlistas_Click);
            // 
            // listaRecuperacao
            // 
            this.listaRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listaRecuperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listaRecuperacao.FormattingEnabled = true;
            this.listaRecuperacao.ItemHeight = 15;
            this.listaRecuperacao.Location = new System.Drawing.Point(444, 52);
            this.listaRecuperacao.Name = "listaRecuperacao";
            this.listaRecuperacao.Size = new System.Drawing.Size(149, 334);
            this.listaRecuperacao.TabIndex = 7;
            // 
            // listaAprovados
            // 
            this.listaAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listaAprovados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listaAprovados.FormattingEnabled = true;
            this.listaAprovados.ItemHeight = 15;
            this.listaAprovados.Location = new System.Drawing.Point(265, 52);
            this.listaAprovados.Name = "listaAprovados";
            this.listaAprovados.Size = new System.Drawing.Size(152, 334);
            this.listaAprovados.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(54, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular média";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calcular média ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 446);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(444, 446);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(626, 513);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaAprovados);
            this.Controls.Add(this.listaRecuperacao);
            this.Controls.Add(this.limparlistas);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblRecuperacao);
            this.Controls.Add(this.lblAprovados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnota222);
            this.Controls.Add(this.label222222);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label222222;
        private System.Windows.Forms.Label lblnota222;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAprovados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label lblRecuperacao;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button limparlistas;
        private System.Windows.Forms.ListBox listaRecuperacao;
        private System.Windows.Forms.ListBox listaAprovados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

