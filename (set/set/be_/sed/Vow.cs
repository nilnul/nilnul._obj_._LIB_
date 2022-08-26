using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.be_.sed
{
	public class Vow<T>:nilnul.obj.be.Vow_beDefault<SetI1<T>, Sed<T>>
	{

		static public readonly Vow<T> Singleton = nilnul.obj.SingletonByDefault<Vow<T>>.Instance;

	}
}
