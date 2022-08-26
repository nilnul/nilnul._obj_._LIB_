using nilnul.obj.op._ed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary.ed_
{
	

	public class OpDefault<T, TOp>
		: Ed<T>
		where TOp : nilnul.obj.op_.UnaryI<T>,new()
	{

		public OpDefault(T input ) : base(input, nilnul.obj_.Singleton<TOp>.Instance)
		{

		}
		static public implicit operator T(OpDefault<T, TOp> ed)
		{
			return ed.result;
		}

	}

	



}
