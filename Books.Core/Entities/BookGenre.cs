using Books.Core.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Entities;

public class BookGenre : BaseEntity
{
    public int BookId { get; set; }
    public virtual Book? Books { get; set; }
    public int GenreId { get; set; }
    public virtual Genre? Genres { get; set;}
}
