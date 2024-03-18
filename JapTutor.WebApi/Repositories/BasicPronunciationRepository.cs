using JapTutor.WebApi.Data;
using JapTutor.WebApi.Models;
using JapTutor.WebApi.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace JapTutor.WebApi.Repositories;

public class BasicPronunciationRepository : IBasicPronunciationRepository
{
    private readonly JapTutorDbContext _context;

    public BasicPronunciationRepository(JapTutorDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BasicPronunciation>?> GetAllAsync()
    {
        return await _context.BasicPronunciations.ToListAsync();
    }

    public async Task<BasicPronunciation?> GetByNameAsync(string name)
    {
        return await _context.BasicPronunciations.FirstOrDefaultAsync(c => c.Name == name);
    }
}