using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.ref_.expr
{
	public partial class Ref<T>
		:ExprI<T>
	{
		private obj.RefI<T> _ref;

		public obj.RefI<T> ref_
		{
			get { return _ref; }
			set { _ref = value; }
		}

	

		
	}
}
