using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re
{
	/// <summary>
	/// switch the two args
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Converse<T> 
		:
		nilnul.obj._form.Arg<ReI<T>>
		,
		nilnul.obj.ReI<T>
	{
		
		public Converse(ReI<T> re):base(re)
		{
		}
		public bool re(T a, T b)
		{
			return arg.re(b,a);
			//throw new NotImplementedException();
		}
	}
}
