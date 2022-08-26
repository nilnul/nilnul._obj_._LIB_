using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict.be_.bijective
{
	public class Vow<TKey,TVal, TValEq>
		:nilnul.obj.be.Vow_beDefault<
			Dictionary<TKey,TVal>
			,Bijective<TKey,TVal,TValEq>
		>
	where TValEq:IEqualityComparer<TVal>, new()
	{
	}
}
