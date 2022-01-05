namespace AplicativoBanhoeTosa
{
    partial class frm_Trabalho
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
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.tbox_Cod_Trabalho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Nm_Servico = new System.Windows.Forms.Label();
            this.btn_Servico = new System.Windows.Forms.Button();
            this.btn_Cachorro = new System.Windows.Forms.Button();
            this.lb_Nm_Cachorro = new System.Windows.Forms.Label();
            this.lb_Nm_Dono = new System.Windows.Forms.Label();
            this.btn_Dono = new System.Windows.Forms.Button();
            this.tbox_Cod_Servico = new System.Windows.Forms.TextBox();
            this.tbox_Cod_Cachorro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_Cod_Dono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_Hr_Trabalho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_Data_Trabalho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbox_Trabalhos = new System.Windows.Forms.ListBox();
            this.pnl_Button.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Detalhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Novo.Location = new System.Drawing.Point(12, 13);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(71, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Alterar.Location = new System.Drawing.Point(89, 13);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(71, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Excluir.Location = new System.Drawing.Point(166, 13);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(71, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Cancelar.Location = new System.Drawing.Point(336, 13);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(71, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Confirmar.Location = new System.Drawing.Point(259, 13);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(71, 23);
            this.btn_Confirmar.TabIndex = 4;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl_Button.Controls.Add(this.btn_Confirmar);
            this.pnl_Button.Controls.Add(this.btn_Cancelar);
            this.pnl_Button.Controls.Add(this.btn_Excluir);
            this.pnl_Button.Controls.Add(this.btn_Alterar);
            this.pnl_Button.Controls.Add(this.btn_Novo);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Button.Location = new System.Drawing.Point(0, 235);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(419, 46);
            this.pnl_Button.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trabalhos";
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl_Titulo.Controls.Add(this.label4);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(419, 71);
            this.pnl_Titulo.TabIndex = 13;
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Trabalho);
            this.pnl_Detalhe.Controls.Add(this.label2);
            this.pnl_Detalhe.Controls.Add(this.label1);
            this.pnl_Detalhe.Controls.Add(this.lb_Nm_Servico);
            this.pnl_Detalhe.Controls.Add(this.btn_Servico);
            this.pnl_Detalhe.Controls.Add(this.btn_Cachorro);
            this.pnl_Detalhe.Controls.Add(this.lb_Nm_Cachorro);
            this.pnl_Detalhe.Controls.Add(this.lb_Nm_Dono);
            this.pnl_Detalhe.Controls.Add(this.btn_Dono);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Servico);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Cachorro);
            this.pnl_Detalhe.Controls.Add(this.label10);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Dono);
            this.pnl_Detalhe.Controls.Add(this.label9);
            this.pnl_Detalhe.Controls.Add(this.tbox_Hr_Trabalho);
            this.pnl_Detalhe.Controls.Add(this.label8);
            this.pnl_Detalhe.Controls.Add(this.tbox_Data_Trabalho);
            this.pnl_Detalhe.Controls.Add(this.label7);
            this.pnl_Detalhe.Location = new System.Drawing.Point(70, 62);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(377, 173);
            this.pnl_Detalhe.TabIndex = 15;
            // 
            // tbox_Cod_Trabalho
            // 
            this.tbox_Cod_Trabalho.Location = new System.Drawing.Point(9, 27);
            this.tbox_Cod_Trabalho.Name = "tbox_Cod_Trabalho";
            this.tbox_Cod_Trabalho.Size = new System.Drawing.Size(40, 20);
            this.tbox_Cod_Trabalho.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Serviço";
            // 
            // lb_Nm_Servico
            // 
            this.lb_Nm_Servico.BackColor = System.Drawing.Color.Silver;
            this.lb_Nm_Servico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Nm_Servico.Location = new System.Drawing.Point(101, 147);
            this.lb_Nm_Servico.Name = "lb_Nm_Servico";
            this.lb_Nm_Servico.Size = new System.Drawing.Size(179, 15);
            this.lb_Nm_Servico.TabIndex = 56;
            this.lb_Nm_Servico.Tag = "1";
            // 
            // btn_Servico
            // 
            this.btn_Servico.BackgroundImage = global::AplicativoBanhoeTosa.Properties.Resources.Screenshot_1;
            this.btn_Servico.Location = new System.Drawing.Point(73, 143);
            this.btn_Servico.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Servico.Name = "btn_Servico";
            this.btn_Servico.Size = new System.Drawing.Size(23, 22);
            this.btn_Servico.TabIndex = 52;
            this.btn_Servico.UseVisualStyleBackColor = true;
            this.btn_Servico.Click += new System.EventHandler(this.btn_Servico_Click_1);
            // 
            // btn_Cachorro
            // 
            this.btn_Cachorro.BackgroundImage = global::AplicativoBanhoeTosa.Properties.Resources.Screenshot_1;
            this.btn_Cachorro.Location = new System.Drawing.Point(73, 106);
            this.btn_Cachorro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cachorro.Name = "btn_Cachorro";
            this.btn_Cachorro.Size = new System.Drawing.Size(23, 22);
            this.btn_Cachorro.TabIndex = 51;
            this.btn_Cachorro.UseVisualStyleBackColor = true;
            this.btn_Cachorro.Click += new System.EventHandler(this.btn_Cachorro_Click_1);
            // 
            // lb_Nm_Cachorro
            // 
            this.lb_Nm_Cachorro.BackColor = System.Drawing.Color.Silver;
            this.lb_Nm_Cachorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Nm_Cachorro.Location = new System.Drawing.Point(101, 110);
            this.lb_Nm_Cachorro.Name = "lb_Nm_Cachorro";
            this.lb_Nm_Cachorro.Size = new System.Drawing.Size(178, 15);
            this.lb_Nm_Cachorro.TabIndex = 49;
            this.lb_Nm_Cachorro.Tag = "1";
            // 
            // lb_Nm_Dono
            // 
            this.lb_Nm_Dono.BackColor = System.Drawing.Color.Silver;
            this.lb_Nm_Dono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Nm_Dono.Location = new System.Drawing.Point(101, 71);
            this.lb_Nm_Dono.Name = "lb_Nm_Dono";
            this.lb_Nm_Dono.Size = new System.Drawing.Size(179, 15);
            this.lb_Nm_Dono.TabIndex = 48;
            this.lb_Nm_Dono.Tag = "1";
            this.lb_Nm_Dono.Click += new System.EventHandler(this.lb_Nm_Autor_Click);
            // 
            // btn_Dono
            // 
            this.btn_Dono.BackgroundImage = global::AplicativoBanhoeTosa.Properties.Resources.Screenshot_1;
            this.btn_Dono.Location = new System.Drawing.Point(73, 67);
            this.btn_Dono.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dono.Name = "btn_Dono";
            this.btn_Dono.Size = new System.Drawing.Size(23, 22);
            this.btn_Dono.TabIndex = 47;
            this.btn_Dono.UseVisualStyleBackColor = true;
            this.btn_Dono.Click += new System.EventHandler(this.btn_Dono_Click);
            // 
            // tbox_Cod_Servico
            // 
            this.tbox_Cod_Servico.Location = new System.Drawing.Point(9, 145);
            this.tbox_Cod_Servico.Name = "tbox_Cod_Servico";
            this.tbox_Cod_Servico.Size = new System.Drawing.Size(62, 20);
            this.tbox_Cod_Servico.TabIndex = 46;
            this.tbox_Cod_Servico.Tag = "0";
            this.tbox_Cod_Servico.Leave += new System.EventHandler(this.tbox_Cod_Servico_Leave_1);
            // 
            // tbox_Cod_Cachorro
            // 
            this.tbox_Cod_Cachorro.Location = new System.Drawing.Point(9, 106);
            this.tbox_Cod_Cachorro.Name = "tbox_Cod_Cachorro";
            this.tbox_Cod_Cachorro.Size = new System.Drawing.Size(62, 20);
            this.tbox_Cod_Cachorro.TabIndex = 45;
            this.tbox_Cod_Cachorro.Tag = "0";
            this.tbox_Cod_Cachorro.Leave += new System.EventHandler(this.tbox_Cod_Cachorro_Leave_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Cachorro";
            // 
            // tbox_Cod_Dono
            // 
            this.tbox_Cod_Dono.Location = new System.Drawing.Point(8, 67);
            this.tbox_Cod_Dono.Name = "tbox_Cod_Dono";
            this.tbox_Cod_Dono.Size = new System.Drawing.Size(63, 20);
            this.tbox_Cod_Dono.TabIndex = 43;
            this.tbox_Cod_Dono.Tag = "0";
            this.tbox_Cod_Dono.Leave += new System.EventHandler(this.tbox_Cod_Dono_Leave_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Dono";
            // 
            // tbox_Hr_Trabalho
            // 
            this.tbox_Hr_Trabalho.Location = new System.Drawing.Point(130, 27);
            this.tbox_Hr_Trabalho.Name = "tbox_Hr_Trabalho";
            this.tbox_Hr_Trabalho.Size = new System.Drawing.Size(85, 20);
            this.tbox_Hr_Trabalho.TabIndex = 41;
            this.tbox_Hr_Trabalho.Tag = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Data";
            // 
            // tbox_Data_Trabalho
            // 
            this.tbox_Data_Trabalho.Location = new System.Drawing.Point(55, 27);
            this.tbox_Data_Trabalho.Name = "tbox_Data_Trabalho";
            this.tbox_Data_Trabalho.Size = new System.Drawing.Size(69, 20);
            this.tbox_Data_Trabalho.TabIndex = 39;
            this.tbox_Data_Trabalho.Tag = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Hora";
            // 
            // lbox_Trabalhos
            // 
            this.lbox_Trabalhos.FormattingEnabled = true;
            this.lbox_Trabalhos.Location = new System.Drawing.Point(0, 62);
            this.lbox_Trabalhos.Name = "lbox_Trabalhos";
            this.lbox_Trabalhos.Size = new System.Drawing.Size(74, 173);
            this.lbox_Trabalhos.TabIndex = 5;
            this.lbox_Trabalhos.Click += new System.EventHandler(this.lbox_Trabalhos_Click);
            // 
            // frm_Trabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 281);
            this.Controls.Add(this.lbox_Trabalhos);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.pnl_Button);
            this.Name = "frm_Trabalho";
            this.Text = "Trabalhos";
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Panel pnl_Detalhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Nm_Servico;
        private System.Windows.Forms.Button btn_Servico;
        private System.Windows.Forms.Button btn_Cachorro;
        private System.Windows.Forms.Label lb_Nm_Cachorro;
        private System.Windows.Forms.Label lb_Nm_Dono;
        private System.Windows.Forms.Button btn_Dono;
        private System.Windows.Forms.TextBox tbox_Cod_Servico;
        private System.Windows.Forms.TextBox tbox_Cod_Cachorro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Cod_Dono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_Hr_Trabalho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_Data_Trabalho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbox_Trabalhos;
        private System.Windows.Forms.TextBox tbox_Cod_Trabalho;
        private System.Windows.Forms.Label label2;
    }
}