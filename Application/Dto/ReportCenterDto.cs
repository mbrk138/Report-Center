using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    public class ReportCenterDto
    {
        /// <summary>
        /// قیمت هر بلیط
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// تعداد بلیط
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// تاریخ 
        /// </summary>
        public int Date { get; set; }



    }
}
