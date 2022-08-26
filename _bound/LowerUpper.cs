using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound
{
	public interface LowerUpperI<T, TLower,TUpper>
		where TLower: _bound.LowerI<T>
		where TUpper:_bound.UpperI<T>
	{
		TLower lower { get; }
		TUpper upper { get; }
	}

	public  class LowerUpperA<T, TLower, TUpper>
		:LowerUpperI<T,TLower,TUpper>
		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>

	{
		private TLower _lower;

		public TLower lower
		{
			get { return _lower; }
			set { _lower = value; }
		}

		private TUpper _upper;

		public TUpper upper
		{
			get { return _upper; }
			set { _upper = value; }
		}

		public LowerUpperA(TLower lower, TUpper upper)
		{
			_lower = lower;
			_upper = upper;
		}
	}
}
