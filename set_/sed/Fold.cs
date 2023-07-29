using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set_.sed
{
	public interface FoldI<T,TSet>
		:_fold_.FoldI<T,TSet>

		where TSet: nilnul.obj.set_.Sed_blank_ofElmentI<T>
	{
	}
}
