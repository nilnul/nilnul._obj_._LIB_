using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_
{
	static public class _AllX
	{
		


		static public bool All<T>(this IEnumerable<T> str, System.Func<T, bool> predicate)
		{
			return str.All(predicate);
		}

	



	}
}
