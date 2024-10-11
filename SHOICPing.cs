/*
 * Creado por SharpDevelop.
 * MegaTron
 * Fecha: 14/12/2012
 * Hora: 03:13 p.m.
 * 
 */
#region [Using]
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Text;
#endregion [Using]

namespace SHOIC
{
/// <summary>
/// Description of SHOICPing.
/// </summary>
public class SHOICPing
{
#region [Global]
Timer timer1=new Timer();
string remoteMachineNameOrIP="";
int timeOut =5;
#endregion [Global]

/*
public SHOICPing(string stringip, int inttime)
{
remoteMachineNameOrIP="";
}
*/
public bool bIsDead()
{
//timeOut=500;
Ping ping = new Ping();
//MessageBox.Show(remoteMachineNameOrIP);
// Pinging remote maching
PingReply reply = ping.Send(remoteMachineNameOrIP, timeOut);

if(reply.Status==IPStatus.BadDestination)
	return true;
	
if(reply.Status==IPStatus.DestinationProhibited)
	return true;
	
if(reply.Status==IPStatus.TimedOut)
	return true;

//IPStatus

return false;	
}

public SHOICPing(string stringip, int inttime)
{
timer1.Interval=1000;
timer1.Enabled=true;
timer1.Tick+= new EventHandler(timer1_Tick);
timer1.Start();

remoteMachineNameOrIP= stringip;
timeOut = inttime;
}


private void timer1_Tick(object sender, EventArgs e)
{
timeOut=500;
Ping ping = new Ping();
//MessageBox.Show(remoteMachineNameOrIP);
// Pinging remote maching
PingReply reply = ping.Send(remoteMachineNameOrIP, timeOut);

//PingReply reply =new PingReply();
//PingReply reply=ping.Send("218.28.49.172", timeOut);


//Ver de hacer con esto para verificar el estado del proxy si el proxy anda mal, avisar que anda mal
//Esto es para las largas esperas que hay que hacer cuando se traba


// Displaying the result
/*StringBuilder sb = new StringBuilder();
  sb.Append("Address:" + reply.Address.ToString());
  sb.Append("\nStatus:" + reply.Status.ToString());
  sb.Append("\nRoundtripTime:" + reply.RoundtripTime.ToString());
*/
//TimedOut

 // MessageBox.Show(reply.RoundtripTime.ToString());

}


 }//End class
}//End namespace
