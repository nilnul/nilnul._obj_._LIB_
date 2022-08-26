using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_
{
	public class Max<T>
		:
		nilnul.obj.Box1<IComparer<T>>
		,
		nilnul.obj.op_.binary_.CommutableI<T>
	{
		public Max(IComparer<T> val) : base(val)
		{
		}

		public T op(T par, T par1)
		{
			return boxed.Compare(par,par1)>=0? par: par1;
			//throw new NotImplementedException();
		}
	}


}
