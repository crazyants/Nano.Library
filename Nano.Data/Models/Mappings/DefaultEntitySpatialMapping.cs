using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nano.Models;
using Nano.Models.Interfaces;

namespace Nano.Data.Models.Mappings
{
    /// <inheritdoc />
    public class DefaultEntitySpatialMapping<TEntity> : DefaultEntityMapping<TEntity>
        where TEntity : DefaultEntitySpatial, IEntityIdentity<Guid>
    {
        /// <inheritdoc />
        public override void Map(EntityTypeBuilder<TEntity> builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            base.Map(builder);

            builder
                .Ignore(x => x.Geometry); // TODO: Spatial actions (mapping is ignored) - awaiting EF.
        }
    }
}