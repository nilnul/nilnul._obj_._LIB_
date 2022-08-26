using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// size not change. for changed size, use List
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// alias:
	///		window
	/// </remarks>
	public class Buffer_ovArray<T>
		:nilnul.obj.Box_pub<T[]>
		,
		str_.IBuffer
		
	{

		public Buffer_ovArray(T[] array):base(array)
		{
			nilnul.objs.vow_.Started<T>.Singleton.vow(array);
			_size = array.Length;
			_currentIndex = 0;
		}
		public Buffer_ovArray(int size):this(new T[size])
		{

		}
		public Buffer_ovArray(IEnumerable<T> elements):this( elements.ToArray())
		{
		}

		private int _size;

		public T this[int index] {
			get {
				return boxed[(_currentIndex + index) % _size];
			}
		}
		private int _currentIndex;

		public int currentIndex
		{
			get { return _currentIndex; }
			set { _currentIndex = value; }
		}


		public void pump(T newObj) {
			_currentIndex++;
			_currentIndex %= _size;

			boxed[_currentIndex]=newObj;
		}
	}
}
