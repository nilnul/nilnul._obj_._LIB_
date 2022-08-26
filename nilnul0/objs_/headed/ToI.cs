using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.headed
{
	public interface ToI<TEl, TTgt>

	{
		TTgt to(TEl head, IEnumerable<TEl> body);
	}
}
