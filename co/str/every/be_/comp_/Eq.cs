using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.str.every.be_.comp_
{
	public class Eq<TEl>
		:
		nilnul.obj.Box_ofIn<IComparer<TEl>>
		,
		CompI<TEl>
	{
		public Eq(in IComparer<TEl> val) : base(val)
		{
		}

		public Eq(IComparer<TEl> x) : base(x)
		{
		}

		public bool be(IEnumerable<(TEl, TEl)> obj)
		{
			return obj.All(c => boxed.Compare(c.Item1,c.Item2)==0 );

		}
	}
}
