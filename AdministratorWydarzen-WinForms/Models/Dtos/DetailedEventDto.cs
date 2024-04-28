using AdministratorWydarzen_WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Models.Dtos
{
    public class DetailedEventDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int EventTypeId { get; set; }
        public int EventPriorityId { get; set; }
    }
}
