using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound.lowerUpper
{
	public interface BeI<T,TLower,TUpper>
		:
		nilnul.obj.BeI1<  LowerUpperI<T,TLower,TUpper> >
		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>

	{
	}

}
