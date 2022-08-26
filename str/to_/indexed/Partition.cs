using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.to_.indexed
{
	public class Partition<T>
		:nilnul.obj.Box1< IEqualityComparer<T> >
	{
		public Partition(IEqualityComparer<T> val) : base(val)
		{
		}

		[Obsolete()]
		 public List<List<(T,int) >> Partite(
			IEnumerable<(T,int) > indexeds
		) {
			var r = new List<List<(T, int)>>();

			foreach (var item in indexeds)
			{
				var cover=r.FirstOrDefault(
					a=> a.Any( b=> boxed.Equals(item) )
				);
				if (cover is null)
				{
					cover = new List<(T, int)>();
					cover.Add(item);
					r.Add(
						cover
					);
				}

			}
			return r;

		}
		 public IEnumerable<IGrouping<T, (T,int) >> Group(
			IEnumerable<(T,int) > indexeds
		) {
			return indexeds.GroupBy( t=>t.Item1, this.boxed );
		}
		 public IEnumerable<IGrouping<T, int>> GroupAsIndexes(
			IEnumerable<(T,int) > indexeds
		) {
			return indexeds.GroupBy( t=>t.Item1, a=>a.Item2, this.boxed );
		}
		 public IEnumerable<IGrouping<T, int>> GroupAsIndexes(
			IEnumerable<T > indexeds
		) {
			return GroupAsIndexes( indexeds.Select((e,i) => (e,i) ) );
		}



	}
}
