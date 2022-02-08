using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Command
{
    public class RepotCenterCommand
    {
        /// <summary>
        /// نام تفریح
        /// </summary>
        public string FunType { get; set; }

        /// <summary>
        /// محل خرید
        /// </summary>
        public WhereBuy WhereBuy { get; set; }


    }
}
