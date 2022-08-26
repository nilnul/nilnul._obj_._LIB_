using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary.recur
{
	

	

	public class Slider< T, TOp>
		:
		Slider1<T,TOp, unary.RecurI<T, TOp>>
		,
		nilnul.obj.stream_.SliderI<T>

		where TOp: obj.op_.UnaryI<T>

	{
		public Slider(unary.RecurI<T, TOp> val) : base(val)
		{
		}
	}

	public class Slider< T>
		:
		Slider<T, op_.UnaryI<T>>
		,
		nilnul.obj.stream_.SliderI<T>


	{
		public Slider(unary.RecurI<T> val) : base(val)
		{
		}

	}

}
