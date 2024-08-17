using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models;

public class Category
{
    [Key] // Explicitly defining primary key for the model
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public int DisplayOrder { get; set; }
}
