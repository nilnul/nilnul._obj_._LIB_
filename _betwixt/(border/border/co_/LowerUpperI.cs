using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co_
{
	public interface LowerUpperI<T, TLower,TUpper>
		where TLower: border_.LowerI<T>
		where TUpper:border_.UpperI<T>
	{
		TLower lower { get; }
		TUpper upper { get; }
	}
}
