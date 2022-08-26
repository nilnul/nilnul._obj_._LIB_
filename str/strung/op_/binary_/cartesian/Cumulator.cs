using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.op_.binary_.cartesian
{

	public class Cumulator<T>
		:
		//nilnul.obj.op_.binary._cumulator_.InitialA<IEnumerable<IEnumerable< T >>>
		//,
		nilnul.obj.op_.binary.cumulator_.OpDefault<
			IEnumerable<IEnumerable< T >>
			,
			Cartesian<T>
		>
		,
		nilnul.obj.op_.binary_.associative.cumulator_.IMonoid


	{
		public Cumulator() : base(
			new[] { Enumerable.Empty<T>() }
			//,
			//Cartesian<T>.Singleton
		)
		{
		}


		static public Cumulator<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Cumulator<T>>.Instance;
			}
		}

	}
}
