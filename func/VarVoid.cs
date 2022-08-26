using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public partial class VarVoid
		:nilnul.obj.VarI3<Void>
	{

		static public VarVoid Singleton = SingletonByDefault<VarVoid>.Instance;

		public override string ToString()
		{
			return "";
		}
		
	}
}
