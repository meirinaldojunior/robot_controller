﻿namespace MJ_robot_controller
{
    partial class inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicial));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.status_con = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtConecta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.velocidade_serial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.TextPorta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_close_con = new System.Windows.Forms.Button();
            this.grupo_teste = new System.Windows.Forms.GroupBox();
            this.text_teste_recebido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_teste = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grupo_teste.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // status_con
            // 
            resources.ApplyResources(this.status_con, "status_con");
            this.status_con.BackColor = System.Drawing.Color.Red;
            this.status_con.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.status_con.Name = "status_con";
            this.status_con.Click += new System.EventHandler(this.status_con_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtConecta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.velocidade_serial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SelectPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textIP);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // BtConecta
            // 
            resources.ApplyResources(this.BtConecta, "BtConecta");
            this.BtConecta.Name = "BtConecta";
            this.BtConecta.UseVisualStyleBackColor = true;
            this.BtConecta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // velocidade_serial
            // 
            resources.ApplyResources(this.velocidade_serial, "velocidade_serial");
            this.velocidade_serial.Name = "velocidade_serial";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SelectPort
            // 
            this.SelectPort.FormattingEnabled = true;
            resources.ApplyResources(this.SelectPort, "SelectPort");
            this.SelectPort.Name = "SelectPort";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textIP
            // 
            resources.ApplyResources(this.textIP, "textIP");
            this.textIP.Name = "textIP";
            // 
            // TextPorta
            // 
            resources.ApplyResources(this.TextPorta, "TextPorta");
            this.TextPorta.Name = "TextPorta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_close_con);
            this.groupBox3.Controls.Add(this.status_con);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // bt_close_con
            // 
            resources.ApplyResources(this.bt_close_con, "bt_close_con");
            this.bt_close_con.Name = "bt_close_con";
            this.bt_close_con.UseVisualStyleBackColor = true;
            this.bt_close_con.Click += new System.EventHandler(this.bt_close_con_Click);
            // 
            // grupo_teste
            // 
            this.grupo_teste.Controls.Add(this.text_teste_recebido);
            this.grupo_teste.Controls.Add(this.label6);
            this.grupo_teste.Controls.Add(this.label5);
            this.grupo_teste.Controls.Add(this.button1);
            this.grupo_teste.Controls.Add(this.text_teste);
            resources.ApplyResources(this.grupo_teste, "grupo_teste");
            this.grupo_teste.Name = "grupo_teste";
            this.grupo_teste.TabStop = false;
            // 
            // text_teste_recebido
            // 
            resources.ApplyResources(this.text_teste_recebido, "text_teste_recebido");
            this.text_teste_recebido.Name = "text_teste_recebido";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // text_teste
            // 
            resources.ApplyResources(this.text_teste, "text_teste");
            this.text_teste.Name = "text_teste";
            // 
            // inicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grupo_teste);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TextPorta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.inicial_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grupo_teste.ResumeLayout(false);
            this.grupo_teste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label status_con;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox TextPorta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox velocidade_serial;
        private System.Windows.Forms.Button BtConecta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_close_con;
        private System.Windows.Forms.GroupBox grupo_teste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_teste;
        private System.Windows.Forms.TextBox text_teste_recebido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

