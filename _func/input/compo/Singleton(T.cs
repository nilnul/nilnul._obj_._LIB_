using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.input.compo
{
	public class Singleton<T>
		:CallI
	{
		private obj.VarI3<T> _var;

		public obj.VarI3<T> var
		{
			get { return _var; }
			set { _var = value; }
		}
		

		public HashSet<VarI1> boundVars
		{
			get {

				return new HashSet<VarI1>(new[]{_var} );
				throw new NotImplementedException();
			}
		}
	}
}
