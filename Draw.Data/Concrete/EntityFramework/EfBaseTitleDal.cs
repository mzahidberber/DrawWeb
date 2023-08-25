using Draw.Core.Data;
using Draw.Core.Entity;
using Draw.Data.Abstract;

namespace Draw.Data.Concrete.EntityFramework;

public class EfBaseTitleDal : EfGenericRepository<BaseTitle>, IBaseTitleRepository
{
	public EfBaseTitleDal(DrawContext context) : base(context)
	{
	}
}
