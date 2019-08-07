using System.ComponentModel.DataAnnotations;

namespace Intillegio.Models.Contracts
{
    interface IBaseId<T>
    {
        [Key]
        T Id { get; set; }
    }
}
