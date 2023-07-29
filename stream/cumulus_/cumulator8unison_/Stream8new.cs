namespace nilnul.obj.stream.cumulus_.cumulator8unison_
{
	public class Stream8new<T, TStream,TFold>
		:
		Cumulator8unison<T, TStream,TFold>
		
		where TFold: nilnul.obj.of_.binary.CumulatorI<T>,new()
		where TStream : nilnul.obj.StreamI2<T>,new()
	{
		
		

		public Stream8new()
			:
			base( new TStream()
			)
		{
		}
		

	}

}
