using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq
{
	public interface EqI<TEle>:IEqualityComparer<IEnumerable<TEle>>
	{
	}
}
