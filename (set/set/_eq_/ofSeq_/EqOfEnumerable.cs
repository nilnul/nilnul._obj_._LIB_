using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.eq_
{

	[Obsolete(nameof(set._eq_.ofSeq_.EqDefaulted<T,TEq>))]
	public class EqOfEnumerable<T,TEq> : EqOfEnumerable<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public EqOfEnumerable():base(
			SingletonByDefault<TEq>.Instance
		)
		{ 
		}
	}


	
}
