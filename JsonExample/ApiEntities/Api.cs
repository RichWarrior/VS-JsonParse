using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample.ApiEntities
{
    public class Api
    {
        public string Borsalar { get { return "https://www.doviz.com/api/v1/currencies/all/latest"; } }
        public string BIST_100_Bilesik { get { return "https://www.doviz.com/api/v1/indexes/XU100/latest"; } }
        public string BIST_ULUSAL_30 { get { return "https://www.doviz.com/api/v1/indexes/XU030/latest"; } }
        public string BIST_ULUSAL_50 { get { return "https://www.doviz.com/api/v1/indexes/XU050/latest"; } }
        public string Doviz { get { return "https://www.doviz.com/api/v1/currencies/all/latest"; } }
        public string Altin { get { return "https://www.doviz.com/api/v1/golds/all/latest"; } }
        public string Borsa_Istanbul_Detayli { get { return "https://www.doviz.com/api/v1/stocks/all/latest"; } }
        public string Kripto_Paralar { get { return "https://www.doviz.com/api/v1/coins/all/latest"; } }
    }
}
