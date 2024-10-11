/*
 * Creado por SharpDevelop.
 * MegalÖSoft
 * Fecha: 13/10/2014
 * Hora: 09:52 p.m.
 * 
 */
 
#region [Using]
using System;
using System.Data.SQLite;
#endregion [Using]

namespace SHOIC
{
	/// <summary>
	/// Description of SHOICConnection.
	/// </summary>
public class SHOICConnection
{
protected string cs="";	
protected string query="";
protected SQLiteConnection sqliteconnection = new SQLiteConnection();
//protected NpgsqlCommand npgcommand=new NpgsqlCommand();
protected StructConexion stconexion=new StructConexion();

public SHOICConnection()
{
//stconexion.database="IntellïTable";
//stconexion.table="elements";
stconexion.server="Data Source=IntellïTable2014.mssqlite; Version=3;New=False;Compress=True;Password=33megalosoftintellitable33";
stconexion.server ="Data Source=TambÖControl.sqlite.mssqlite; Version=3;New=false;Compress=True";//Password=33megalosoftintellitable33";

stconexion.port="3307";
stconexion.user="root";
stconexion.pass="747474";
}

public StructConexion stGetConnection
{
get{return stconexion;}
}

public string sGetConnection
{
get{return cs;}
}

private string sSetConnection
{
set{stconexion.server=cs;}
}
public bool bOpenConnection(ref  SQLiteCommand sqlitecommand)
{
try{
//cs = "Server=" + stconexion.server + ";USER ID=" + stconexion.user + ";PASSWORD=" + stconexion.pass + ";DATABASE=" + stconexion.sdatabase + ";PORT=" + stconexion.port + ";";
cs=stconexion.server;
sqliteconnection = new SQLiteConnection(cs);
//npgconnection.ConnectionString=cs;
sqliteconnection.Open();
sqlitecommand.Connection = sqliteconnection;
return true;
}catch{return false;}
}

public bool bOpenConnectionTransact(ref SQLiteConnection sqliteconn, ref SQLiteCommand sqlitecmd, ref SQLiteTransaction sqlitetransact)
{
try{
sqliteconn = new SQLiteConnection(cs);
sqliteconn.Open();
sqlitetransact = sqliteconn.BeginTransaction();
sqlitecmd.Connection = sqliteconn;
sqlitecmd.Transaction = sqlitetransact;
return true;
}catch{return false;}
}
public bool bCloseConnectionTransact(ref SQLiteConnection sqliteconn, ref SQLiteCommand sqlitecmd, ref SQLiteTransaction sqlitetransact)
{
try{
//npgconnection = new NpgsqlConnection(cs);
sqliteconn.Close();
sqlitetransact = sqliteconn.BeginTransaction();
//npgcommand.Connection = npgconn;
//npgcommand.Transaction = npgsqltransact;
return true;
}catch{return false;}
}


public bool bCloseConnection()
{	
sqliteconnection.Close();
return false;
}




}//End class

}//End namespace
