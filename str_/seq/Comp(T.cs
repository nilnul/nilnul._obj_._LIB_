using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{
	public class Comparer<TElement>
		: CompI<TElement>
	{
		private IComparer<TElement> _elementComparer;

		public IComparer<TElement> elementComparer
		{
			get { return _elementComparer; }
			set { _elementComparer = value; }
		}

		public Comparer(IComparer<TElement> elementComparer)
		{
			_elementComparer = elementComparer;

		}

		public int Compare(IEnumerable<TElement> x, IEnumerable<TElement> y)
		{

			if (x.Any())
			{
				if (y.Any())
				{
					var headCompared = _elementComparer.Compare(
						x.First(), y.First()
					);

					if (headCompared == 0)
					{
						return Compare(x.Skip(1), y.Skip(1));
					}
					return headCompared;

 				}
				return 1;
			}
			
			 if (y.Any())
			{
				return -1;

			}
			return 0;



		 

			//throw new NotImplementedException();
		}

	
	}
}
