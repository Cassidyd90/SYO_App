using Microsoft.EntityFrameworkCore;
using SYO_App.Models;

namespace SYO_App.Data
{
    public interface IDataService
    {
        Task<List<Question>> GetQuestionsAsync();
    }

    public class DataService : IDataService
    {
        private readonly ApplicationDbContext _dbContext;

        public DataService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Question>> GetQuestionsAsync()
        {
            return await _dbContext.Questions.ToListAsync();
        }
    }
}
