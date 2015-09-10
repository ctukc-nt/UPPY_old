using System.Collections.Generic;

namespace UPPY.DIE.Import.Siemens
{

    /// <summary>
    /// Класс, обозначающий структуру проекта Siemens
    /// </summary>
    public class SiemensProject
    {
        private Article _article;

        public SiemensProject()
        {
            Article = null;
            Positions = new List<SiemensProject>();
        }

        public Article Article
        {
            get { return _article; }
            set
            {
                _article = value;
                Positions = new List<SiemensProject>();
            }
        }

        public List<string> FileNames { get; set; } = new List<string>(); 

        public SiemensProject Parent { get; set; }
        public List<SiemensProject> Positions { get; set; }
    }
}