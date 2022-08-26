using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq_.homo_
{

	public class EqDefault<TSrc, TTarget, TTargetEq>
		:
		Homomorph<TSrc, TTarget>
		where TTargetEq : IEqualityComparer<TTarget>, new()
	{
		public EqDefault(System.Func<TSrc, TTarget> map) : base(map, nilnul.obj_.Singleton<TTargetEq>.Instance)
		{

		}


	}

	public class EqDefault<T, TEq> : EqDefault<T, T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefault(Func<T, T> map) : base(map)
		{
		}
	}
}
