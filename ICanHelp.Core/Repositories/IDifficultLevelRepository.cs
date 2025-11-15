using ICanHelp.Core.Entities;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface IDifficultLevelRepository
    {
        Task<IEnumerable<DifficultLevel>> GetAllDifficultLevelsAsync();
        Task<DifficultLevel?> GetDifficultLevelByIdAsync(Id difficultLevelId);
        Task AddDifficultLevelAsync(DifficultLevel difficultLevel);
        Task UpdateDifficultLevelAsync(DifficultLevel difficultLevel);
        Task DeleteDifficultLevelAsync(DifficultLevel difficultLevel);
    }
}
