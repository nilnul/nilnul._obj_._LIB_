namespace nilnul.obj.stream_.slider
{
	public class Buffered_sliderNew<T, TSlider> :
		Buffered<T, TSlider>
		where TSlider : nilnul.obj.stream_.SliderI<T>,new()
	{
		public Buffered_sliderNew( int count) : base(new TSlider(), count)
		{

		}

	}


}
