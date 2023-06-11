using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace WebSite.Models;

public class Request
{
    [BindNever]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Пожалуйста, представьтесь")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Пожалуйста, введите email")]
    [StringLength(100)]
    [EmailAddress(ErrorMessage = "Такой email адрес не существует")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Сообщение не должно быть пустым")]
    [StringLength(100)]
    public string Content { get; set; } = string.Empty;
    public Status Status { get; set; } = Status.Open;
    public DateTime Created { get; set; }
}
