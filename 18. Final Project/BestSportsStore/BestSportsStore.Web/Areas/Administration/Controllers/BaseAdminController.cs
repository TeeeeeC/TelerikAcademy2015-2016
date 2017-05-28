namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using AutoMapper;
    using Infrastructure.Mapping;
    using System.Web.Mvc;

    [Authorize(Roles = "Administator")]
    public abstract class BaseAdminController : Controller
    {
        protected const int PageSize = 10;

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}