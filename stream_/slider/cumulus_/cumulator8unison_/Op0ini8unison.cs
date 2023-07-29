namespace nilnul.obj.stream_.slider.cumulus_.cumulator8unison_
{
	public class Op0ini8unison<T, TOp>
		:
		stream_.slider.cumulus_.Cumulator8unison<
			T
			,
			obj.of_.binary.cumulator_.opDefault_.ElDefault<T,TOp>
		>
		
		//where TFold: nilnul.obj.of_.binary.CumulatorI<T>
		where TOp: nilnul.obj.of_.BinaryI<T>,new()
		where T: new()

	{
		
		

		public Op0ini8unison(obj.stream_.SliderI<T> val)
			:
			base(
				val
			)
		{
		}
		

	}

}
