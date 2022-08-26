using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	public interface CombineI<T>
		:nilnul.obj.CombineI<BeI<T>>
	{
	}
}
