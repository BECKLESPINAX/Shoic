/*
 * Creado por SharpDevelop.
 * Usuario: SANTAFEHACK
 * Fecha: 20/09/2012
 * Hora: 04:36 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
#region {Usings}
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
#endregion {Usings}

namespace SHOIC
{
/// <summary>
/// Description of WindowHelp.
/// </summary>
public partial class WindowHelp : Form
{
#region Movimiento API Windows
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
	
public string pagina="\\Help\\";
public WindowHelp()
{
InitializeComponent();
		
//Esto espor si se desmadra al abrir otro archivo
string ruta=Application.StartupPath;
//Le paso que el directorio por defecto sea el del ejecutable
Directory.SetCurrentDirectory(ruta);
			
pagina+="Help.htm";

WebBrowserAyuda.Navigate(ruta+pagina);
}			
public WindowHelp(string pag)
{
InitializeComponent();
this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverFormulario);

//Esto espor si se desmadra al abrir otro archivo
string ruta=Application.StartupPath;
//Le paso que el directorio por defecto sea el del ejecutable
Directory.SetCurrentDirectory(ruta);
			
pagina+="Help_archivos\\";
pagina+=pag;
MessageBox.Show(ruta+pagina);
WebBrowserAyuda.Navigate(ruta+pagina);

}

#region {Eventos}
void DobleClick(object sender, MouseEventArgs e)
{
	if(this.WindowState==FormWindowState.Maximized)
	this.WindowState=FormWindowState.Normal;
	else
	this.WindowState=FormWindowState.Maximized;
}
void ClickSalir(object sender, EventArgs e)
{
this.Close();
}
#endregion {Eventos}

#region {Mover Ventana}
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
#endregion {Mover Ventana}
		

}//Fin clase
}//Fin namespace
