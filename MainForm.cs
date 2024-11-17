using Gtk;
using ProjetoExemploGTKSharp.Glade.Components;
using ProjetoExemploGTKSharp.GladeComponents;

namespace ProjetoExemploGTKSharp;

[GladeInterface(nameof(ProjetoExemploGTKSharp), "MainForm")]
public class MainForm : GladeMainForm
{
    private Button btnOpenMessageBox;
    private Button btnOpenForm1;
    
    public MainForm()
    {
        btnOpenMessageBox  = (Button)Builder.GetObject("btnOpenMessageBox");
        btnOpenMessageBox.Clicked += (sender, e) =>
        {
            MessageBox.Show(Form,"Success","Button clicked!");            
        };
        
        btnOpenForm1  = (Button)Builder.GetObject("btnOpenForm1");
        btnOpenForm1.Clicked += (sender, e) =>
        {
            new Form1();
        };
    }
}
