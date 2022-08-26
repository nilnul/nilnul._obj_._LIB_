using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._sortie_
{
	public interface StrI1<T,TStr>
		where TStr: nilnul.obj.StrI2<T>
	{
		nilnul.obj.str.be_.distinct.vow.Ee<T, TStr> str { get; }
	}

	
	public interface StrI1<T>
		:
		StrI1<T,
			 nilnul.obj.StrI2<T>
		>
	{
	}


}
