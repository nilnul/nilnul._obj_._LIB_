using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.op_.binary_
{
	static public class _CartesianX
	{
		/// <summary>
		/// using the method syntax
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <param name="a"> the element shall be regarded as 1-vec</param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public IEnumerable<(T, T1)> Seq<T, T1>(
			IEnumerable<T> a
			,
			IEnumerable<T1> b
		)
		{
			return a.SelectMany(
				x => b.Select(
					y => (x, y)
				)
			);
		}

		static public IEnumerable<(T, T1)> Seq_byQuery<T, T1>(
			IEnumerable<T> a
			,
			IEnumerable<T1> b
		)
		{
			return from x in a
				   from y in b
				   select (x, y);
		}


		static public IEnumerable<IEnumerable<T>> Sequence_byQuery<T>(
			IEnumerable<T> a
			,
			IEnumerable<T> b
		)
		{
			return from x in a
				   from y in b
				   select new[] { x, y };
		}



	}

	public class Cartesian<T> :
		nilnul.obj.op_.binary_.AssociativeI<
		IEnumerable<IEnumerable<T>>

	>
		//,
		//nilnul.obj.op_.binary_.AssociativeI<IEnumerable< IEnumerable< T>>>
	{

		public IEnumerable<IEnumerable<T>> _op_byMethod(
			IEnumerable<IEnumerable<T>> par
			,
			IEnumerable<IEnumerable<T>> par1
		)
		{
			return par.SelectMany
				(p => par1.Select(y => p.Concat(y))
			);
			;
		}
		public IEnumerable<IEnumerable<T>> op(
				IEnumerable<IEnumerable<T>> par
				,
				IEnumerable<IEnumerable<T>> par1
			)
		{
			return 	from x in par
				from y in par1
				select x.Concat(y)
			;
		}

		static public Cartesian<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cartesian<T>>.Instance;
			}
		}

	}
}
