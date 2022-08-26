using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary.recur
{
	

	/// <summary>
	///  stream generation is deferred, such that the <see cref="nameof(Recur{T, TOp})"/> can be parameterized on other par such as <typeparam name="T">initial</typeparam> can be parameterized as in Julia Set.
	/// </summary>
	/// <typeparam name="TRecur"></typeparam>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"></typeparam>
	public class Slider1< T, TOp, TRecur>
		:
		nilnul.obj.Box1<TRecur>
		,
		nilnul.obj.stream_.SliderI<T>

		where TOp: obj.op_.UnaryI<T>
		where TRecur: obj.op_.unary.RecurI<T,TOp>

	{
		public Slider1(TRecur val) : base(val)
		{
			_current = val.initial;
		}

		/// <summary>
		/// doesnot change the <see cref="Recur{T, TOp}"/>'s initial, as that might be singleton and usable by other slider.
		/// </summary>
		private T _current;
		public T current => _current;

		public T next()
		{

			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}

		public void moveNext()
		{

			_current = this.boxed.op.op(_current);
			//throw new NotImplementedException();
		}
	}

	
}
