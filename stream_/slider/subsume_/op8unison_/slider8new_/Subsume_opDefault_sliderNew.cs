﻿//using nilnul.obj.stream_.slider.subsume_.opDefault_;
using System;

namespace nilnul.obj.stream_.slider
{
	[Obsolete(
		//nameof(SliderNew)
	)]
	public class Subsume_opDefault_sliderNew<T, TSlider, TOp>
		: Subsume_opDefault<T, TSlider, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
		where TSlider : nilnul.obj.stream_.SliderI<T>,new()
	{
		public Subsume_opDefault_sliderNew()
			:
			base(new TSlider())
		{
		}
	}

}
