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
    public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(20);
        }
    }
}
