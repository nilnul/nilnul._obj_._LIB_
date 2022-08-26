using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.cumulate_
{

	public class CumulatorDefault<T, TCumulator>
		: Cumulate<T>

		where TCumulator : nilnul.obj.op_.binary.CumulatorI<T>, new()
	{
		public CumulatorDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.Singleton
			//.ByLazy
			<TCumulator>.Instance
		)
		{
		}

		static public CumulatorDefault<T, TCumulator> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CumulatorDefault<T, TCumulator>>.Instance;
			}
		}

	}
	




}
