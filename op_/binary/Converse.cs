using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary
{
	public class Converse<T>
		: nilnul.obj.Box1<BinaryI<T>>
		,
		BinaryI<T>
	{
		public Converse(BinaryI<T> val) : base(val)
		{
		}

		public T op(T par, T par1)
		{
			return boxed.op(par1, par);
			//throw new NotImplementedException();
		}
	}
}
