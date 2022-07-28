namespace prova
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtVoraF = new System.Windows.Forms.TextBox();
            this.txtVoraI = new System.Windows.Forms.TextBox();
            this.txtVannoI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinutiF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOraF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGiornoF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMeseF = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAnnoF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCesto = new System.Windows.Forms.TextBox();
            this.txtVcesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinutiI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOraI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiornoI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeseI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnnoI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroCassette = new System.Windows.Forms.TextBox();
            this.txtVciclo = new System.Windows.Forms.TextBox();
            this.EndpointCB = new System.Windows.Forms.ComboBox();
            this.ClientUrlTB = new System.Windows.Forms.TextBox();
            this.DiscoveryTypeCB = new System.Windows.Forms.ComboBox();
            this.DiscoveryUrlCB = new System.Windows.Forms.ComboBox();
            this.lblerrors = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autostartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVoraF
            // 
            this.txtVoraF.BackColor = System.Drawing.SystemColors.Control;
            this.txtVoraF.Location = new System.Drawing.Point(181, 88);
            this.txtVoraF.Name = "txtVoraF";
            this.txtVoraF.Size = new System.Drawing.Size(66, 20);
            this.txtVoraF.TabIndex = 120;
            // 
            // txtVoraI
            // 
            this.txtVoraI.BackColor = System.Drawing.SystemColors.Control;
            this.txtVoraI.Location = new System.Drawing.Point(108, 88);
            this.txtVoraI.Name = "txtVoraI";
            this.txtVoraI.Size = new System.Drawing.Size(66, 20);
            this.txtVoraI.TabIndex = 112;
            // 
            // txtVannoI
            // 
            this.txtVannoI.BackColor = System.Drawing.SystemColors.Control;
            this.txtVannoI.Location = new System.Drawing.Point(108, 45);
            this.txtVannoI.Name = "txtVannoI";
            this.txtVannoI.Size = new System.Drawing.Size(86, 20);
            this.txtVannoI.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 670);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "Data Fine  minuti";
            // 
            // txtMinutiF
            // 
            this.txtMinutiF.Location = new System.Drawing.Point(18, 686);
            this.txtMinutiF.Name = "txtMinutiF";
            this.txtMinutiF.Size = new System.Drawing.Size(385, 20);
            this.txtMinutiF.TabIndex = 102;
            this.txtMinutiF.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Time Fine Ciclo\".MINUTE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 620);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Data Fine Ora";
            // 
            // txtOraF
            // 
            this.txtOraF.Location = new System.Drawing.Point(18, 636);
            this.txtOraF.Name = "txtOraF";
            this.txtOraF.Size = new System.Drawing.Size(385, 20);
            this.txtOraF.TabIndex = 100;
            this.txtOraF.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Time Fine Ciclo\".HOUR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 99;
            this.label12.Text = "Data Fine Giorno";
            // 
            // txtGiornoF
            // 
            this.txtGiornoF.Location = new System.Drawing.Point(18, 591);
            this.txtGiornoF.Name = "txtGiornoF";
            this.txtGiornoF.Size = new System.Drawing.Size(337, 20);
            this.txtGiornoF.TabIndex = 98;
            this.txtGiornoF.Text = "ns=3;s=\"DB108 Riepilogo Dati Ciclo\".\"Date Fine Lavorazione\".DAY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(439, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Data Fine Mese";
            // 
            // txtMeseF
            // 
            this.txtMeseF.Location = new System.Drawing.Point(442, 452);
            this.txtMeseF.Name = "txtMeseF";
            this.txtMeseF.Size = new System.Drawing.Size(228, 20);
            this.txtMeseF.TabIndex = 96;
            this.txtMeseF.Text = "ns=3;s=\"DB108 Riepilogo Dati Ciclo\".\"Date Fine Lavorazione\".MONTH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 95;
            this.label14.Text = "Data Fine Anno";
            // 
            // txtAnnoF
            // 
            this.txtAnnoF.Location = new System.Drawing.Point(442, 413);
            this.txtAnnoF.Name = "txtAnnoF";
            this.txtAnnoF.Size = new System.Drawing.Size(228, 20);
            this.txtAnnoF.TabIndex = 94;
            this.txtAnnoF.Text = "ns=3;s=\"DB108 Riepilogo Dati Ciclo\".\"Date Fine Lavorazione\".YEAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Codice cesto";
            // 
            // txtCesto
            // 
            this.txtCesto.Location = new System.Drawing.Point(18, 318);
            this.txtCesto.Name = "txtCesto";
            this.txtCesto.Size = new System.Drawing.Size(388, 20);
            this.txtCesto.TabIndex = 92;
            this.txtCesto.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Nome Cassetta\"";
            // 
            // txtVcesto
            // 
            this.txtVcesto.AcceptsReturn = true;
            this.txtVcesto.AcceptsTab = true;
            this.txtVcesto.Location = new System.Drawing.Point(13, 88);
            this.txtVcesto.Name = "txtVcesto";
            this.txtVcesto.Size = new System.Drawing.Size(83, 20);
            this.txtVcesto.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Data Inizio minuti";
            // 
            // txtMinutiI
            // 
            this.txtMinutiI.Location = new System.Drawing.Point(18, 543);
            this.txtMinutiI.Name = "txtMinutiI";
            this.txtMinutiI.Size = new System.Drawing.Size(385, 20);
            this.txtMinutiI.TabIndex = 88;
            this.txtMinutiI.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Time Inizio Ciclo\".MINUTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Data Inizio Ora";
            // 
            // txtOraI
            // 
            this.txtOraI.Location = new System.Drawing.Point(18, 497);
            this.txtOraI.Name = "txtOraI";
            this.txtOraI.Size = new System.Drawing.Size(385, 20);
            this.txtOraI.TabIndex = 86;
            this.txtOraI.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Time Inizio Ciclo\".HOUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Data Inizio Giorno";
            // 
            // txtGiornoI
            // 
            this.txtGiornoI.Location = new System.Drawing.Point(18, 452);
            this.txtGiornoI.Name = "txtGiornoI";
            this.txtGiornoI.Size = new System.Drawing.Size(385, 20);
            this.txtGiornoI.TabIndex = 84;
            this.txtGiornoI.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Time Inizio Ciclo\".DAY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Data Inizio Mese";
            // 
            // txtMeseI
            // 
            this.txtMeseI.Location = new System.Drawing.Point(18, 406);
            this.txtMeseI.Name = "txtMeseI";
            this.txtMeseI.Size = new System.Drawing.Size(385, 20);
            this.txtMeseI.TabIndex = 82;
            this.txtMeseI.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Time Inizio Ciclo\".MONTH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Data Inizio Anno";
            // 
            // txtAnnoI
            // 
            this.txtAnnoI.Location = new System.Drawing.Point(18, 357);
            this.txtAnnoI.Name = "txtAnnoI";
            this.txtAnnoI.Size = new System.Drawing.Size(385, 20);
            this.txtAnnoI.TabIndex = 80;
            this.txtAnnoI.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Time Inizio Ciclo\".YEAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Numero ciclo eseguito";
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(18, 279);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(388, 20);
            this.txtCiclo.TabIndex = 76;
            this.txtCiclo.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Numero Ciclo Eseguito\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Numero Cassette";
            // 
            // txtNumeroCassette
            // 
            this.txtNumeroCassette.Location = new System.Drawing.Point(18, 240);
            this.txtNumeroCassette.Name = "txtNumeroCassette";
            this.txtNumeroCassette.Size = new System.Drawing.Size(388, 20);
            this.txtNumeroCassette.TabIndex = 73;
            this.txtNumeroCassette.Text = "ns=3;s=\"DB550 My_FIFO_DB\".\"FIFO\"[0].\"Numero Cassette Prodotte\"";
            // 
            // txtVciclo
            // 
            this.txtVciclo.Location = new System.Drawing.Point(13, 45);
            this.txtVciclo.Name = "txtVciclo";
            this.txtVciclo.Size = new System.Drawing.Size(83, 20);
            this.txtVciclo.TabIndex = 71;
            // 
            // EndpointCB
            // 
            this.EndpointCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndpointCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndpointCB.FormattingEnabled = true;
            this.EndpointCB.Location = new System.Drawing.Point(442, 365);
            this.EndpointCB.Name = "EndpointCB";
            this.EndpointCB.Size = new System.Drawing.Size(0, 21);
            this.EndpointCB.TabIndex = 68;
            this.EndpointCB.Visible = false;
            // 
            // ClientUrlTB
            // 
            this.ClientUrlTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ClientUrlTB.Enabled = false;
            this.ClientUrlTB.Location = new System.Drawing.Point(442, 334);
            this.ClientUrlTB.Name = "ClientUrlTB";
            this.ClientUrlTB.Size = new System.Drawing.Size(112, 20);
            this.ClientUrlTB.TabIndex = 67;
            this.ClientUrlTB.Visible = false;
            // 
            // DiscoveryTypeCB
            // 
            this.DiscoveryTypeCB.FormattingEnabled = true;
            this.DiscoveryTypeCB.Items.AddRange(new object[] {
            "Forward",
            "Reverse"});
            this.DiscoveryTypeCB.Location = new System.Drawing.Point(440, 279);
            this.DiscoveryTypeCB.Name = "DiscoveryTypeCB";
            this.DiscoveryTypeCB.Size = new System.Drawing.Size(92, 21);
            this.DiscoveryTypeCB.TabIndex = 66;
            this.DiscoveryTypeCB.Visible = false;
            // 
            // DiscoveryUrlCB
            // 
            this.DiscoveryUrlCB.FormattingEnabled = true;
            this.DiscoveryUrlCB.Location = new System.Drawing.Point(442, 307);
            this.DiscoveryUrlCB.Name = "DiscoveryUrlCB";
            this.DiscoveryUrlCB.Size = new System.Drawing.Size(165, 21);
            this.DiscoveryUrlCB.TabIndex = 69;
            this.DiscoveryUrlCB.Visible = false;
            // 
            // lblerrors
            // 
            this.lblerrors.AutoSize = true;
            this.lblerrors.Location = new System.Drawing.Point(12, 160);
            this.lblerrors.Name = "lblerrors";
            this.lblerrors.Size = new System.Drawing.Size(32, 13);
            this.lblerrors.TabIndex = 125;
            this.lblerrors.Text = "Stato";
            this.lblerrors.Click += new System.EventHandler(this.lblerrors_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 126;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autostartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // autostartToolStripMenuItem
            // 
            this.autostartToolStripMenuItem.Checked = true;
            this.autostartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autostartToolStripMenuItem.Name = "autostartToolStripMenuItem";
            this.autostartToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.autostartToolStripMenuItem.Text = "Autostart";
            this.autostartToolStripMenuItem.Click += new System.EventHandler(this.autostartToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 127;
            this.label9.Text = "Data lavaggio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(105, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 128;
            this.label15.Text = "Ora Inizio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(178, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 129;
            this.label16.Text = "Ora Fine";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 130;
            this.label17.Tag = "";
            this.label17.Text = "N Programma";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 131;
            this.label18.Text = "N Cesto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVoraF);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtVciclo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtVcesto);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtVannoI);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtVoraI);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(15, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 131);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "N cassette";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblerrors);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMinutiF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOraF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGiornoF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMeseF);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAnnoF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMinutiI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOraI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiornoI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMeseI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnnoI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroCassette);
            this.Controls.Add(this.EndpointCB);
            this.Controls.Add(this.ClientUrlTB);
            this.Controls.Add(this.DiscoveryTypeCB);
            this.Controls.Add(this.DiscoveryUrlCB);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lavaggio";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVoraF;
        private System.Windows.Forms.TextBox txtVoraI;
        private System.Windows.Forms.TextBox txtVannoI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinutiF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOraF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGiornoF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMeseF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAnnoF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCesto;
        private System.Windows.Forms.TextBox txtVcesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinutiI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOraI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiornoI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeseI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnnoI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCassette;
        private System.Windows.Forms.TextBox txtVciclo;
        private System.Windows.Forms.ComboBox EndpointCB;
        private System.Windows.Forms.TextBox ClientUrlTB;
        private System.Windows.Forms.ComboBox DiscoveryTypeCB;
        private System.Windows.Forms.ComboBox DiscoveryUrlCB;
        private System.Windows.Forms.Label lblerrors;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autostartToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

