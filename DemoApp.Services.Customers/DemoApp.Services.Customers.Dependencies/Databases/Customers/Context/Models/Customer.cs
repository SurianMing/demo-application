using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoApp.Services.Customers.Dependencies.Databases.Customers.Context.Models;

internal class Customer
{
    public Guid CustomerId { get; set; }
    public required string FirstName { get; set; }
    public required string Surname { get; set; }
}

internal class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customer");

        builder.HasKey(entity => entity.CustomerId);

        builder.Property(entity => entity.FirstName)
            .HasMaxLength(100);
        builder.Property(entity => entity.Surname)
            .HasMaxLength(100);
    }
}