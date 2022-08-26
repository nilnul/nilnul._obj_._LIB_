#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_.nulyOv_
{
	public class NulMaxOvStruct<T>
		:
		nilnul.obj.Box1<IComparer<T>>
		,
		nilnul.obj.op_.binary_.CommutableI<T?>
		,
		max_.NulyOvStructI<T>
		where T: struct
	{
		public NulMaxOvStruct(IComparer<T> val) : base(val)
		{
		}


		public T? op(T? par, T? par1)
		{
			if (par is null)
			{
				return par;
			}
			if (par1 is null)
			{
				return par1;
			}

			return boxed.Compare(par.Value,par1.Value)>=0? par.Value: par1.Value;
			//throw new NotImplementedException();
		}
	}


}
