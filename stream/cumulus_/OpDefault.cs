namespace nilnul.obj.stream.cumulus_
{
	public class OpDefault<T, TStream,TOp,TFold>
		:
		Cumulus<T, TStream,TFold>
		
		where TStream : nilnul.obj.StreamI2<T>
		where TFold: nilnul.obj.of_.binary.CumulatorI<T>
		where TOp: nilnul.obj.of_.BinaryI<T>

	{
		
		

		public OpDefault(TStream val)
			:
			base(val,

				 nilnul._obj.typ_._UnisonX<
					 obj.of_.binary.cumulator_.OpDefault<T,TOp>.
				>.Unison
			)
		{
		}
		

	}

}
