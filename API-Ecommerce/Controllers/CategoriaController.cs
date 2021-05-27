using API_Ecommerce.Model;
using AutoMapper;
using Core.Architecture;
using Microsoft.AspNetCore.Mvc;
using ModelData.Model;
using ModelData.ViewModel;

namespace API_Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : BaseApiController<Categoria, CategoriaViewModel, ParametroDePaginacao>
    {
        public CategoriaController(IGenericRepository<Categoria> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}