using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.str.combinate_
{
	/// <summary>
	/// </summary>
	static public  class _CoupleDownX
	{

		[Obsolete(nameof(CoupleDown_byMove))]
		static public IEnumerable< (T,T)> CoupleDown<T>( IEnumerable<T> pars)
		{
			var count = pars.Count();
			for (int i = 0; i < count; i++)
			{
				for (int j = i + 1; j < count; j++)
				{
					yield return (
						pars.ElementAt(i)
						,
						pars.ElementAt(j)
					);
				}
			}
		}

		static public IEnumerable< (T,T)> CoupleDown_byMove<T>( IEnumerable<T> pars)
		{
			var outerEnumerator = pars.GetEnumerator();

			var inner = pars;

			while (outerEnumerator.MoveNext())
			{
				 inner = inner.Skip(1);

				foreach (var item in inner)
				{
					yield return (outerEnumerator.Current,item);

				}



			}
		}

	}

}
