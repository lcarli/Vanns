using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vannsmobileService.DataObjects;

namespace vannsmobileService.Models.Map
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            ToTable("Client");
        }
    }
}
