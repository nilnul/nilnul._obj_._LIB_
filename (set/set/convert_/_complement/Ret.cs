using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.convert_._complement
{
	public class Ret<T> :
		nilnul.obj._call_.ArgA<SetI<T>>,
		nilnul.obj.SetI<T>
	{
		public Ret(SetI<T> arg) : base(arg)
		{
		}

		public bool contains(T element)
		{
			return !arg.contains(element);

			//throw new NotImplementedException();
		}
	}
}
