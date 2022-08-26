using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider.of_.str_._appendNul
{
	/// <summary>
	/// construct a stream from str by appending null 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Ret<T>:
		nilnul.obj.seq.op_.unary_._appendNul.Ret<T>,

		IEnumerator<T>,
		nilnul.obj.SliderI<T>
		where T :class
	{
		

		public Ret(IEnumerable<T> str):this(str.GetEnumerator())
		{
			
		}


		public Ret(IEnumerator<T> enumerator):base(enumerator)
		{
			
		}
		

	}
}
