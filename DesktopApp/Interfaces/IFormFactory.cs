using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DesktopApp.Interfaces
{
    public interface IFormFactory
    {
        Form GetForm(Type objectType, FormTypeEdition typeEdition);

        Form GetMainForm();
    }

    public enum FormTypeEdition
    {
        List,
        Object,
        SelectDocument
    }
}