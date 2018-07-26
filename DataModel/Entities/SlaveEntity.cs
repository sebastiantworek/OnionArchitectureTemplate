using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class SlaveEntity
    {
        [Key]
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }

        public virtual MasterEntitiy RelationToEntity1 { get; set; }
    }
}
