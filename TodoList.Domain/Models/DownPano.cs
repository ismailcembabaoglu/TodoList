using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Domain.Models.BaseModels;

namespace TodoList.Domain.Models
{
    public class DownPano:BaseModel
    {
        public string DownPanoName { get; set; }
        public virtual Pano Pano { get; set; }
        public Guid PanoId { get; set; }


    }
}
