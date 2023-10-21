using ConsoleApp1.Modelss;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FirstName).HasMaxLength(15);

            builder.Property(e => e.LastName).HasMaxLength(25);
           
        }
    }
}
