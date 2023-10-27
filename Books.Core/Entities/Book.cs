using Books.Core.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Entities;

public class Book : BaseEntity
{
    public required string Name { get; set; }
    public int WriterId { get; set; }
    public virtual Writer? Writers { get; set; }
    public  required string BodyFileSrc { get; set; }
    public required string  CoverImageSrc { get; set; }
    public string? Disrcription { get; set; }
    public decimal Price { get; set; }
}
