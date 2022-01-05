namespace AplicativoBanhoeTosa
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.mstrip_Principal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cachorroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarTrabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_Principal = new System.Windows.Forms.Timer(this.components);
            this.sstrip_Principal = new System.Windows.Forms.StatusStrip();
            this.tssLabel_Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabel_Espaco1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabel_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabel_HrAgora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabel_Espaco2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabel_Sobre = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabel_DtAgora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mstrip_Principal.SuspendLayout();
            this.sstrip_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mstrip_Principal
            // 
            this.mstrip_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendarTrabalhoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.mstrip_Principal.Name = "mstrip_Principal";
            this.mstrip_Principal.Size = new System.Drawing.Size(737, 24);
            this.mstrip_Principal.TabIndex = 0;
            this.mstrip_Principal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donoToolStripMenuItem,
            this.cachorroToolStripMenuItem,
            this.serviçoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // donoToolStripMenuItem
            // 
            this.donoToolStripMenuItem.Name = "donoToolStripMenuItem";
            this.donoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.donoToolStripMenuItem.Text = "Dono";
            this.donoToolStripMenuItem.Click += new System.EventHandler(this.donoToolStripMenuItem_Click);
            // 
            // cachorroToolStripMenuItem
            // 
            this.cachorroToolStripMenuItem.Name = "cachorroToolStripMenuItem";
            this.cachorroToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cachorroToolStripMenuItem.Text = "Cachorro";
            this.cachorroToolStripMenuItem.Click += new System.EventHandler(this.cachorroToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // agendarTrabalhoToolStripMenuItem
            // 
            this.agendarTrabalhoToolStripMenuItem.Name = "agendarTrabalhoToolStripMenuItem";
            this.agendarTrabalhoToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.agendarTrabalhoToolStripMenuItem.Text = "Agendar Trabalho";
            this.agendarTrabalhoToolStripMenuItem.Click += new System.EventHandler(this.agendarTrabalhoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // tim_Principal
            // 
            this.tim_Principal.Enabled = true;
            this.tim_Principal.Tick += new System.EventHandler(this.tim_Principal_Tick);
            // 
            // sstrip_Principal
            // 
            this.sstrip_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sstrip_Principal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel_Data,
            this.tssLabel_DtAgora,
            this.tssLabel_Espaco1,
            this.tssLabel_Hora,
            this.tssLabel_HrAgora,
            this.tssLabel_Espaco2,
            this.tssLabel_Sobre});
            this.sstrip_Principal.Location = new System.Drawing.Point(0, 363);
            this.sstrip_Principal.Name = "sstrip_Principal";
            this.sstrip_Principal.Size = new System.Drawing.Size(737, 30);
            this.sstrip_Principal.TabIndex = 2;
            this.sstrip_Principal.Text = "statusStrip1";
            // 
            // tssLabel_Data
            // 
            this.tssLabel_Data.AutoSize = false;
            this.tssLabel_Data.Name = "tssLabel_Data";
            this.tssLabel_Data.Size = new System.Drawing.Size(34, 25);
            this.tssLabel_Data.Text = "Data:";
            // 
            // tssLabel_Espaco1
            // 
            this.tssLabel_Espaco1.AutoSize = false;
            this.tssLabel_Espaco1.Name = "tssLabel_Espaco1";
            this.tssLabel_Espaco1.Size = new System.Drawing.Size(118, 25);
            // 
            // tssLabel_Hora
            // 
            this.tssLabel_Hora.AutoSize = false;
            this.tssLabel_Hora.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.tssLabel_Hora.Name = "tssLabel_Hora";
            this.tssLabel_Hora.Size = new System.Drawing.Size(39, 25);
            this.tssLabel_Hora.Text = "Hora: ";
            // 
            // tssLabel_HrAgora
            // 
            this.tssLabel_HrAgora.AutoSize = false;
            this.tssLabel_HrAgora.Name = "tssLabel_HrAgora";
            this.tssLabel_HrAgora.Size = new System.Drawing.Size(49, 25);
            this.tssLabel_HrAgora.Text = "99:99:99";
            // 
            // tssLabel_Espaco2
            // 
            this.tssLabel_Espaco2.AutoSize = false;
            this.tssLabel_Espaco2.Name = "tssLabel_Espaco2";
            this.tssLabel_Espaco2.Size = new System.Drawing.Size(228, 25);
            // 
            // tssLabel_Sobre
            // 
            this.tssLabel_Sobre.Name = "tssLabel_Sobre";
            this.tssLabel_Sobre.Size = new System.Drawing.Size(63, 25);
            this.tssLabel_Sobre.Text = "by fgomes";
            this.tssLabel_Sobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tssLabel_DtAgora
            // 
            this.tssLabel_DtAgora.AutoSize = false;
            this.tssLabel_DtAgora.Name = "tssLabel_DtAgora";
            this.tssLabel_DtAgora.Size = new System.Drawing.Size(65, 25);
            this.tssLabel_DtAgora.Text = "99/99/9999";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AplicativoBanhoeTosa.Properties.Resources.cachorro_banho;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(737, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sstrip_Principal);
            this.Controls.Add(this.mstrip_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.mstrip_Principal;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo Banho e Tosa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstrip_Principal.ResumeLayout(false);
            this.mstrip_Principal.PerformLayout();
            this.sstrip_Principal.ResumeLayout(false);
            this.sstrip_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrip_Principal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cachorroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarTrabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer tim_Principal;
        private System.Windows.Forms.StatusStrip sstrip_Principal;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel_Data;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel_DtAgora;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel_Espaco1;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel_Hora;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel_HrAgora;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel_Espaco2;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel_Sobre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

