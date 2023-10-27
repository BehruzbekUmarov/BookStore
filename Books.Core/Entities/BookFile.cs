using Books.Core.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Entities;

public class BookFile : BaseEntity
{
    public new Guid Id { get; set; }
    public required string Path { get; set; }
    public float Size { get; set; }
    public int BookId { get; set; }
    public virtual Book? Books { get; set; }
    public required string FileExtension { get; set; }
}
