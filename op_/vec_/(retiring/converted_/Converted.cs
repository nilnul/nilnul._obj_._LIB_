using nilnul.obj.op._ed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.converted_
{
	

	public class ConvertDefault<T, TOp>
		: Converted<T, TOp>
		where TOp : nilnul.obj.ConvertI<T>, new()

	{
		public ConvertDefault(T input) : base(input, SingletonByDefault<TOp>.Instance)
		{
		}
	}

	public class ConvertGeneral<T> : Converted<T, nilnul.obj.ConvertI<T>>
	{
		public ConvertGeneral(T input, obj.ConvertI<T> op) : base(input, op)
		{
		}
	}
	 
}
