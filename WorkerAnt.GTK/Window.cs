using System;
using Gtk;

namespace WorkerAnt.GTK
{
    public partial class Window : Gtk.Window
    {
        public Window() : base(Gtk.WindowType.Toplevel) => Build();

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }
    }
}