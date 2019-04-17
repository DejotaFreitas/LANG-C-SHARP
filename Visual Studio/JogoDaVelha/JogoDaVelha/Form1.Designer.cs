namespace JogoDaVelha
{
    partial class janelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(janelaPrincipal));
            this.panel_top = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.gb_placar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_empates = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.lb_vitorias = new System.Windows.Forms.Label();
            this.lb_derrotas = new System.Windows.Forms.Label();
            this.panel_bot = new System.Windows.Forms.Panel();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.zzz = new System.Windows.Forms.Label();
            this.lb_Rodada = new System.Windows.Forms.Label();
            this.lb_jogador = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.gb_placar.SuspendLayout();
            this.panel_bot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Black;
            this.panel_top.Controls.Add(this.lb_jogador);
            this.panel_top.Controls.Add(this.lb_Rodada);
            this.panel_top.Controls.Add(this.zzz);
            this.panel_top.Controls.Add(this.bt_sair);
            this.panel_top.Controls.Add(this.gb_placar);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(527, 158);
            this.panel_top.TabIndex = 1;
            // 
            // bt_sair
            // 
            this.bt_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sair.Location = new System.Drawing.Point(453, 12);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(62, 35);
            this.bt_sair.TabIndex = 2;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_placar
            // 
            this.gb_placar.Controls.Add(this.label3);
            this.gb_placar.Controls.Add(this.label4);
            this.gb_placar.Controls.Add(this.lb_empates);
            this.gb_placar.Controls.Add(this.label55);
            this.gb_placar.Controls.Add(this.lb_vitorias);
            this.gb_placar.Controls.Add(this.lb_derrotas);
            this.gb_placar.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_placar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_placar.Location = new System.Drawing.Point(21, 12);
            this.gb_placar.Name = "gb_placar";
            this.gb_placar.Size = new System.Drawing.Size(292, 133);
            this.gb_placar.TabIndex = 1;
            this.gb_placar.TabStop = false;
            this.gb_placar.Text = "Placar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vitórias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Derrotas";
            // 
            // lb_empates
            // 
            this.lb_empates.AutoSize = true;
            this.lb_empates.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empates.Location = new System.Drawing.Point(49, 98);
            this.lb_empates.Name = "lb_empates";
            this.lb_empates.Size = new System.Drawing.Size(24, 23);
            this.lb_empates.TabIndex = 5;
            this.lb_empates.Text = "0";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(102, 98);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(102, 23);
            this.label55.TabIndex = 4;
            this.label55.Text = "Empates";
            // 
            // lb_vitorias
            // 
            this.lb_vitorias.AutoSize = true;
            this.lb_vitorias.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vitorias.Location = new System.Drawing.Point(49, 36);
            this.lb_vitorias.Name = "lb_vitorias";
            this.lb_vitorias.Size = new System.Drawing.Size(24, 23);
            this.lb_vitorias.TabIndex = 2;
            this.lb_vitorias.Text = "0";
            // 
            // lb_derrotas
            // 
            this.lb_derrotas.AutoSize = true;
            this.lb_derrotas.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_derrotas.Location = new System.Drawing.Point(49, 66);
            this.lb_derrotas.Name = "lb_derrotas";
            this.lb_derrotas.Size = new System.Drawing.Size(24, 23);
            this.lb_derrotas.TabIndex = 3;
            this.lb_derrotas.Text = "0";
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_bot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_bot.BackgroundImage")));
            this.panel_bot.Controls.Add(this.bt9);
            this.panel_bot.Controls.Add(this.bt8);
            this.panel_bot.Controls.Add(this.bt7);
            this.panel_bot.Controls.Add(this.bt6);
            this.panel_bot.Controls.Add(this.bt5);
            this.panel_bot.Controls.Add(this.bt4);
            this.panel_bot.Controls.Add(this.bt3);
            this.panel_bot.Controls.Add(this.bt2);
            this.panel_bot.Controls.Add(this.bt1);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bot.Location = new System.Drawing.Point(0, 158);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.Size = new System.Drawing.Size(527, 384);
            this.panel_bot.TabIndex = 2;
            // 
            // bt9
            // 
            this.bt9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt9.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt9.Location = new System.Drawing.Point(341, 266);
            this.bt9.Margin = new System.Windows.Forms.Padding(0);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(120, 109);
            this.bt9.TabIndex = 13;
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt8.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt8.Location = new System.Drawing.Point(200, 266);
            this.bt8.Margin = new System.Windows.Forms.Padding(0);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(128, 109);
            this.bt8.TabIndex = 12;
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt7.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt7.Location = new System.Drawing.Point(61, 266);
            this.bt7.Margin = new System.Windows.Forms.Padding(0);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(124, 109);
            this.bt7.TabIndex = 11;
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt6
            // 
            this.bt6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt6.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt6.Location = new System.Drawing.Point(341, 149);
            this.bt6.Margin = new System.Windows.Forms.Padding(0);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(120, 106);
            this.bt6.TabIndex = 10;
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt5.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt5.Location = new System.Drawing.Point(200, 149);
            this.bt5.Margin = new System.Windows.Forms.Padding(0);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(128, 106);
            this.bt5.TabIndex = 9;
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt4.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt4.Location = new System.Drawing.Point(61, 149);
            this.bt4.Margin = new System.Windows.Forms.Padding(0);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(124, 106);
            this.bt4.TabIndex = 8;
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt3.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt3.Location = new System.Drawing.Point(341, 24);
            this.bt3.Margin = new System.Windows.Forms.Padding(0);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(120, 113);
            this.bt3.TabIndex = 7;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt2.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt2.Location = new System.Drawing.Point(200, 24);
            this.bt2.Margin = new System.Windows.Forms.Padding(0);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(128, 113);
            this.bt2.TabIndex = 6;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt1.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Location = new System.Drawing.Point(61, 24);
            this.bt1.Margin = new System.Windows.Forms.Padding(0);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(124, 113);
            this.bt1.TabIndex = 5;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // zzz
            // 
            this.zzz.AutoSize = true;
            this.zzz.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zzz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zzz.Location = new System.Drawing.Point(338, 29);
            this.zzz.Name = "zzz";
            this.zzz.Size = new System.Drawing.Size(89, 18);
            this.zzz.TabIndex = 14;
            this.zzz.Text = "By Dejota";
            // 
            // lb_Rodada
            // 
            this.lb_Rodada.AutoSize = true;
            this.lb_Rodada.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rodada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Rodada.Location = new System.Drawing.Point(360, 78);
            this.lb_Rodada.Name = "lb_Rodada";
            this.lb_Rodada.Size = new System.Drawing.Size(138, 18);
            this.lb_Rodada.TabIndex = 15;
            this.lb_Rodada.Text = "Jogador da vez:";
            // 
            // lb_jogador
            // 
            this.lb_jogador.AutoSize = true;
            this.lb_jogador.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jogador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_jogador.Location = new System.Drawing.Point(360, 110);
            this.lb_jogador.Name = "lb_jogador";
            this.lb_jogador.Size = new System.Drawing.Size(23, 18);
            this.lb_jogador.TabIndex = 16;
            this.lb_jogador.Text = "...";
            // 
            // janelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(527, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panel_bot);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "janelaPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.gb_placar.ResumeLayout(false);
            this.gb_placar.PerformLayout();
            this.panel_bot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bot;
        private System.Windows.Forms.GroupBox gb_placar;
        private System.Windows.Forms.Label lb_vitorias;
        private System.Windows.Forms.Label lb_derrotas;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_empates;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label zzz;
        private System.Windows.Forms.Label lb_Rodada;
        private System.Windows.Forms.Label lb_jogador;
    }
}

