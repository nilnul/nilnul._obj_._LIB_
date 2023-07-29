namespace nilnul.obj.stream.cumulus_.cumulator8unison_
{
	public class Op0ini8unison<T, TStream,TOp>
		:
		stream.cumulus_.Cumulator8unison
		<T,
			TStream
			,
			obj.of_.binary.cumulator_.opDefault_.ElDefault<T,TOp>
		>
		
		where TStream : nilnul.obj.StreamI2<T>
		//where TFold: nilnul.obj.of_.binary.CumulatorI<T>
		where TOp: nilnul.obj.of_.BinaryI<T>,new()
		where T: new()

	{
		public Op0ini8unison(TStream val)
			:
			base(
				val
			)
		{
		}
	}
	public class Op0ini8unison<T, TOp>
		:
		stream.cumulus_.cumulator8unison_.Op0ini8unison
		<T,
			nilnul.obj.StreamI2<T>
			,
			TOp
		>
		
		//where TFold: nilnul.obj.of_.binary.CumulatorI<T>
		where TOp: nilnul.obj.of_.BinaryI<T>,new()
		where T: new()

	{
		public Op0ini8unison(nilnul.obj.StreamI2<T> val)
			:
			base(
				val
			)
		{
		}
	}


}
