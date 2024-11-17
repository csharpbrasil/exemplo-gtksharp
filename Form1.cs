using Gtk;
using ProjetoExemploGTKSharp.Glade.Components;
using ProjetoExemploGTKSharp.GladeComponents;

namespace ProjetoExemploGTKSharp;

[GladeInterface(nameof(ProjetoExemploGTKSharp), "Form1")]
public class Form1 : GladeForm
{
    private Button btnShowMessageBox;
    
    public Form1()
    {
        btnShowMessageBox = (Button)Builder.GetObject("btnShowMessageBox");
        btnShowMessageBox.Clicked += (o, e) =>
        {
            MessageBox.Show(Form, "Success", "This is a sample message produced with GTK Sharp.");
        };
    }
}