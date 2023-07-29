using System;

namespace nilnul.obj.stream_.slider
{
	[Obsolete(nameof(Cumulus1<T>))]

	public class Cumulated_cumulatorDefault<T, TStream,TFold>
		:
		Cumulus<T, TStream,TFold>
		
		where TStream : nilnul.obj.stream_.SliderI<T>
		where TFold: nilnul.obj.op_.binary.AccumulatorI<T>,new()
	{
		
		

		public Cumulated_cumulatorDefault(TStream val) : base(val, nilnul.obj_.Singleton<TFold>.Instance )
		{
		}
		

	}

}
