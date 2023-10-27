using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Entities.Abstractions;

public abstract class BaseEntity
{
    public virtual int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set;}
    public bool IsDeleted { get; set; }
}
    