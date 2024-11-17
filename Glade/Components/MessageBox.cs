using Gtk;

namespace ProjetoExemploGTKSharp.Glade.Components;

public static class MessageBox
{
    public static void Show(Window parent, string title, string message)
    {
        using (var dialog = new MessageDialog(
                   parent,
                   DialogFlags.Modal,
                   MessageType.Info,
                   ButtonsType.Ok,
                   message
               ))
        {
            dialog.Title = title;
            dialog.Run();
            dialog.Destroy();
        }
    }
}