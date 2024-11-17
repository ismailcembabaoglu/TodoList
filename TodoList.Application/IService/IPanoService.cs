using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Application.DTOs;

namespace TodoList.Application.IService
{
    public interface IPanoService
    {
        public Task<List<PanoDTO>> GetPanos();
        public Task<PanoDTO> CreatePano(PanoDTO pano);
        public Task<PanoDTO> UpdatePano(PanoDTO pano);
        public Task<bool> DeletePano(Guid panoId);
        public Task<PanoDTO> GetPanoById(Guid panoId);
    }
}
