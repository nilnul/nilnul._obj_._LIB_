using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.combine_._or
{
	/// <summary>
	/// applies more after
	/// </summary>
	public class Ret<T> :
		nilnul.obj._call_.ArgArg1A<nilnul.obj.BeI<T>>
		,
		nilnul.obj.BeI<T>
	{


		public Ret(BeI<T> arg, BeI<T> arg1) : base(arg,arg1)
		{
		}

		public bool be(T obj)
		{
			return arg.be(obj) || arg1.be(obj);

			//throw new NotImplementedException();
		}
	}

	
}
