using System;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Forms;
using DesktopApp.Interfaces;

namespace DesktopApp.Infrastructure
{
    public class FormsBuilder : IFormsBuilder
    {
        private readonly IControllerFactory _controllerFactory;


        public FormsBuilder(IControllerFactory controllerFactory)
        {
            _controllerFactory = controllerFactory;
        }

        public Form GetForm<T>(FormTypeEdition typeEdition)
        {
            if (typeof(T) == typeof(Drawing))
            {
                return new DrawingsListTreeForm(_controllerFactory.GetController<Drawing>());
            }

            return null;
        }

        public Form GetForm<T>()
        {
            return GetForm<T>(FormTypeEdition.List);
        }

        public Form GetForm<T>(T doc)
        {
            throw new NotImplementedException();
        }

        public Form GetMainForm()
        {
            throw new NotImplementedException();
        }
    }
}