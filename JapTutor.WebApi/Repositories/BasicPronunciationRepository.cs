using JapTutor.Shared.Enum;
using JapTutor.Shared.Models;
using JapTutor.WebApi.Data;
using JapTutor.WebApi.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace JapTutor.WebApi.Repositories;

public class BasicInfoRepository : IBasicInfoRepository
{
    private readonly JapTutorDbContext _context;

    public BasicInfoRepository(JapTutorDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BasicInfo>?> GetAllAsync()
    {
        return await _context.BasicInfos.ToListAsync();
    }

    public IEnumerable<BasicInfo>? GetByName(string name)
    {
        return _context.BasicInfos.Where(c => c.Name == name);
    }

    public async Task<BasicInfo> GetById(string id)
    {
        return await _context.BasicInfos.FirstOrDefaultAsync(c => c.Id == id);
    }

    public IEnumerable<BasicInfo> GetAllHiragana()
    {
        return _context.BasicInfos.Where(c => c.Type == BasicInfoEnum.Hiragana);
    }

    public IEnumerable<BasicInfo> GetAllKatakana()
    {
        return _context.BasicInfos.Where(c => c.Type == BasicInfoEnum.Katakana);
    }

    public IEnumerable<BasicInfo> GetAllKanji()
    {
        return _context.BasicInfos.Where(c => c.Type == BasicInfoEnum.Kanji);
    }

}