using ApiService.Application.Domain.Entities;

namespace ApiService.Application.Common.Interfaces;

public interface IBlogPostRepository
{
    IReadOnlyList<BlogPost> AllBlogPosts { get; }
    BlogPost? GetById(Guid id);
}
