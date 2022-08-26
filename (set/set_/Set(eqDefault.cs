using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace nilnul.obj.set_
{


	public class EqDefaulted<T,TEq> : HashSet<T>
		where TEq:IEqualityComparer<T>, new()
	{

		public EqDefaulted():base(nilnul.obj_.Singleton<TEq>.Instance  )
		{
			
		}



		public EqDefaulted(params T[] vars):base(
			vars, nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		public EqDefaulted(IEnumerable<T> elements):base(
			elements, nilnul.obj_.Singleton<TEq>.Instance
			)
		{

		}

	


		

		
	}
}
