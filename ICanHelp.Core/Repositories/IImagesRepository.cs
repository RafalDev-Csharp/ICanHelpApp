using ICanHelp.Core.Entities;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface IImagesRepository
    {
        Task<IEnumerable<Image>> GetAllImagesAsync();
        Task<Image?> GetImageByIdAsync(Id imageId);
        Task AddImageAsync(Image image);
        Task UpdateImageAsync(Image image);
        Task DeleteImageAsync(Image image);
    }
}
