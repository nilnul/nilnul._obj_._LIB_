using nilnul.obj.op_;
using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider.cumulus_
{
	[Obsolete(nameof(cumulator8unison_))]
	public class AccumulatorDefault<T, TAccumulator>
		:
		slider.Cumulus<T>
		where TAccumulator : nilnul.obj.op_.binary.AccumulatorI<T>, new()
	{
		public AccumulatorDefault(SliderI<T> val) : base(val, nilnul.obj_.Singleton<TAccumulator>.Instance)
		{
		}

		
	}
}
