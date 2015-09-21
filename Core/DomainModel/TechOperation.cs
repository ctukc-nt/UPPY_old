using Core.Interfaces;

namespace Core.DomainModel
{
    /// <summary>
    ///     Технологическая операция
    /// </summary>
    public class TechOperation : IEntity
    {
        public int? Id { get; set; }

        public bool IsDelete { get; set; }

        /// <summary>
        ///     Сокращённое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        ///     Полное наименование
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Порядок при печати (выводе на экран)
        /// </summary>
        public byte OrderInPrint { get; set; }

        public override string ToString()
        {
            return ShortName;
        }
    }
}