using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set._eq_.ofSeq_
{


	public class EqDefaulted<T,TEq> : nilnul.obj.set._eq_.OfSeq<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public EqDefaulted():base(
			nilnul.obj_.Singleton<TEq>.Instance
		)
		{ 
		}
	}


	
}
