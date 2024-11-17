using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Domain.Models.BaseModels
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedUser { get; set; }=null;
        public DateTime? UpdatedDate { get; set;}=null;
        public string? Description { get; set; } = null;
    }
}
