#region [Using]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
#endregion [Using]

namespace SHOIC
{
public class SHOICProxy
{
#region [Global]
List<StructProxy> ListProxy = new List<StructProxy>();
#endregion [Global]

public void vGetProxys()
{
string s;
string g="";
try{
WebClient client = new WebClient();
// Add a user agent header in case the requested URI contains a query;
client.Headers.Add("user-agent", "Mozilla/4.0 (compatible;" +
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
int indexof = 0;
int indexlastof = 0;
string sdemo = "";
indexof = s.IndexOf("<tr class=\"cells\" onmouseover=\"this.className='cells2'\" onmouseout=\"this.className='cells'\">");
indexlastof = s.LastIndexOf("<tr class=\"cells\" onmouseover=\"this.className='cells2'\" onmouseout=\"this.className='cells'\">");

while (indexof != -1)
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
indexof = s.IndexOf("<td>", indexof);
indexof += 4;//Paso el <td>
int i1 = indexof;
indexof = s.IndexOf("</td>", indexof);
int i2 = indexof;
StructProxy stproxy = new StructProxy();
//MessageBox.Show(s.Substring(i1,i2-i1));
stproxy.sip = s.Substring(i1, i2 - i1);
sdemo += s.Substring(i1, i2 - i1) + " - ";

//Sigo en busca del puerto
indexof = s.IndexOf("<td>", indexof);
indexof += 4;//Paso el <td>
i1 = indexof;
indexof = s.IndexOf("</td>", indexof);
i2 = indexof;
stproxy.sport = s.Substring(i1, i2 - i1);
sdemo += s.Substring(i1, i2 - i1) + "\n";
ListProxy.Add(stproxy);
g+=stproxy.sip+" "+stproxy.sport+"\n";
indexof = s.IndexOf("<tr class=\"cells\" onmouseover=\"this.className='cells2'\" onmouseout=\"this.className='cells'\">", indexof);
	}



/*
BindingSourceProxys.Clear();
int j = 0;
while (j < ListProxy.Count)
{
DataRowView row = (DataRowView)BindingSourceProxys.AddNew();
row["ip_proxy"] = (object)ListProxy[j].sip;
row["puerto_proxy"] = (object)ListProxy[j].sport;
row["codigo_proxy"] = (object)j;
MessageBox.Show(ListProxy[j].sip);
j++;
}
BindingSourceProxys.EndEdit();
shoicsqlite.Actualizar(true);
*/

}catch{
MessageBox.Show("Hubo un Error/Sorry.");
}

MessageBox.Show(g);
	}


	}
}
