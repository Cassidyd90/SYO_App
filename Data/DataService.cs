using Microsoft.EntityFrameworkCore;
using SYO_App.Models;
using System.Runtime.CompilerServices;

namespace SYO_App.Data
{
    public interface IDataService
    {
        Task<List<Question>> GetQuestionsAsync();
        Task<List<Question>> GetTop2QuestionsAsync();
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

        public async Task<List<Question>> GetTop2QuestionsAsync()
        {
            return await _dbContext.Questions.Take(2).ToListAsync();
        }
    }
}

