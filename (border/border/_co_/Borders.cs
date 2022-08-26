using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border._co_
{
	public interface BordersI<TLower, TUpper>
		:
		LowerI<TLower>
		,
		UpperI<TUpper>
	{

	}

	public interface BordersI<TBorder>
		: BordersI<TBorder, TBorder>
	{

	}


}
