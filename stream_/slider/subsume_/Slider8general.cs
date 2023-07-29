namespace nilnul.obj.stream_.slider.subsume_
{
	public class Slider8general<T,  TOp>
		:
		Subsume1<T,nilnul.obj.stream_.SliderI<T>, TOp>
		where TOp : nilnul.obj.of_.BinaryI<T>
	{
		public Slider8general(nilnul.obj.stream_.SliderI<T>  val, TOp op)
			:
			base(val, op)
		{
		}
	}

}
