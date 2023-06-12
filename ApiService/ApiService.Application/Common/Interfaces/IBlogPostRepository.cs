using ApiService.Application.Domain.Entities;

namespace ApiService.Application.Common.Interfaces;

public interface IBlogPostRepository
{
    Task<IReadOnlyList<BlogPost>> GetAllBlogPosts();
    Task<BlogPost?> GetById(Guid id);
}
