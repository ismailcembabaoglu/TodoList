using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Application.DTOs
{
    public class DownPanoDTO
    {
        public string DownPanoName { get; set; }
        public Guid PanoId { get; set; }
        public string? PanoName { get; set; }
    }
}
