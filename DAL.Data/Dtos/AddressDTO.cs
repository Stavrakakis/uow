﻿namespace DAL.Database.Dtos
{
    using Domain.Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;

    public class AddressDto : IMapTo<Address>
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string Country { get; set; }

        public Address Map()
        {
            throw new NotImplementedException();
        }
    }

    public class AddressDtoConfiguration : EntityTypeConfiguration<AddressDto>
    {
        public AddressDtoConfiguration()
        {
            this.ToTable("Addresses");
            this.HasKey(u => u.Id);
        }
    }
}
