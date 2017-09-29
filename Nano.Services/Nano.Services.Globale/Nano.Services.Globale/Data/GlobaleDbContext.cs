﻿using System;
using Microsoft.EntityFrameworkCore;
using Nano.App.Data.Extensions;
using Nano.Data;
using Nano.Services.Globale.Data.Mappings;
using Nano.Services.Globale.Models;
using TimeZone = Nano.Services.Globale.Models.TimeZone;

namespace Nano.Services.Globale.Data
{
    /// <inheritdoc />
    public class GlobaleDbContext : BaseDbContext
    {
        /// <inheritdoc />
        public GlobaleDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            base.OnModelCreating(modelBuilder);

            modelBuilder
                .AddMapping<Address, AddressMapping>()
                .AddMapping<City, CityMapping>()
                .AddMapping<Country, CountryMapping>()
                .AddMapping<Currency, CurrencyMapping>()
                .AddMapping<Language, LanguageMapping>()
                .AddMapping<TimeZone, TimeZoneMapping>();
        }
    }
}
