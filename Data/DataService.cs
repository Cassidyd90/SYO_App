using Microsoft.EntityFrameworkCore;
using SYO_App.Models;
using System.Runtime.CompilerServices;

namespace SYO_App.Data
{
    public interface IDataService
    {
        Task<List<Question>> GetAllQuestionsAsync();
        Task<List<User>> GetAllUsersAsync();
    }

    public class DataService : IDataService
    {
        private readonly ApplicationDbContext _dbContext;

        public DataService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Question>> GetAllQuestionsAsync()
        {
            return await _dbContext.QuestionsAll.ToListAsync();
        }


        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }




    }
}

