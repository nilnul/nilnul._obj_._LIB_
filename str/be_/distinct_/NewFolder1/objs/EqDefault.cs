using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_.distinct_
{
	[Obsolete()]
	public class EqDefault<T,  TEq>
		: 
		Distinct1<T >
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance)
		{
		}
	}




}
