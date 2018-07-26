using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample.ResponseEntities
{
    public class Exchange
    {
        //Her Apiden Gelen Değere Göre Veri Veri Oluşturman Lazım
        public object selling { get; set; }
        public object buying { get; set; }
        public object full_name { get; set; }
        public object code { get; set; }
    }
}
