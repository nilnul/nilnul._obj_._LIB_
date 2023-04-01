using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border
{
	public class Co<T, TLower,TUpper>
		:

		nilnul.obj.border._co_.ToTxtA< T, TLower,TUpper>
		,
		CoI<T,TLower,TUpper>

		where TLower:nilnul.obj.BorderI<T>
		where TUpper:nilnul.obj.BorderI<T>

	{



		private TLower _lower;
		public override TLower lower
		{
			get
			{
				return _lower;
				throw new NotImplementedException();
			}
		}

		private TUpper _upper;
		public override TUpper upper
		{
			get
			{
				return _upper;
				throw new NotImplementedException();
			}
		}

		public Co(TLower item1, TUpper item2) 
		{
			_lower = item1;
			_upper = item2;

		}
	}

	public class Co<T, TBorder> : Co<T, TBorder, TBorder>
		,
		CoI<T,TBorder>
				where TBorder : nilnul.obj.BorderI<T>

	{
		public Co(TBorder item1, TBorder item2) : base(item1, item2)
		{
		}
	}
}
