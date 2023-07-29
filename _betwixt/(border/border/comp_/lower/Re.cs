using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border_.lower.comp
{
	public class Re1<T, TBorder>
		: nilnul.obj.comp.Re<TBorder>
		where TBorder : nilnul.obj.BorderI<T>
	{
		public Re1(IComparer<TBorder> ord) : base(ord)
		{
		}
		public Re1(IComparer<T> ord) : base(new border.comp_.Lower<T,TBorder>(ord))
		{
		}


	}
}
