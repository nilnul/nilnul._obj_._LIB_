using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.comp_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TElement"></typeparam>
	public class LongerSmaller<TElement>
		: CompI<TElement>
	{
		private IComparer<TElement> _elementComparer;

		public IComparer<TElement> elementComparer
		{
			get { return _elementComparer; }
			set { _elementComparer = value; }
		}

		public LongerSmaller(IComparer<TElement> elementComparer)
		{
			_elementComparer = elementComparer;

		}

		/// <summary>
		/// implement by recursion
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
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
				return -1;
			}
			
			 if (y.Any())
			{
				return 1;

			}
			return 0;



		 

			//throw new NotImplementedException();
		}

	
	}
}
