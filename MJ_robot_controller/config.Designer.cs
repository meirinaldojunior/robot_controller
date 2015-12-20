namespace MJ_robot_controller
{
    partial class config
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
            this.button1 = new System.Windows.Forms.Button();
            this.check_dns = new System.Windows.Forms.CheckBox();
            this.text_porta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_conexao = new System.Windows.Forms.GroupBox();
            this.rd_serial = new System.Windows.Forms.RadioButton();
            this.rd_internet = new System.Windows.Forms.RadioButton();
            this.bt_aplicar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.Serial_box = new System.Windows.Forms.GroupBox();
            this.velocidade_campo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.porta_serial_label = new System.Windows.Forms.Label();
            this.porta_serial_exibirList = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Conexao_box = new System.Windows.Forms.GroupBox();
            this.ip_campo = new System.Windows.Forms.TextBox();
            this.box_conexao.SuspendLayout();
            this.Serial_box.SuspendLayout();
            this.Conexao_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "TESTAR CONEXÃO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // check_dns
            // 
            this.check_dns.AutoSize = true;
            this.check_dns.Location = new System.Drawing.Point(9, 42);
            this.check_dns.Name = "check_dns";
            this.check_dns.Size = new System.Drawing.Size(111, 17);
            this.check_dns.TabIndex = 4;
            this.check_dns.Text = "Conexão via DNS";
            this.check_dns.UseVisualStyleBackColor = true;
            // 
            // text_porta
            // 
            this.text_porta.Location = new System.Drawing.Point(218, 16);
            this.text_porta.Name = "text_porta";
            this.text_porta.Size = new System.Drawing.Size(74, 20);
            this.text_porta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta (opcional): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // box_conexao
            // 
            this.box_conexao.Controls.Add(this.rd_serial);
            this.box_conexao.Controls.Add(this.rd_internet);
            this.box_conexao.Location = new System.Drawing.Point(12, 12);
            this.box_conexao.Name = "box_conexao";
            this.box_conexao.Size = new System.Drawing.Size(310, 46);
            this.box_conexao.TabIndex = 0;
            this.box_conexao.TabStop = false;
            this.box_conexao.Text = "Conexão";
            // 
            // rd_serial
            // 
            this.rd_serial.AutoSize = true;
            this.rd_serial.Location = new System.Drawing.Point(178, 19);
            this.rd_serial.Name = "rd_serial";
            this.rd_serial.Size = new System.Drawing.Size(51, 17);
            this.rd_serial.TabIndex = 1;
            this.rd_serial.TabStop = true;
            this.rd_serial.Text = "Serial";
            this.rd_serial.UseVisualStyleBackColor = true;
            this.rd_serial.CheckedChanged += new System.EventHandler(this.rd_serial_CheckedChanged);
            // 
            // rd_internet
            // 
            this.rd_internet.AutoSize = true;
            this.rd_internet.Location = new System.Drawing.Point(6, 19);
            this.rd_internet.Name = "rd_internet";
            this.rd_internet.Size = new System.Drawing.Size(165, 17);
            this.rd_internet.TabIndex = 0;
            this.rd_internet.TabStop = true;
            this.rd_internet.Text = "Internet - IP (Wifi ou Ethernet)";
            this.rd_internet.UseVisualStyleBackColor = true;
            this.rd_internet.CheckedChanged += new System.EventHandler(this.rd_internet_CheckedChanged);
            // 
            // bt_aplicar
            // 
            this.bt_aplicar.Location = new System.Drawing.Point(91, 252);
            this.bt_aplicar.Name = "bt_aplicar";
            this.bt_aplicar.Size = new System.Drawing.Size(75, 23);
            this.bt_aplicar.TabIndex = 1;
            this.bt_aplicar.Text = "Aplicar ";
            this.bt_aplicar.UseVisualStyleBackColor = true;
            this.bt_aplicar.Click += new System.EventHandler(this.bt_aplicar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(173, 252);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "Concelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // Serial_box
            // 
            this.Serial_box.Controls.Add(this.velocidade_campo);
            this.Serial_box.Controls.Add(this.label3);
            this.Serial_box.Controls.Add(this.porta_serial_label);
            this.Serial_box.Controls.Add(this.porta_serial_exibirList);
            this.Serial_box.Location = new System.Drawing.Point(18, 149);
            this.Serial_box.Name = "Serial_box";
            this.Serial_box.Size = new System.Drawing.Size(298, 73);
            this.Serial_box.TabIndex = 3;
            this.Serial_box.TabStop = false;
            this.Serial_box.Text = "Serial";
            this.Serial_box.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // velocidade_campo
            // 
            this.velocidade_campo.Location = new System.Drawing.Point(218, 20);
            this.velocidade_campo.Name = "velocidade_campo";
            this.velocidade_campo.Size = new System.Drawing.Size(74, 20);
            this.velocidade_campo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocidade:";
            // 
            // porta_serial_label
            // 
            this.porta_serial_label.AutoSize = true;
            this.porta_serial_label.Location = new System.Drawing.Point(6, 22);
            this.porta_serial_label.Name = "porta_serial_label";
            this.porta_serial_label.Size = new System.Drawing.Size(32, 13);
            this.porta_serial_label.TabIndex = 1;
            this.porta_serial_label.Text = "Porta";
            // 
            // porta_serial_exibirList
            // 
            this.porta_serial_exibirList.FormattingEnabled = true;
            this.porta_serial_exibirList.Location = new System.Drawing.Point(44, 19);
            this.porta_serial_exibirList.Name = "porta_serial_exibirList";
            this.porta_serial_exibirList.Size = new System.Drawing.Size(104, 21);
            this.porta_serial_exibirList.TabIndex = 0;
            this.porta_serial_exibirList.SelectedIndexChanged += new System.EventHandler(this.porta_serial_exibirList_SelectedIndexChanged);
            // 
            // Conexao_box
            // 
            this.Conexao_box.Controls.Add(this.ip_campo);
            this.Conexao_box.Controls.Add(this.button1);
            this.Conexao_box.Controls.Add(this.label1);
            this.Conexao_box.Controls.Add(this.check_dns);
            this.Conexao_box.Controls.Add(this.label2);
            this.Conexao_box.Controls.Add(this.text_porta);
            this.Conexao_box.Location = new System.Drawing.Point(18, 67);
            this.Conexao_box.Name = "Conexao_box";
            this.Conexao_box.Size = new System.Drawing.Size(298, 76);
            this.Conexao_box.TabIndex = 6;
            this.Conexao_box.TabStop = false;
            this.Conexao_box.Text = "Conexão";
            // 
            // ip_campo
            // 
            this.ip_campo.Location = new System.Drawing.Point(30, 16);
            this.ip_campo.Name = "ip_campo";
            this.ip_campo.Size = new System.Drawing.Size(100, 20);
            this.ip_campo.TabIndex = 6;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 287);
            this.Controls.Add(this.Conexao_box);
            this.Controls.Add(this.Serial_box);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aplicar);
            this.Controls.Add(this.box_conexao);
            this.Name = "config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.config_Load);
            this.box_conexao.ResumeLayout(false);
            this.box_conexao.PerformLayout();
            this.Serial_box.ResumeLayout(false);
            this.Serial_box.PerformLayout();
            this.Conexao_box.ResumeLayout(false);
            this.Conexao_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox box_conexao;
        private System.Windows.Forms.RadioButton rd_serial;
        private System.Windows.Forms.RadioButton rd_internet;
        private System.Windows.Forms.Button bt_aplicar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox check_dns;
        private System.Windows.Forms.TextBox text_porta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Serial_box;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox porta_serial_exibirList;
        private System.Windows.Forms.GroupBox Conexao_box;
        private System.Windows.Forms.Label porta_serial_label;
        private System.Windows.Forms.TextBox velocidade_campo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip_campo;
    }
}