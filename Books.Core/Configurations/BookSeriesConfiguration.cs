﻿using Books.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Books.Core.Configurations;

public class BookSeriesConfiguration : IEntityTypeConfiguration<BookSeries>
{
    public void Configure(EntityTypeBuilder<BookSeries> builder)
    {
        builder.HasIndex(f => f.WriterId);
        builder.HasIndex(f => f.BookIds);
    }
}
