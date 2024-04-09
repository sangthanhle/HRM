using AutoMapper;
using HRM.Domain.DTO;
using HRM_API.ViewModel;

namespace HRM_API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper() 
        { 
        CreateMap<DepartmentDTO,DepartmentVM>().ReverseMap();   
        CreateMap<EmployeeDTO,EmployeeVM>().ReverseMap();   
        }
    }
}
