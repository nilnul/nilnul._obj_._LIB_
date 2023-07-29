namespace nilnul.obj.stream
{
	public class Cumulated_cumulatorDefault<T, TStream,TFold>
		:
		Cumulated<T, TStream,TFold>
		
		where TStream : nilnul.obj.StreamI2<T>
		where TFold: nilnul.obj.op_.binary.AccumulatorI<T>,new()
	{
		
		

		public Cumulated_cumulatorDefault(TStream val) : base(val, nilnul.obj_.Singleton<TFold>.Instance )
		{
		}
		

	}

}
