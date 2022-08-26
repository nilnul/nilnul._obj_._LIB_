using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.enumable
{
	[Obsolete(nameof(str_.seq.comp_.CompDefault<TElement,TComp>))]

	public class Comp<TElement,TComp>
		: CompI<TElement>
		

		where TComp:IComparer<TElement>,new()
	{
		

		public int Compare(IEnumerable<TElement> x, IEnumerable<TElement> y)
		{

			if (x.Any())
			{
				if (y.Any())
				{
					var headCompared = nilnul.obj.SingletonByDefault<TComp>.Instance.Compare(
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



		static public Comp<TElement,TComp> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Comp<TElement,TComp>>.Instance;
			}
		}

	}
}
