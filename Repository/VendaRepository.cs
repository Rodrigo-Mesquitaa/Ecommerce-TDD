using Core.Architecture;
using ModelData.Context;
using ModelData.Model;

namespace Repository
{
    public class VendaRepository : GenericRepository<EcommerceContext, Venda>, IGenericRepository<Venda>
    {
        public VendaRepository(EcommerceContext context) : base(context)
        { }
    }
}
