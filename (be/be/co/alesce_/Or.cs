using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.co.alesce_
{
	/// <summary>
	/// </summary>
	public class Or<T> :
		nilnul.obj._call_.argArg1_.ClosedA<nilnul.obj.BeI1<T>>
		,
		nilnul.obj.BeI1<T>
	{


		public Or(BeI1<T> arg, BeI1<T> arg1) : base(arg,arg1)
		{
		}

		public bool be(T obj)
		{
			return arg.be(obj) || arg1.be(obj);

			//throw new NotImplementedException();
		}
	}

	
}
