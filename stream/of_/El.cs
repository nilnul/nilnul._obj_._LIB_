using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream.of_
{
	/// <summary>
	/// constant
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class El<T>
		:
		nilnul.obj.Box1<T>
		,
		nilnul.obj.StreamI2<T>
	{
		public El(T val) : base(val)
		{
		}

		public T next()
		{
			return boxed;
		}
	}
}
