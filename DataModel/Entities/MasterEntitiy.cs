using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class MasterEntitiy
    {
        public int Id { get; set; }
        public string Attribute2 { get; set; }

        public virtual List<SlaveEntity> RelationToEntitiy2{ get; set; }
    }
}
