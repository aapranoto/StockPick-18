using System;
using System.Collections.Generic;
using System.Text;

namespace StockPick_18
{
    /// <summary>
    /// Select updbeat traded stock
    /// 
    /// </summary>

    class StockSelect
    {
        /// <summary>
        /// Key accounted parameters
        /// </summary>
        public string StName { get; }
        public decimal StPriceChg { get;  }
        public decimal StFreqChg { get;  }
        public decimal StTrdAmtChg { get;  }
        public string StTrend { get;  }
        public DateTime PointTime { get;  }
    }
}
