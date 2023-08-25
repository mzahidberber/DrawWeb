using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Core.Data;

public interface IUnitOfWork:IDisposable
{
	Task<bool> CommitAsync(bool state = true);
	bool Commit(bool state = true);
}
