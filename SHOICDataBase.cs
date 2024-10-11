/*
 * Creado por SharpDevelop.
 * Usuario:SANTAFEHACK
 * Fecha: 17/05/2012
 * Hora: 05:23 p.m.
 */
 
#region [Using]
using System.Data.SQLite;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
#endregion [Using]

namespace SHOIC
{

public class SHOICDirect
{
#region [Global]
SQLiteCommand sqlitecommand=new SQLiteCommand();
string squery="";
bool breturn =false;
SHOICConnection shoicconnection=new SHOICConnection();
SQLiteConnection sqliteconnection=new SQLiteConnection();
#endregion [Global]


public bool bInsert(StructProxy stproxy)
{
	return false;
}

public bool bDelete(int icode)
{
try{
breturn=false;
if (shoicconnection.bOpenConnection(ref sqlitecommand))
{
squery ="";
/*"UPDATE " + MSTCAdministrationPersonConstant.sTABLE + " SET " +
MSTCAdministrationPersonConstant.sDELETED + "=0" +
" WHERE " + MSTCAdministrationPersonConstant.sCODE + "=" + Icode.ToString();
*/
sqlitecommand = new SQLiteCommand(squery, sqliteconnection);

if(sqlitecommand.ExecuteNonQuery()>0)
 breturn = true;
shoicconnection.bCloseConnection();
return breturn;
}
}catch{return false;}

return false;
	
}


}


public class SHOICSQLite
{
//BindingSource  
private BindingSource bs = new BindingSource();
// Adaptador de datos sql  
System.Data.SQLite.SQLiteDataAdapter SqlDataAdapter;
System.Data.SQLite.SQLiteCommandBuilder SqlCommandBuilder;
	// Cadena de conexión  
	string cs;//= "Server=localhost;Uid=root;PASSWORD=747474;Database=mydb;Port=3306";
   string tablasql;
  // bool bEdit;
static SQLiteConnection conexion;	
  
public SHOICSQLite(ref BindingSource binsour,StructConexion stconexion)
{
string ruta=Application.StartupPath;
//Le paso que el directorio por defecto sea el del ejecutable
Directory.SetCurrentDirectory(ruta);
		
cs="Data Source="+stconexion.server;
binsour.DataSource=bs;
tablasql=stconexion.table;//La tabla que quiero actualizar
}
	
  
  
public void CrearBBDDSiNoExiste()
{     string ruta=Application.StartupPath;
			//Le paso que el directorio por defecto sea el del ejecutable
			Directory.SetCurrentDirectory(ruta);
		
        if (!File.Exists("DATA\\proxys.sqlite3") )
       {FileStream fi=new FileStream("DATA\\proxys.sqlite3",FileMode.CreateNew);
		fi.Close();
			
// Creamos la conexion a la BD. 
// El Data Source contiene la ruta del archivo de la BD 
conexion =new SQLiteConnection("Data Source=DATA\\proxys.sqlite3;Version=3;New=True;Compress=True;");
conexion.Open();      
            
// Creamos la primera tabla
string creacion = "CREATE TABLE proxys (ip_proxy VARCHAR(100),";
creacion +="puerto_proxy INT,";
creacion +="codigo_proxy INT PRIMARY KEY)";
  
SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
cmd.ExecuteNonQuery();            
conexion.Close();
  

conexion=new SQLiteConnection("Data Source=DATA\\proxys.sqlite3;Version=3;New=True;Compress=True;");
conexion.Open();     
//Creo la tabla de autocompletado
creacion = "CREATE TABLE autocompletado (direccion_auto VARCHAR(500),";
creacion +="codigo_auto INT PRIMARY KEY)";
cmd = new SQLiteCommand(creacion, conexion);
cmd.ExecuteNonQuery();            
conexion.Close();
  
conexion=new SQLiteConnection("Data Source=DATA\\proxys.sqlite3;Version=3;New=True;Compress=True;");
conexion.Open();     

cmd = new SQLiteCommand(InsertarProxysPorDefault(), conexion);
cmd.ExecuteNonQuery();            
conexion.Close();
 }
}
   
   
string InsertarProxysPorDefault()
{
	
	string insertar=
	 "INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('77.87.152.62',3128,1); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('61.145.163.228',3128,2); "+
  "INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('58.61.144.147',3128,3); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('218.28.49.172',3128,4); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('202.106.16.36',3128,5); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('201.54.148.7',3128,6); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('201.34.32.42',3128,7); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('200.241.240.24',3128,8); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('200.207.50.250',3128,9); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('157.86.173.251',3128,10); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('125.40.47.112',3128,11); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('141.100.108.236',3128,12); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('128.187.223.212',3128,13); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('195.54.209.166',3128,14); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('80.80.173.42',3128,15); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('212.100.132.146',3128,16); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('202.106.16.36',3128,17); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('212.100.132.149',3128,18); "+
		"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('61.16.161.5',3128,19); "+
		
 "INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('12.150.97.75',80,20); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('80.238.136.218',80,21); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('85.25.140.160',80,22); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('87.234.234.66',80,23); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('198.178.188.133',80,24); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('202.153.132.124',80,25); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('198.151.38.70',80,26); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('216.191.142.126',80,27); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('195.75.146.237',80,28); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('164.100.149.146',80,29); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('72.55.160.183',80,30); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('87.234.234.68',80,31); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('207.182.137.18',80,32); "+



"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('62.95.72.103',80,33); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('121.14.55.10',80,34); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('58.53.220.5',80,35); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('80.238.136.213',80,36); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('207.253.66.249',80,37); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('80.164.122.195',80,38); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('78.24.33.116',80,39); "+



"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('38.169.32.31',8000,40); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('222.190.118.27',8080,42); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('78.24.33.116',8080,43); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('60.247.100.2',8080,44); "+

"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('200.35.83.86',8080,45); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('60.247.100.2',8080,46); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('219.133.45.202',8080,47); "+


"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('83.236.157.231',3128,48); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('124.82.128.250',8080,49); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('222.126.90.117',8080,50); "+

"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('121.9.205.131',80,51); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('121.14.55.6',80,52); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('121.14.55.9',80,53); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('216.223.0.53',80,54); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('202.85.54.90',80,55); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('202.95.157.28',80,56); "+

"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('212.93.193.83',443,57); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('58.53.220.10',80,58); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('196.20.7.74',553,59); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('58.53.220.139',80,60); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('212.241.180.239',81,61); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('200.161.14.162',6588,62); "+
"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('83.236.157.231',3128,63); "+

"INSERT INTO proxys (ip_proxy,puerto_proxy,codigo_proxy) VALUES ('121.14.55.8',80,64); "+

"";
 
/*
 
  

 
:80 
:8080 


 
 
 
 
 */
	
return insertar;	
}
  
  
	
	
	public void CargarRegistros()
	{     string ruta=Application.StartupPath;
			//Le paso que el directorio por defecto sea el del ejecutable
			Directory.SetCurrentDirectory(ruta);
	
			try {
			// Inicializar el SqlDataAdapter indicandole el comando y el connection string  
			SqlDataAdapter = new SQLiteDataAdapter("SELECT *FROM "+tablasql, cs);
            SqlCommandBuilder = new SQLiteCommandBuilder(SqlDataAdapter);

			// llenar el DataTable  
			DataTable dt = new DataTable();
			SqlDataAdapter.Fill(dt);

			// Enlazar el BindingSource con el datatable anterior  
			// ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
			bs.DataSource = dt;

		}catch {MessageBox.Show("PROBLEMAS EN BD");}
	}
	

	
	//Usar cuando se sale de una ventana que abrió tablas y conexiones
	public void CerrarConexion()
	{
		SqlDataAdapter.Dispose();
}
	
	
public bool bUpdate(bool bCargar)
{
// Actualizar y guardar cambios  
if ((bs.DataSource != null))
{	try{//MessageBox.Show("LLEGA");
SqlDataAdapter.Update((DataTable)bs.DataSource);
return true;
}catch{}
}
return false;	
}
	

	
	
}

public class ArchivoConexion{
	StructConexion stconexion=new StructConexion();
	
		
			
	public ArchivoConexion(){
	if(!System.IO.File.Exists("Manager.cxn"))
			{FileStream fi=new FileStream("Manager.cxn",FileMode.CreateNew);
				fi.Close();
			}
	}
	
	public StructConexion Abrir()
		{
		//Averiguo ruta delejecutable
			//Esto espor si se desmadra al abrir otro archivo
			string ruta=Application.StartupPath;
			//Le paso que el directorio por defecto sea el del ejecutable
			Directory.SetCurrentDirectory(ruta);
			
		FileStream file=new FileStream(@"Manager.cxn",FileMode.Open);
	BinaryReader rd=new BinaryReader(file);
	
			try{
			
		
			stconexion.server=rd.ReadString();//.ToString();
			//stconexion.server="localhost";
			stconexion.user=rd.ReadString();//ToString();
			stconexion.pass=rd.ReadString();
			stconexion.port=rd.ReadString();
			stconexion.port="3307";
			rd.Close();
			file.Close(); 
			}catch(System.IO.EndOfStreamException ex)
			{
			//MessageBox.Show(ex.Message.ToString());
			}
		return stconexion;
		}
	
	
	public void Guardar(StructConexion stconexion)
	{
			FileStream file=new FileStream("Manager.cxn",FileMode.Create);
			BinaryWriter wi=new BinaryWriter(file);
			
			
			
			wi.Write(stconexion.server);
			wi.Write(stconexion.user);
			wi.Write(stconexion.pass);
			wi.Write(stconexion.port);
		    
			wi.Close();
			file.Close();
}
	
		
	
}





}//End namespace

