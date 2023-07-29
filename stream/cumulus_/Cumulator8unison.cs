namespace nilnul.obj.stream.cumulus_
{
	public class Cumulator8unison<T, TStream,TFold>
		:
		Cumulus<T, TStream,TFold>
		
		where TStream : nilnul.obj.StreamI2<T>
		where TFold: nilnul.obj.of_.binary.CumulatorI<T>,new()
	{
		
		

		public Cumulator8unison(TStream val)
			:
			base(val,
				 nilnul._obj.typ_._UnisonX<TFold>.Unison
			)
		{
		}
		

	}
	public class Cumulator8unison<T, TFold>
		:
		Cumulus<T>
		
		where TFold: nilnul.obj.of_.binary.CumulatorI<T>,new()
	{
		
		

		public Cumulator8unison(nilnul.obj.StreamI2<T> val)
			:
			base(
				val
				,
				nilnul._obj.typ_._UnisonX<TFold>.Unison
			)
		{
		}
		

	}



}
