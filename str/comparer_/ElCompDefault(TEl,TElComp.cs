using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.comparer_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TElement"></typeparam>
	/// <typeparam name="TComp"></typeparam>
	public class ElCompDefault<TElement,TComp>
		: ComparerI<TElement>
		, 
		ComparerOfEnumerableI<TElement>

		where TComp:IComparer<TElement>,new()
	{
		

		public int Compare(IEnumerable<TElement> x, IEnumerable<TElement> y)
		{

			if (x.Any())
			{
				if (y.Any())
				{
					var headCompared = nilnul.obj_.Singleton<TComp>.Instance.Compare(
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

		public int Compare(StrI<TElement> x, StrI<TElement> y)
		{

			if (x is str_.SansI)
			{
				if (y is str_.SansI)
				{
					return 0;
				}
				return -1;
			}
			 if (y is str_.SansI)
			{
				return 1;

			}

			var xAsStarted = x as str_.StartedI<TElement>;
			var yAsStarted = y as str_.StartedI<TElement>;




			var headCompared = nilnul.obj.SingletonByDefault<TComp>.Instance.Compare(
				xAsStarted.head, yAsStarted.head	
			);

			if (headCompared ==0)
			{
				return Compare( xAsStarted.tail,yAsStarted.tail);
			}
			return headCompared;
			//throw new NotImplementedException();
		}


		static public ElCompDefault<TElement,TComp> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<ElCompDefault<TElement,TComp>>.Instance;
			}
		}

	}
}
