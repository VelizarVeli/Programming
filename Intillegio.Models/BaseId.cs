using System;
using System.ComponentModel.DataAnnotations;
using Intillegio.Models.Contracts;

namespace Intillegio.Models
{
    public abstract class BaseId : IBaseId<Guid>
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
    }
}
