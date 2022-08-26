using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.eq_
{
	public class EqDefaulted<T, TEq>
		
		:
		nilnul.obj.set.Eq<T>
		//IEqualityComparer<nilnul.obj.Set<T, TEq>>

		 
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefaulted() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public EqDefaulted<T, TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EqDefaulted<T, TEq>>.Instance;
			}
		}



	}
}
