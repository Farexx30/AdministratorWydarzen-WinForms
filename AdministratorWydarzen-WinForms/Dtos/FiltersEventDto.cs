using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Dtos
{
    public class FiltersEventDto
    {
        public DateOnly? FilterByDateValue { get; set; }
        public int? FilterByTypeValueId { get; set; }
        public int? FilterByPriorityValueId { get; set; }
    }
}
