using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.slider_
{
	public class Skip<T>:SliderI<T>
	{
		private ulong _steps;

		public ulong steps
		{
			get { return _steps; }
			//set { _steps = value; }
		}
		private SliderI<T> _slider;

		public SliderI<T> slider
		{
			get { return _slider; }
			//set { _slider = value; }
		}

		public Skip(SliderI<T> slider, ulong steps=1)
		{
			_slider = slider;
			while (steps>0)
			{
				_slider.moveNext();
				_steps--;
			}
		}

		public T current =>_slider.current;

		public void moveNext()
		{
			_slider.moveNext();
			//throw new NotImplementedException();
		}
	}
}
