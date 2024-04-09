using AutoMapper;
using HRM.BusinessLogic;
using HRM.DataAccess.Repositories;
using HRM.Domain.Data;
using HRM.Domain.DTO;
using HRM_API.ViewModel;

namespace QLNS_HRM.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            #region Repository
            services.AddScoped(typeof(GenericRepository<>)); // Đăng ký GenericRepository<>
            services.AddScoped<DepartmentRepository>();
            #endregion
            #region Services
            services.AddScoped<DepartmentService>();
            #endregion
            return services;
        }
    }
}
