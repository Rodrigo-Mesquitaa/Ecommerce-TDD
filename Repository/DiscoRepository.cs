using Core.Architecture;
using ModelData.Context;
using ModelData.Model;

namespace Repository
{
    public class DiscoRepository : GenericRepository<EcommerceContext, Disco>, IGenericRepository<Disco>
    {
        public DiscoRepository(EcommerceContext context) : base(context)
        { }
    }
}
