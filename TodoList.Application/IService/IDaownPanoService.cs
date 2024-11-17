using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Application.DTOs;

namespace TodoList.Application.IService
{
    public interface IDaownPanoService
    {
        public Task<List<DownPanoDTO>> GetDownPanos();
        public Task<DownPanoDTO> CreateDownPano(DownPanoDTO downPano);
        public Task<DownPanoDTO> UpdateDownPano(DownPanoDTO downPano);
        public Task<bool> DeleteDownPano(Guid DownPanoId);
        public Task<DownPanoDTO> GetDownPanoById(Guid downPanoId);
    }
}
