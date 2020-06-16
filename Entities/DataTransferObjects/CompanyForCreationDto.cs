using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class CompanyForCreationDto : CompanyForManipulationDto

    {
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
