using System.IO;

namespace System.Web.NHaml.TemplateBase
{
    public class TypedTemplate<T> : Template
    {
        // ReSharper disable UnusedMember.Global
        // ReSharper disable MemberCanBePrivate.Global
        // ReSharper disable VirtualMemberNeverOverriden.Global
        public T Model { get; set; }

        public void Render(TextWriter writer, T model)
        {
            Model = model;
            base.Render(writer);
        }

        public void Render(TextWriter writer, T model, HtmlVersion htmlVersion)
        {
            Model = model;
            base.Render(writer, htmlVersion);
        }

        // ReSharper restore VirtualMemberNeverOverriden.Global
        // ReSharper restore UnusedMember.Global
        // ReSharper restore MemberCanBePrivate.Global
    }
}
