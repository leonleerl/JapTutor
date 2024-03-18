using System.Collections;
using JapTutor.Shared.Models;
using Microsoft.CodeAnalysis.FlowAnalysis;

namespace JapTutor.WebApi.Repositories.Interface;

public interface IBasicPronunciationRepository
{
    public Task<IEnumerable<BasicInfo>?> GetAllAsync();
    public IEnumerable<BasicInfo>? GetByName(string name);
    public Task<BasicInfo?> GetById(string id);
    public IEnumerable<BasicInfo>? GetAllHiragana();
    public IEnumerable<BasicInfo>? GetAllKatakana();
    public IEnumerable<BasicInfo>? GetAllKanji();
}