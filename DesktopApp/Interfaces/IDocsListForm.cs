using System;
using System.Collections.Generic;
using DesktopApp.Infrastructure;

namespace DesktopApp.Interfaces
{
    public interface IDocsListForm<T>
    {
        IController<T> Controller { get; }
    }
}