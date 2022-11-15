using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypeValeur.ApresRecord
{
    public record MyRecord
    {
        public int idClient { get; set; }
        public string nomClient { get; set; }
        public DateTime dateCreation { get; set; }
    }
}
