using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.sortie.op_.of_._str
{
	public class Check<T>
	:
		nilnul.obj.Box1< IEqualityComparer<T> >
		,
	nilnul.obj._parse.CheckI<
		IEnumerable<T>
	>
	{
		private nilnul.obj.str.op_.to_.indexed.Partition<T> _partitioner;
		public Check(IEqualityComparer<T> val) : base(val)
		{
			_partitioner = new str.op_.to_.indexed.Partition<T>(val );

		}
		public Check():this( EqualityComparer<T>.Default)
		{

		}

		public string check(IEnumerable<T> obj)
		{
			var eq = new nilnul.obj.Eq_ofFunc<(T, int)>(
				(c,c1)=> this.boxed.Equals(c.Item1,c1.Item1 )
				,
				(x) => this.boxed.GetHashCode(x.Item1)
			);

			var partitions=_partitioner.GroupAsIndexes(obj).Where(g=> g.Skip(1).Any() );

			return string.Join(
				$";{Environment.NewLine}"

				,
				partitions.Select( p=>$"{ p.Key.ToString()} is repeated at: { string.Join(",",p)}" )
			);
		}


		static public Check<T> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Check<T>>.Instance;
			}
		}
		static public Check<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Check<T>>.Instance;
			}
		}



	}
}
