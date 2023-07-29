namespace nilnul.obj.stream_.slider.cumulus_.cumulator8unison_
{
	public class SliderNew<T, TCumulator,TSlider>
		:
		stream_.slider.cumulus_.Cumulator8unison<
			T
			,
			TCumulator
		>
		
		where TCumulator: nilnul.obj.of_.binary.CumulatorI<T>,new()
		where TSlider: stream_.SliderI<T>, new()

	{

		public SliderNew()
			:
			base(
				new TSlider()
			)
		{
		}
		

	}

}
