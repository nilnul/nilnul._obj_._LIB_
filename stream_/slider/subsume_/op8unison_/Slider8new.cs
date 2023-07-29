namespace nilnul.obj.stream_.slider.subsume_.op8unison_
{
	public class Slider8new<T, TSlider, TOp>
		: Op8unison<T, TSlider, TOp>
		where TOp : nilnul.obj.of_.BinaryI<T>, new()
		where TSlider : nilnul.obj.stream_.SliderI<T>,new()
	{
		public Slider8new()
			:
			base(new TSlider())
		{
		}
	}

}
