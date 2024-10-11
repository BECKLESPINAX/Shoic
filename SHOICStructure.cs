/*
 * Creado por SharpDevelop.
 * Usuario:SANTAFEHACK
 * Fecha: 18/05/2012
 * Hora: 03:11 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

namespace SHOIC
{
public struct StructConexion
{
public string database;
public	string port;
public  string user;
public  string pass;
public	string server;
public  string table;
public string table2;

}


public struct StructProxy
{
public string sip;
public string sport;
}


public enum ReqState
{
Ready,
Connecting,
Requesting,
Downloading,
Completed,
Failed
};


public struct StructSHOIC
{
public string sip;
public int iport;
public int iprotocol;
public int idelay;
public bool bresp;
public string sdata;
public int itimeout;
}

}//End namespace