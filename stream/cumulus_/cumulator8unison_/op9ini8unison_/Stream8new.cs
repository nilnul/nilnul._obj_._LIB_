namespace nilnul.obj.stream.cumulus_.cumulator8unison_.op0ini8unison_
{
	public class Stream8new<T, TStream,TOp>
		:
		stream.cumulus_.cumulator8unison_.Op0ini8unison
		<T,
			TStream
			,
			TOp
		>
		
		where TStream : nilnul.obj.StreamI2<T>,new()
		where TOp: nilnul.obj.of_.BinaryI<T>,new()
		where T: new()

	{
		public Stream8new( )
			:
			base(
				new TStream()
			)
		{
		}
	}

	



}
