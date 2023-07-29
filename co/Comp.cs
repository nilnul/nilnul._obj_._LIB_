using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	public class Comp<T>
		:
		nilnul.obj.Box1<IComparer<T>>
		,
		IComparer<(T, T)>
	{
		public Comp(IComparer<T> val) : base(val)
		{
		}

		public int Compare((T, T) x, (T, T) y)
		{
			var compared4start=  boxed.Compare(x.Item1,y.Item1);
			if (
				compared4start ==0
			)
			{
				return boxed.Compare(x.Item2, y.Item2);
			}
			return compared4start;
			//throw new NotImplementedException();
		}
	}
}
