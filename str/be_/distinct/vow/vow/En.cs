using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct.vow
{
	[Obsolete()]
	public class Ee<T, TStr> 
		: 
		nilnul.obj.str.vow.Ee<T,TStr>

		where TStr : nilnul.obj.StrI2<T> //, nilnul.obj._str_.ToArrI<T>
	{
		public Ee( IEqualityComparer<T> eq, TStr val)
			:
			base(
				val,
				new nilnul.obj.str.be_.distinct.Vow1<T,TStr>(eq)
			)
		{
		}
	}

	[Obsolete()]
	public class Ee<T> 
		: 
		Ee<T,nilnul.obj.StrI2<T>>

	{

		public Ee( IEqualityComparer<T> eq, nilnul.obj.StrI2<T> val)
			:
			base(
				eq,val
				
			)
		{
		}
	}

	







}
