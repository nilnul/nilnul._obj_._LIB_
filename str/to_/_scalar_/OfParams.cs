using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.to_._scalar_
{
	public interface OfParamsI<T>
	{
		T op(params T[] dbls);

	}
}
