using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_
{
	/// <summary>
	/// move one at a time. But you can peek ahead (not move multiple items as we still move one at a time) for extra items; we call this peek.
	/// </summary>
	public interface ISlider:stream_.scroll_.ISlider{

	}
	public interface SliderI_blank:ISlider {

	}
	/// <summary>
	/// This is more like <seealso cref="nameof(IEnumerator{T})"/> that <see cref="nameof(IEnumerable{T})"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface SliderI<T> :
		SliderI_blank,

		nilnul.obj.StreamI2<T>,
		nilnul.obj.stream_._slider.CursorI<T>
		, nilnul.obj.SliderI<T>
	{
		
	}

	public abstract class SliderA<T> :

		SliderI<T>
	{
		public abstract T current { get; }

		public abstract void moveNext();
		public T next() {
			var old = current;
			moveNext();
			return old;

		}
	}
}
