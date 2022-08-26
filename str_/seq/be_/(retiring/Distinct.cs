using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.enumerable.be_
{
	[Obsolete(nameof(nilnul.obj.str.be_._DistinctX))]
	static public class _DistinctX
	{

		static public bool IsDistinct<T, TEq>(this nilnul.obj.StrI<T> str, TEq eq)
			where TEq:IEqualityComparer<T>

		{
			if (str is nilnul.obj.str_.SansI)
			{
				return true;
			}
			var seeded = (str as nilnul.obj.str_.StartedI<T>);

			return seeded.tail.IsDistinct(eq) && !nilnul.obj.str.be_.ContainX.Contain(seeded.tail,seeded.head, eq);

		}


		static public bool IsDistinct_eqDefault<T, TEq>(this nilnul.obj.StrI<T> str)
			where TEq:IEqualityComparer<T>,new()

		{
			return IsDistinct(str, SingletonByDefault<TEq>.Instance);

		}



		static public bool IsDistinct<T,TEq>
		
			(this IEnumerable<T> vars, TEq eq)
			where TEq :IEqualityComparer<T>


		{
			if (vars.Count()==0)
			{
				return true;
			}
			else
			{
				var skipped = vars.Skip(1).ToArray();
				return IsDistinct(skipped,eq) && nilnul.obj.str.be_.NotContainX.NotContain<T,TEq> (skipped,vars.First(),eq);
			}


		}

		static public bool IsDistinct<T,TEq>
		
			(this List<T> vars, TEq eq)
			where TEq :IEqualityComparer<T>


		{
			if (vars.Count()==0)
			{
				return true;
			}
			else
			{
				var skipped = vars.Skip(1).ToArray();
				return IsDistinct(skipped,eq) &&
					nilnul.obj.str.be_.NotContainX.NotContain<T, TEq>(skipped,vars.First(),eq);
			}


		}


		static public bool IsDistinct_eqDefault<T,TEq>
		
			(this IEnumerable<T> vars)
			where TEq :IEqualityComparer<T>,new()


		{
			return _DistinctX.IsDistinct<T, TEq>(vars, SingletonByDefault<TEq>.Instance);


		}

		static public bool IsDistinct<T, TEq>(params  T[] str)
				where TEq :IEqualityComparer<T>,new()
		
		{
			return _DistinctX.IsDistinct_eqDefault<T,TEq>(str as IEnumerable<T>);
		}


		static public bool IsDistinct_eqDefault<T,TEq>
		
			(this List<T> vars)
			where TEq :IEqualityComparer<T>,new()


		{
			return _DistinctX.IsDistinct<T, TEq>(vars, SingletonByDefault<TEq>.Instance);


		}



		static public void AssertDistinct<T,TEq>(this IEnumerable<T> vars,TEq eq)
			where TEq :IEqualityComparer<T>

		{

			nilnul.Assert1.True(IsDistinct(vars,eq));

		}

		static public void AssertDistinct_eqDefault<T,TEq>(this IEnumerable<T> vars)
			where TEq :IEqualityComparer<T>,new()

		{

			AssertDistinct(vars, SingletonByDefault<TEq>.Instance);

		}


	}
}
