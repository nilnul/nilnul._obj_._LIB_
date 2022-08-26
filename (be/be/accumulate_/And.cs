using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.be.combine_;

namespace nilnul.obj.be.accumulate_
{
	public class And<T>
		:
		nilnul.obj.be.accumulate_.FroCombine<T, nilnul.obj.be.combine_.And<T>>

	{


		static public readonly And<T> Singleton = SingletonByDefault<And<T>>.Instance;

	}
}
