﻿namespace WebSite.Models;

public static class DbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        CrmDbContext context = applicationBuilder.ApplicationServices.CreateScope()
            .ServiceProvider.GetRequiredService<CrmDbContext>();


        if (!context.Requests.Any())
        {
            List<Request> requests = new()
            {
                new Request
                {
                     Id = Guid.NewGuid(),
                     Content = "asdf",
                     Email = "a@s.c",
                     Name = "Test",
                     Status = Status.Open
                },
                new Request
                {
                     Id = Guid.NewGuid(),
                     Content = "asdf",
                     Email = "b@s.c",
                     Name = "Test",
                     Status = Status.Open
                },
                new Request
                {
                     Id = Guid.NewGuid(),
                     Content = "asdf",
                     Email = "s@s.c",
                     Name = "Test",
                     Status = Status.InProgress
                },
                new Request
                {
                     Id = Guid.NewGuid(),
                     Content = "asdf",
                     Email = "a@s.c",
                     Name = "Test",
                     Status = Status.Completed
                },
            };
            context.AddRange(requests);
        }

        if (!context.BlogPosts.Any())
        {
            List<BlogPost> blogs = new()
            {
                new BlogPost
                {
                    Title = "1С: Производственная Безопасность",
                    Content  = "Решения обеспечивают автоматизацию процессов учета, планирования, контроля и формирования аналитической отчетности в соответствии с требованиями законода­ тельства РФ, отраслевой и корпоративной специфики.",
                    Created = DateTime.UtcNow.AddDays(-1),
                    Id = new Guid("8a10a985-9aeb-45d5-9c42-007489f9f4a3"),
                    ImageUrl = ""
                },
                new BlogPost
                {
                    Title = "1С: Производственная Безопасность",
                    Content  = "Решения обеспечивают автоматизацию процессов учета, планирования, контроля и формирования аналитической отчетности в соответствии с требованиями законода­ тельства РФ, отраслевой и корпоративной специфики.",
                    Created = DateTime.UtcNow.AddDays(-1),
                    Id = new Guid("f1cf680b-5b19-440b-9903-f51197ccebd6"),
                    ImageUrl = ""
                },
                new BlogPost
                {
                    Title = "1С: Производственная Безопасность",
                    Content  = "Решения обеспечивают автоматизацию процессов учета, планирования, контроля и формирования аналитической отчетности в соответствии с требованиями законода­ тельства РФ, отраслевой и корпоративной специфики.",
                    Created = DateTime.UtcNow.AddDays(-1),
                    Id = new Guid("ceb6f4b7-aaa7-4da9-87a3-713e047a58c8"),
                    ImageUrl = ""
                },
                        new BlogPost
                {
                    Title = "1С: Производственная Безопасность",
                    Content  = "Решения обеспечивают автоматизацию процессов учета, планирования, контроля и формирования аналитической отчетности в соответствии с требованиями законода­ тельства РФ, отраслевой и корпоративной специфики.",
                    Created = DateTime.UtcNow.AddDays(-1),
                    Id = new Guid("3e00cb8e-9289-47cd-91e6-c13732bbbdf7"),
                    ImageUrl = ""
                },
             };

            context.AddRange(blogs);
        }

        if (context.ChangeTracker.HasChanges())
        {
            context.SaveChanges();
        }
    }
}
