using nilnul.obj.op._ed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public class Converted<T, TOp>
		: _converted_.ResultA<T> 
		where TOp : nilnul.obj.ConvertI<T>
	{

		public Converted(T input, TOp op):base(op.eval(input))
		{

		}
		static public implicit operator T(Converted<T, TOp> ed) {
			return ed.result;
		}
		 
	}

	
	 
}
