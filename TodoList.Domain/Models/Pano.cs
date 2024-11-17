using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Domain.Models.BaseModels;

namespace TodoList.Domain.Models
{
    public class Pano:BaseModel
    {
        public string PanoName { get; set; }
        public virtual ICollection<DownPano> DownPanos { get; set; }

    }
}
