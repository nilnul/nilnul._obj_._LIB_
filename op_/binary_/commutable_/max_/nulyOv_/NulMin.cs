#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_.nulyOv_
{
	public class NulMin<T>
		:
		nilnul.obj.Box1<IComparer<T>>
		,
		nilnul.obj.op_.binary_.CommutableI<T>
		,
		max_.OvNulyI<T>
		//where T: notnull
		where T: class?
	{
		public NulMin(IComparer<T> val) : base(val)
		{
		}

		public T op(T par, T par1)
		{
			if (par is null)
			{
				return par1;
			}
			if (par1 is null)
			{
				return par;
			}

			return boxed.Compare(par,par1)>=0? par: par1;
			//throw new NotImplementedException();
		}
	}


}
