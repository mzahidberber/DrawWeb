using Draw.Core.Data;
using Draw.Core.Entity;
using Draw.Data.Abstract;

namespace Draw.Data.Concrete.EntityFramework;

public class EfSubTitleDal : EfGenericRepository<SubTitle>, ISubTitleRepository
{
	public EfSubTitleDal(DrawContext context) : base(context)
	{
	}
}
