using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op._call
{
	/// <summary>
	/// </summary>
	public abstract class ArgsA<T>
	
	{
		
		public ArgsA(T arg){
			this._arg = arg;
		}

		private T _arg;
		public T arg
		{
			get
			{
				return _arg;
			}
			set
			{
				_arg=value;
			}
		}



	}
}
