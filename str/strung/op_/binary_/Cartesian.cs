using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.op_.binary_
{

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
