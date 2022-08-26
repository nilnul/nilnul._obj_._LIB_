using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict
{
	[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]

	public class Eq<TKey, TVal, TKeyEq,TValEq> :
		Eq<TKey,TVal,TKeyEq>
		where TKeyEq : IEqualityComparer<TKey>, new()
		where TValEq:IEqualityComparer<TVal>,new()
	{
		

		public Eq():base(nilnul._obj.Singleton<TValEq>.Instance)
		{
		}


		static public Eq<TKey, TVal, TKeyEq, TValEq> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq<TKey, TVal, TKeyEq, TValEq>>.Instance;
			}
		}

	}
}
