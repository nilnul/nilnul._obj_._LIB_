namespace nilnul.obj.stream_.slider.subsume_
{
	public class Op8unison<T, TSlider, TOp>
		: Subsume<T, TSlider>
		where TSlider : nilnul.obj.stream_.SliderI<T>
		where TOp : nilnul.obj.of_.BinaryI<T>, new()
	{
		public Op8unison(TSlider val)
			:
			base(
				val
				,

				 nilnul._obj.typ_._UnisonX<TOp>.Unison

			)
		{
		}
	}

	public class Op8unison<T, TOp>
		:
		Op8unison<
			T
			,
			nilnul.obj.stream_.SliderI<T>
			,
			TOp
		>
		where TOp : nilnul.obj.of_.BinaryI<T>, new()
	{
		public Op8unison(nilnul.obj.stream_.SliderI<T> val)
			:
			base(val)
		{
		}
	}

}
