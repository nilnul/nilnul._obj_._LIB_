using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border
{
	[Obsolete()]

	public class Duo1<T, TBorder,TBorder1>
		: nilnul.obj.border._duo_.ToTxtA< T, TBorder,TBorder1>

		where TBorder:nilnul.obj.BorderI<T>
		where TBorder1:nilnul.obj.BorderI<T>

	{



		private TBorder _lower;
		public override TBorder lower
		{
			get
			{
				return _lower;
				throw new NotImplementedException();
			}
		}

		private TBorder1 _upper;
		public override TBorder1 upper
		{
			get
			{
				return _upper;
				throw new NotImplementedException();
			}
		}

		public Duo1(TBorder item1, TBorder1 item2) 
		{
			_lower = item1;
			_upper = item2;

		}
	}
}
