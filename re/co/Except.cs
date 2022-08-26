using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re.co
{
	public class Except<TObj>
		:
		nilnul.obj.Box1<
			nilnul.obj.re.Co<TObj>
		>
		,
		nilnul.obj.ReI<TObj>
	{
		public Except(Co<TObj> val) : base(val)
		{
		}

		public Except(nilnul.obj.ReI<TObj> instance1, nilnul.obj.ReI<TObj> instance2) : this(
			new Co<TObj>(instance1, instance2)
		)
		{
		}
		public bool re(TObj a, TObj b)
		{
			return boxed.Item1.re(a, b) && !boxed.Item2.re(a, b);
			;
		}


	}
}
