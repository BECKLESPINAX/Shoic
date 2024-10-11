/*
 * Creado por SharpDevelop.
 * Usuario: SANTAFEHACK
 * Fecha: 17/05/2012
 * Hora: 03:09 p.m.
 */
 
#region [Using]
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;
#endregion [Using]

namespace SHOIC
{
public partial class WindowConfiguration : Form
{
#region [Global]
BindingSource BindingSourceProxys=new BindingSource();
BindingSource BindingSourceAutoCompletado=new BindingSource();
		
SHOICSQLite shoicsqlite;
SHOICSQLite shoicsqliteautocomplete;
StructConexion stconexion=new StructConexion();
List<StructProxy> ListProxy=new List<StructProxy>();
#endregion [Global]

#region [Constructor]
public WindowConfiguration(ref BindingSource bs,ref SHOICSQLite ne)
{
InitializeComponent();
shoicsqlite=ne;
/*DataGridViewProxys.DataSource=bs;
DataGridViewProxys.Columns["codigo_proxy"].HeaderText="Código";
DataGridViewProxys.Columns["ip_proxy"].HeaderText="IP";
DataGridViewProxys.Columns["puerto_proxy"].HeaderText="Puerto";
*/}
#endregion [Constructor]


#region [Event]


void GrillaDataError(object sender, DataGridViewDataErrorEventArgs e)
{
//using (var wmessage = new WindowMessage())
{
//wmessage.Show();
MessageBox.Show("Colocá un número entero tanto en el puerto como en el código.");
}
}
void ClickClearAutoCompleted(object sender, EventArgs e)
{
string messageBoxText = "Desea Limpiar las URLS Atacadas?";
string caption = "Eliminación";
MessageBoxButtons button = MessageBoxButtons.YesNo;
MessageBoxIcon icon = MessageBoxIcon.Question;
DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
if(result==DialogResult.Yes)
{
stconexion.server="DATA\\proxys.sqlite3; Version=3;New=True;Compress=True;";
stconexion.table="autocompletado";
shoicsqliteautocomplete=new SHOICSQLite(ref BindingSourceAutoCompletado,stconexion);
shoicsqliteautocomplete.CargarRegistros();
int i=0;
while(i<BindingSourceAutoCompletado.Count)
{
	BindingSourceAutoCompletado.RemoveAt(i);
}
shoicsqliteautocomplete.bUpdate(true);
MessageBox.Show("Limpieza Exitosa.");
}

}

void ClickSave(object sender, EventArgs e)
{
shoicsqlite.bUpdate(true);
}
void ClickHelp(object sender, EventArgs e)
{
	//vGetProxys();
//new WindowHelp("Configuracion.htm").Show();			
SHOICProxy shoicproxy=new SHOICProxy();
shoicproxy.vGetProxys();

}
void ClickExit(object sender, EventArgs e)
{
this.Close();
}
#endregion [Events]

public void vGetProxys(){
string s;
try{
WebClient client = new WebClient();
// Add a user agent header in case the requested URI contains a query;
client.Headers.Add("user-agent", "Mozilla/4.0 (compatible;"+
"MSIE 6.0; Windows NT 5.2; .NET CLR1.0.3705;)");

string baseurl = "http://www.proxys.com.ar/";

//Pongo toda la página en el string s
Stream data = client.OpenRead(baseurl);
StreamReader reader = new StreamReader(data);
s = reader.ReadToEnd();
data.Close();
reader.Close();
//Ya tengo toda la página, ahora voy en busca de las IP y los puertos


//Ahora Busco lo siguiente:
int indexof=0;
int indexlastof=0;
string sdemo="";
indexof=s.IndexOf("<tr class=\"cells\" onmouseover=\"this.className='cells2'\" onmouseout=\"this.className='cells'\">");
indexlastof=s.LastIndexOf("<tr class=\"cells\" onmouseover=\"this.className='cells2'\" onmouseout=\"this.className='cells'\">");

while(indexof!=-1)
{

//Supuestamente ya tengo la primera y la ultima aparición
//Ahora entre estos índices buscar IPs Y puertos
//Esto tiene primeramente un número así <td >5</td>  con espacio ante el 5, entonces tengo que buscar
//Entre el indice antes descripto y el último la aparición <td>
//luedo de esa aparición está entonces la ip
//En la siguiente viene el puerto, que es lo que nos interesa
/* El esquema completo de cada fila es el siguiente
<tr class="cells" onmouseover="this.className='cells2'" onmouseout="this.className='cells'">
    <td >5</td> 
    <td>203.252.84.23</td>
    <td>3128</td> 
    <td>Elite</td> 
    <td> Korea, Republic of</td> 
    <td>Hoy</td> 
    <td><a href="index.php?act=whois&ip=203.252.84.23" target="_blank"><span class="sp_link">WHOIS</span></a></td>
  </tr> 
*/
//Una vez obtenido el puerto debo ir hasta el otro <tr class=\"cells\" onmouseover=\"this.className='cells2'\" onmouseout=\"this.className='cells'\">"
indexof=s.IndexOf("<td>",indexof);
indexof+=4;//Paso el <td>
int i1=indexof;
indexof=s.IndexOf("</td>",indexof);
int i2=indexof;
StructProxy stproxy=new StructProxy();
//MessageBox.Show(s.Substring(i1,i2-i1));
stproxy.sip=s.Substring(i1,i2-i1);
sdemo+=s.Substring(i1,i2-i1)+" - ";

//Sigo en busca del puerto
indexof=s.IndexOf("<td>",indexof);
indexof+=4;//Paso el <td>
i1=indexof;
indexof=s.IndexOf("</td>",indexof);
i2=indexof;
stproxy.sport=s.Substring(i1,i2-i1);
sdemo+=s.Substring(i1,i2-i1)+"\n";
ListProxy.Add(stproxy);

indexof=s.IndexOf("<tr class=\"cells\" onmouseover=\"this.className='cells2'\" onmouseout=\"this.className='cells'\">",indexof);
}
BindingSourceProxys.Clear();
int j=0;
while(j<ListProxy.Count)
{
DataRowView row=(DataRowView)BindingSourceProxys.AddNew();
row["ip_proxy"]=(object)ListProxy[j].sip;
row["puerto_proxy"]=(object)ListProxy[j].sport;
row["codigo_proxy"]=(object)j;
MessageBox.Show(ListProxy[j].sip);
j++;
}
BindingSourceProxys.EndEdit();
shoicsqlite.bUpdate(true);


}catch (Exception)
{
MessageBox.Show("Hubo un Error/Sorry.");}
}


void ClickProxyAutoManual(object sender, EventArgs e)
{
if(RadioButtonProxyAuto.Checked)
{
this.vGetProxys();
}
else
{
shoicsqlite.bUpdate(true);	
}
}


  }//End class
}//End namespace
