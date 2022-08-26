using nilnul.obj.op._ed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.convert
{
	public class Ed<T, TOp>
		: _converted_.ResultA<T> 
		where TOp : nilnul.obj.ConvertI1<T>
	{

		public Ed(T input, TOp op):base(op.convert(input))
		{

		}
		static public implicit operator T(Ed<T, TOp> ed) {
			return ed.result;
		}
		 
	}

	
	 
}
