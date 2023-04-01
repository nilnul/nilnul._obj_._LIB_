namespace nilnul.obj.stream_.slider
{
	public class Subsume_opDefault_sliderGeneral<T,  TOp>
		: Subsume<T,nilnul.obj.stream_.SliderI<T>, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public Subsume_opDefault_sliderGeneral(nilnul.obj.stream_.SliderI<T> val)
			:
			base(val, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}

}
