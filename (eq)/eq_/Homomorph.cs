using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq_
{
	public class Homomorph<TSrc, TTarget> :
		nilnul.obj.Box<IEqualityComparer<TTarget>>,
		IEqualityComparer<TSrc>
	{
		private System.Func<TSrc, TTarget> _map;

		public Func<TSrc, TTarget> map
		{
			get { return _map; }
			set { _map = value; }
		}

		public Homomorph(System.Func<TSrc, TTarget> map, IEqualityComparer<TTarget> eq) : base(eq)
		{
			_map = map;
		}

		public Homomorph(System.Func<TSrc, TTarget> map) : this(map, EqualityComparer<TTarget>.Default)
		{
			
		}
		
		public bool Equals(TSrc x, TSrc y)
		{
			return boxed.Equals(_map(x), _map(y));

			//	throw new NotImplementedException();
		}
		public bool eq(TSrc x, TTarget y) {
			return boxed.Equals(_map(x), y);
		}

		public bool eq( TTarget x, TSrc y) {
			return eq(y,x);
		}


		public int GetHashCode(TSrc obj)
		{
			return boxed.GetHashCode(_map(obj));
		}
	}

	public class Homo<T> : Homomorph<T, T>
	{
		public Homo(Func<T, T> map, IEqualityComparer<T> eq) : base(map, eq)
		{
		}
	}


	[Obsolete(nameof(homo_.EqDefault<TSrc,TTarget,TTargetEq>))]
	public class Homomorph<TSrc, TTarget, TTargetEq> : Homomorph<TSrc, TTarget>
		where TTargetEq : IEqualityComparer<TTarget>, new()
	{
		public Homomorph(System.Func<TSrc, TTarget> map) : base(map, nilnul.obj_.Singleton<TTargetEq>.Instance)
		{

		}




	}
}
