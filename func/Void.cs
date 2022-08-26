using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	/// <summary>
	/// for Var(void) which embodies no variable in a nullary func.
	/// </summary>
	public  class Void
	{
		static public Void Singleton = SingletonByDefault<Void>.Instance;
	}
}
