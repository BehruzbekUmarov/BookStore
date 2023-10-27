using Books.Core.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Entities;

public class Writer : BaseEntity
{
    public required string FullName { get; set; }
    public ICollection<Book>? Books { get; set; }
    public ICollection<BookSeries>? BookSeries { get; set; }
}
