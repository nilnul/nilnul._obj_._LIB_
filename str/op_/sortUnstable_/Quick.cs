using nilnul.obj.seq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.sortUnstable_
{
	public class _Quick
	{
		static public IEnumerable<T> Sort<T>(IEnumerable<T> numbers, IComparer<T> comparer) {

			if (numbers.None())
			{
				return new T[0];
			}
			var pivot = numbers.First();
			var smaller = new List<T>();
			var bigger = new List<T>();

			var middle = new List<T>() { pivot};

			foreach (var item in numbers.Skip(1))
			{
				var comparedOutcome = comparer.Compare(item, pivot);
				if (  comparedOutcome<0)
				{
					smaller.Add(item);
				}
				else if (comparedOutcome >0)
				{
					bigger.Add(item);
				}
				else
				{
					middle.Add(item);
				}

			}

			return Sort(smaller,comparer).Concat(middle).Concat(Sort(bigger,comparer));

		}



		static public IEnumerable<T> Sort<T>(IEnumerable<T> numbers)
			where T:IComparable<T>
		{
			return Sort(numbers, System.Collections.Generic.Comparer<T>.Default);
		}




	}

}



