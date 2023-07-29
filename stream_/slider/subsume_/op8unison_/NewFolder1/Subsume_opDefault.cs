using System;

namespace nilnul.obj.stream_.slider
{
	[Obsolete()]

	public class Subsume_opDefault<T, TSlider, TOp>
		: Subsume<T, TSlider, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
		where TSlider : nilnul.obj.stream_.SliderI<T>
	{
		public Subsume_opDefault(TSlider val)
			:
			base(val, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}

}
