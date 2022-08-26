using nilnul.obj.op._ed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary
{
	public class Ed<T>
		: _ed_.ResultA<T>
	{

		public Ed(T input, nilnul.obj.op_.UnaryI<T> op) : base(op.op(input))
		{

		}
		static public implicit operator T(Ed<T> ed)
		{
			return ed.result;
		}

		public override string ToString()
		{
			return result.ToString();
		}
	}
}
