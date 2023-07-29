using System;

namespace nilnul.obj.stream_.slider
{
	[Obsolete()]
	public class Subsume_sliderGeneral<T,  TOp>
		:
		Subsume<T,nilnul.obj.stream_.SliderI<T>, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		public Subsume_sliderGeneral(nilnul.obj.stream_.SliderI<T>  val, TOp op)
			:
			base(val, op)
		{
		}
	}

}
