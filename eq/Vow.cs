using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq
{
	public class Vow<T, TEq>
		
		where TEq : IEqualityComparer<T>, new()
	{
		public void vow(T obj, T obj1)
		{
			nilnul.obj.vow_.True.Singleton.vow(
				SingletonByDefault<TEq>.Instance.Equals(obj,obj1)
				);
			//throw new NotImplementedException();
		}


		static public readonly Vow<T,TEq> Singleton = nilnul.obj.SingletonByDefault<Vow<T,TEq>>.Instance;

	}
}
