using System;
using System.Collections.Generic;
using Core.Interfaces;
using DesktopApp.Infrastructure;

namespace DesktopApp.Interfaces
{
    public interface IDocsListForm<T> where T :IEntity, new()
    {
        IController<T> Controller { get; }
    }
}