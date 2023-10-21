using ConsoleApp1.Modelss;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configuration
{
    public class PressConfiguration : IEntityTypeConfiguration<Press>
    {
        public void Configure(EntityTypeBuilder<Press> builder)
        {
            builder.ToTable("Press");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(30);
        }
    }
}
