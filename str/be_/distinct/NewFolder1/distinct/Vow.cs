using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct
{
	[Obsolete()]
	public class Vow1<T,  TStr>
		:
		nilnul.obj.str.be.Vow<T,TStr>
		where TStr :nilnul.obj.StrI2<T>
	{
		public Vow1(IEqualityComparer<T> eq) : base(
			new Distinct2<T,TStr>(eq)
		)
		{
		}
	}
	[Obsolete()]
	public class Vow1<T>
		: Vow1<T,nilnul.obj.StrI2<T>>
	{
		public Vow1(IEqualityComparer<T> eq) : base(eq)
		{
		}
	}

	


}
