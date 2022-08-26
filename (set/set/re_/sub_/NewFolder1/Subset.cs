using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_
{
	[Obsolete(nameof(sub_.ElEqDefault<T,TEq>) )]
	public class Subset<T, TEq>
		:
		SubsetBetweenEnumerables<T>
		,
		nilnul.obj.ReI<IEnumerable<T>>
		where TEq : IEqualityComparer<T>, new()
	{
		public Subset() : base(nilnul._obj.Singleton<TEq>.Instance)
		{
		}


		static public Subset<T,TEq> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Subset<T,TEq>>.Instance;
			}
		}

	}

}

