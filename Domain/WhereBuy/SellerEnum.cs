using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Enum
{
    public enum WhereBuy
    {
        [Description("سایت")] Site = 1,
        [Description("فروشگاه")] Seller = 2,
        [Description("حظوری")] Presence = 3
    }

}
