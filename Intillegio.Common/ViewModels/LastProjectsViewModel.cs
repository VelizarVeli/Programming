using System;
using Intillegio.Models;

namespace Intillegio.Common.ViewModels
{
    public class LastProjectsViewModel
    {
        public Guid Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public Stage Stage { get; set; }

        public Category Category { get; set; }
    }
}
