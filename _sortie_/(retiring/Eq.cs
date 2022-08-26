using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._suc_
{
	public interface EqI<T>
	{
		IEqualityComparer<T> eq { get; }
	}
}
