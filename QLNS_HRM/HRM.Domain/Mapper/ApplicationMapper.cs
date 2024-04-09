using AutoMapper;
using HRM.Domain.Data;
using HRM.Domain.DTO;

namespace HRM.Domain.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() { 
            CreateMap<Department,DepartmentDTO>()
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src.DepartmentID))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.DepartmentName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.PositionID, opt => opt.MapFrom(src => src.PositionID))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.Employees))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position));
            CreateMap<Employee,EmployeeDTO>().ReverseMap();

        }
    }
}
