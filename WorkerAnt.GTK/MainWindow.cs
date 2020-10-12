using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(WindowType.Toplevel) => Build();

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        var wins = new WorkerAnt.GTK.Window();
        wins.Show();
    }
}
