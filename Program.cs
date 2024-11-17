using Gtk;

namespace ProjetoExemploGTKSharp;

class Program
{
    static void Main(string[] args)
    {
        Application.Init();
        new MainForm();
        Application.Run();
    }
}
