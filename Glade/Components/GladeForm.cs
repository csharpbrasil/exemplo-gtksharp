using System.Reflection;
using Gtk;
using ProjetoExemploGTKSharp.GladeComponents;

namespace ProjetoExemploGTKSharp.Glade.Components;

public abstract class GladeForm
{
    protected Builder Builder { get; private set; }
    protected Window Form { get; private set; }

    protected GladeForm()
    {
        var attribute = GetType().GetCustomAttribute<GladeInterfaceAttribute>();
        if (attribute == null)
            throw new InvalidOperationException($"The class {GetType().Name} does not have the [GladeInterface] attribute.");
        
        var assembly = Assembly.GetExecutingAssembly();
        using (var stream = assembly.GetManifestResourceStream($"{attribute.Namespace}.{attribute.FormName}.glade"))
        {
            if (stream == null)
                throw new Exception($"Resource {attribute.Namespace}.{attribute.FormName} not found!");

            using (var reader = new StreamReader(stream))
            {
                Builder = new Builder();
                Builder.AddFromString(reader.ReadToEnd());
                Form = (Window)Builder.GetObject(attribute.FormName);
                Form.ShowAll();
            }
        }
    }
}
