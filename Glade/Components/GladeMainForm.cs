using Gtk;
namespace ProjetoExemploGTKSharp.Glade.Components;

public class GladeMainForm : GladeForm
{
    public GladeMainForm()
    {
        Form.DeleteEvent += (o, e) => Application.Quit();
    }
}