/*
 * Creado por SharpDevelop.
 * Usuario: SANTAFEHACK
 * Fecha: 24/04/2012
 * Hora: 10:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SHOIC
{
/// <summary>
/// WindowAbout
/// </summary>
public partial class WindowAbout : Form
{
public WindowAbout()
{
InitializeComponent();
}
		
void ClickAceptar(object sender, EventArgs e)
{
this.Close();
}
 }//End class
}//End namespace
