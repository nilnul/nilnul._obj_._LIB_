using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary.recur.slider_
{
	public class RecurDefault<T, TOp, TRecur>
		:
		Slider1<
			T, TOp, TRecur
		>
		where TOp : nilnul.obj.op_.UnaryI<T>

		where TRecur : RecurI<
			T, TOp
		>, new()

	{
		public RecurDefault()
			:
		base(
			nilnul._obj.typ_.nilable_.unprimable_.Singleton<TRecur>.Instance
		)
		{
		}

	}
	public class RecurDefault<T,  TRecur>
		:
		RecurDefault<
			T, obj.op_.UnaryI<T>, TRecur
		>

		where TRecur : RecurI<
			T, obj.op_.UnaryI<T>
		>, new()

	{
		

	}


}
