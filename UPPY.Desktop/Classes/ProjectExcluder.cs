using Core.DomainModel;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Classes
{
    public class ProjectExcluder : IProjectExcluder
    {
        //public bool IsNeedExclude(Project project)
        //{
        //    if (project == null)
        //        return false;

        //    return dkData.ProjectExceptionSet.Any(projectException => projectException.Mark == project.GOSTS || (project.Name != null && project.Name.Contains(projectException.Mark)));

        //    //if (Enumerable.Any(dkData.ProjectExceptionSet, exc => aggrName.Contains(exc.Mark)))
        //    //{
        //    //    return true;
        //    //}
        //}

        public bool IsNeedExclude(Drawing project)
        {
            return false;
        }

        public bool IsNeedExclude(Position position)
        {
            return false;
        }
    }
}
