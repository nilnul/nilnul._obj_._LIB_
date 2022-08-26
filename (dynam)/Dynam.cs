using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public class Dynam
	{
		private object _val;

		public object val
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


		public Dynam(object val, Type type)
		{
			obj.type.rel.IsInstanceOf.Assert(val, type);

			_val = val;
			_type = type;

		}
	



	}


	public class Dynam<T> : Dynam
	{
		public Dynam(T val)
			:base(val, typeof(T))
		{

		}

		static public implicit operator Dynam<T>(T val) {
			return new Dynam<T>(val);
		}

		static public implicit operator T(Dynam<T> val) {
			return (T)(val.val);
		}


	}
}
