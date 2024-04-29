using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Dtos
{
    public class SortDataEventDto
    {
        public int SortByValueId { get; set; } = 0;
        public SortDirection SortDirection { get; set; } = SortDirection.ASC;
    }

    public enum SortDirection
    {
        ASC,
        DESC
    }
}
