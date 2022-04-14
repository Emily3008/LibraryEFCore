using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Configuration
{
    public class LineItemConfig : IEntityTypeConfiguration<LineItem>
    {
        public void Configure(EntityTypeBuilder<LineItem> builder)
        {
            builder.HasOne(x => x.ChosenBook).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
