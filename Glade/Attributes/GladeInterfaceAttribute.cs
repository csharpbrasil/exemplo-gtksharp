namespace ProjetoExemploGTKSharp.GladeComponents;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
sealed class GladeInterfaceAttribute : Attribute
{
    public string Namespace { get; }
    public string FormName { get; }

    public GladeInterfaceAttribute(string @namespace, string formName)
    {
        Namespace = @namespace;
        FormName = formName;
    }
}
