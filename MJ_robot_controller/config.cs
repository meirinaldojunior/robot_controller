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

    public partial class config : Form
    {
        public int opcaoSelect = 0;
        string[] portas_seriais_encontradas = SerialPort.GetPortNames();

        public config()
        {
            InitializeComponent();
            Serial_box.Enabled = false;
            Conexao_box.Enabled = false;
            porta_serial_exibirList.DataSource = SerialPort.GetPortNames();
        }

        private void rd_internet_CheckedChanged(object sender, EventArgs e)
        {
            Conexao_box.Enabled = true;
            Serial_box.Enabled = false;
            opcaoSelect = 0;
        }

        private void rd_serial_CheckedChanged(object sender, EventArgs e)
        {
            Serial_box.Enabled = true;
            Conexao_box.Enabled = false;
            opcaoSelect = 1;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ListView porta_serial_exibirList = new ListView();
    
         
           
        }

        private void porta_serial_exibirList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Box_internetCon_Enter(object sender, EventArgs e)
        {

        }

        private void bt_aplicar_Click(object sender, EventArgs e)
        {
            if(opcaoSelect == 0 && ip_campo.Text == String.Empty)
            {
                MessageBox.Show("O campo IP não pode ficar em branco");
            }

            else if (opcaoSelect == 1 && porta_serial_exibirList.Text == string.Empty && velocidade_campo.Text == string.Empty)
            {
                MessageBox.Show("A porta Serial ou a velocidade não pode ficar em branco");
                
            }
            else
            {
                gravar_configuracao();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void config_Load(object sender, EventArgs e)
        {

        }
        void gravar_configuracao()
        {
            MessageBox.Show("Configurações Realizadas com Sucesso.");
            //setando configurações para tela princpal - ficará armazenadas as configurações lá!
            porta_serial_exibirList.Text = inicial.caminho_conexao;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            
        }

    }



}
        
 
