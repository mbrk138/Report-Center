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
        public int Count { get; set; }

        /// <summary>
        /// تعداد بلیط
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// تاریخ 
        /// </summary>
        public int SubmitDate { get; set; }
    }


}
