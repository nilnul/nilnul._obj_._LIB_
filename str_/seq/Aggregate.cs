using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.seq
{
	public interface AggregateI<T>
		:objs.IAggregate<T>
	{
		T aggregate(
			IEnumerable<T> seq
		);
	}

	public abstract class AggregateA<T> : AggregateI<T>
	{
		public abstract T aggregate(IEnumerable<T> seq);

		public T aggregate(params T[] seq) {
			return aggregate((IEnumerable<T>) seq );
		}
	}
}
