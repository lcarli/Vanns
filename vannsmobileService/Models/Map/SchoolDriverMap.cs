using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vannsmobileService.DataObjects;

namespace vannsmobileService.Models.Map
{
    public class SchoolDriverMap : EntityTypeConfiguration<SchoolDriver>
    {
        public SchoolDriverMap()
        {
            ToTable("SchoolDriver");
        }
    }
}
