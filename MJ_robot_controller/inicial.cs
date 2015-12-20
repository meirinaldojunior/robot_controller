using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MJ_robot_controller
{
    public partial class inicial : Form
    {
        string RxString;
        int opcao = 0;
        
        public static string caminho_conexao;

        public static string caminhoAtualizado;

        public inicial()
        {
            InitializeComponent();
            SelectPort.DataSource = SerialPort.GetPortNames();

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            config configuracoes_tela = new config();
            configuracoes_tela.Show();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
         }

        private void inicial_Load(object sender, EventArgs e)
        {

        }

        private void status_con_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textIP.Enabled = true;
            TextPorta.Enabled = true;
            SelectPort.Enabled = false;
            velocidade_serial.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textIP.Enabled = false;
            TextPorta.Enabled = false;
            SelectPort.Enabled = true;
            opcao = 1;
            velocidade_serial.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opcao == 0)
            { // VIA IP INTERNET

            } else if(opcao == 1)
            { // VIA SERIAL
                if (serialPort1.IsOpen == false)
                {
                    if (serialPort1.IsOpen == false)
                    {
                        try
                        {
                    //        int velocidade_serial_int = int.Parse(velocidade_serial);
                            serialPort1.PortName = SelectPort.Text.ToString();
                            serialPort1.Open();
                       //     serialPort1.BaudRate = velocidade_serial_int;
                            status_con.Text = "Conectado";
                            status_con.BackColor = Color.Green;
                            bt_close_con.Enabled = true;
                            grupo_teste.Enabled = true;

                        }
                        catch
                        {
                            return;

                        }
                        if (serialPort1.IsOpen)
                        {
                            bt_close_con.Text = "Desconectar";
                            BtConecta.Enabled = false;

                            status_con.Text = "Conectado";
                            status_con.BackColor = Color.Green;
                          
                            grupo_teste.Enabled = true;
                        }
                    }
                    else
                    {

                        try
                        {
                            serialPort1.Close();
                            SelectPort.Enabled = true;
                            BtConecta.Text = "Conectar";

                        }
                        catch
                        {
                            return;
                        }
                        
                    }
                }
            }
        }

        private void bt_close_con_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta 
                serialPort1.Close();            //fecha a porta            
            status_con.Text = "Desconectado";
            status_con.BackColor = Color.Red;
            grupo_teste.Enabled = false;
            BtConecta.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(text_teste.Text);  //envia o texto presente no textbox Enviar
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box

        }
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            text_teste_recebido.AppendText(RxString);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
