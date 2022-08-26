using nilnul.obj._str.recur_.headed0Sans_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._str.recur_
{
	public class Seq<T> :
		nilnul.obj.Box<IEnumerable<T>>
		,
		RecurI<T>
	{
		public Seq(IEnumerable<T> val) : base(val)
		{
		}

		public Headed0SansI<T> toHeaded0Sans() {
			if (boxed.Any())
			{
				return new Headed<T, Seq<T>>(
					boxed.First(),
					new Seq<T>(nilnul.obj.seq_.headed._TailX._Tail(boxed))
				);
			}
			return  Sans<T>.Singleton;
		}
	}
}
