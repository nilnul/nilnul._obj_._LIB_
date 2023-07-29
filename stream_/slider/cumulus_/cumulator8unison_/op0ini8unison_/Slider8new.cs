namespace nilnul.obj.stream_.slider.cumulus_.cumulator8unison_.op9ini8unison_
{
	public class Slider8new<T, TOp,TSlider>
		:
		stream_.slider.cumulus_.cumulator8unison_.Op0ini8unison<
			T
			,
			TOp
		>
		
		where TOp: nilnul.obj.of_.BinaryI<T>,new()
		where T: new()
		where TSlider: nilnul.obj.stream_.SliderI<T>,new()
	{

		public Slider8new()
			:
			base(
				new TSlider()
			)
		{
		}
		

	}

}
