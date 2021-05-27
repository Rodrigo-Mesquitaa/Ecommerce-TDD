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
    public class ClienteController : BaseApiController<Cliente, ClienteViewModel, ParametroDePaginacao>
    {
        public ClienteController(IGenericRepository<Cliente> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}