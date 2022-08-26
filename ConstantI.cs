using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// this is a 0-ary operator, which takes 0-tuple as input
	/// </summary>
	public interface ConstantI
	{

	}
	public interface ConstantI<T> : ConstantI {
		T result { get; }
	}

	public class Constant<T>:ConstantI<T>
	{
		private T _result;

		public T result
		{
			get { return _result; }
			set { _result = value; }
		}

		public Constant(T result)
		{
			_result = result;
		}
	}
}
