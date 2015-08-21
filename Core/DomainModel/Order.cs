using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModel
{
    public class Order
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер заказа
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// Клиент
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// Дата запуска
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Дедлайн
        /// </summary>
        public DateTime DeadlineDate { get; set; }

        /// <summary>
        /// Фактическая дата отправки
        /// </summary>
        public DateTime DateSend { get; set; }

        /// <summary>
        /// Признак полного выполнения
        /// </summary>
        public bool IsClosed { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Продукция
        /// </summary>
        public int? DrawingId { get; set; } 
    }
}
