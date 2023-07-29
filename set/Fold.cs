using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set
{
	public interface FoldI<T,TSet>
		:
		_fold_.OfSetI<T,TSet>
		where TSet: nilnul.obj.Set_blank_ofElmentI<T>
	{
	}
}
