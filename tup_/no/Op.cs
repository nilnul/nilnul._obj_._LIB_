using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.no
{
	public class Op
	{
		private dynamic _val;

		public dynamic val
		{
			get { return _val; }
			set { _val = value; }
		}

		private Type _type;

		public Type type
		{
			get { return _type; }
			set { _type = value; }
		}

		public Op(Type type, dynamic val)
		{
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(val.GetType(), type);
			_type = type;
			_val = val;

		}

		public dynamic eval() {
			return _val;
		}
	}
}
