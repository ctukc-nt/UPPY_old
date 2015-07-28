using System.Windows.Forms;

namespace DesktopApp.Interfaces
{
    public interface IFormsBuilder
    {
        Form GetForm<T>(FormTypeEdition typeEdition);
        Form GetForm<T>();
        Form GetMainForm();
    }

    public enum FormTypeEdition
    {
        List,
        Object,
        SelectDocument
    }
}