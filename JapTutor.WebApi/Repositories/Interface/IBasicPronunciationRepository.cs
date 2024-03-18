using JapTutor.WebApi.Models;

namespace JapTutor.WebApi.Repositories.Interface;

public interface IBasicPronunciationRepository
{
    public Task<IEnumerable<BasicPronunciation>?> GetAllAsync();
    public Task<BasicPronunciation?> GetByNameAsync(string name);
}