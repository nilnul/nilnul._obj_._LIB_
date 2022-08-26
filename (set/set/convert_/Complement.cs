using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.convert_
{
	public class Complement<T> : nilnul.obj.set.ConvertI<T>
	{
		public SetI<T> eval(SetI<T> arg)
		{
			return new _complement.Ret<T>(arg);

			//throw new NotImplementedException();
		}


		static public readonly Complement<T> Singleton = SingletonByDefault<Complement<T>>.Instance;

	}
}
