using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_
{
	/// <summary>
	/// constant
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Fixed<T>
		:
		nilnul.obj.Box<T>
		,
		nilnul.obj.StreamI2<T>
	{
		public Fixed(T val) : base(val)
		{
		}

		public T next()
		{
			return boxed;
		}
	}
}
