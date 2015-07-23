using Core.Interfaces;

namespace Core.DomainModel
{
    /// <summary>
    ///     Технологическая операция
    /// </summary>
    public class TechOperation : IEntity
    {
        public int? Id { get; set; }

        /// <summary>
        ///     Сокращённое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        ///     Полное наименование
        /// </summary>
        public string FullName { get; set; }

        public override string ToString()
        {
            return ShortName;
        }
    }
}