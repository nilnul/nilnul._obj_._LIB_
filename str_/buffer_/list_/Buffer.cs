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
	public class Buffer<T>
		:nilnul.obj.Box_pub<List<T>>
		,
		str_.IBuffer
	{

		public Buffer(int size):base(new List<T> (size))
		{

		}
		public Buffer(IEnumerable<T> elements):this( elements.Count())
		{
			elements.Each(boxed.Add);
		}


		public void pump(T newObj) {
			boxed.RemoveAt(0);
			boxed.Add(newObj);
		}
	}
}
