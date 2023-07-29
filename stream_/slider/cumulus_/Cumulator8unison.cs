using nilnul.obj.op_;
using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider.cumulus_
{
	public class Cumulator8unison<T, TAccumulator>
		:
		slider.Cumulus1<T>
		where TAccumulator : nilnul.obj.of_.binary.CumulatorI<T>, new()
	{
		public Cumulator8unison(SliderI<T> val)
			:
			base(
				val
				,
				nilnul._obj.typ_._UnisonX<TAccumulator>.Unison
			)
		{
		}

		
	}
}
