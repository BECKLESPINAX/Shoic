#region [Using]
using System;
using System.Windows.Forms;
#endregion [Using]

namespace SHOIC
{
public partial class WindowMessage1 : Form
{
#region [Constructor]
public WindowMessage1()
{
InitializeComponent();
}
#endregion

#region [Load]
private void WindowMessage_Load(object sender, EventArgs e)
{

}
#endregion [Load]

#region [GetSet]

#endregion [GetSet]

#region [Event]
void ClickWindowMessage(object sender, EventArgs e)
{
Close();
}
void KeyDownWindowMessage(object sender, KeyEventArgs e)
{
Close();
}

private void ClickOk(object sender, EventArgs e)
{
Close();
}
#endregion [Event]

#region [Timer]
private void TimerMessage_Tick(object sender, EventArgs e)
{

}
#endregion [Timer]



	}//End class
}//End namespace
