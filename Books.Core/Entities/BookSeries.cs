using Books.Core.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Entities;

public class BookSeries : BaseEntity
{
    public required string Name { get; set; }
    public List<int> BookIds { get; set; } = new();
    public int WriterId { get; set; }
    public virtual Writer? Writers { get; set; }
}
