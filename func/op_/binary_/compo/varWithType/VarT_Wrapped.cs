using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.duo.op.compo.varWithType
{
	public partial class VarT_Wrapped<T>
		:varWithType.VarWithTypeI
	{
		private obj.VarI3<T> _var;

		public obj.VarI3<T> var
		{
			get { return _var; }
			set { _var = value; }
		}

		public Type type
		{
			get
			{
				return typeof(T);
				throw new NotImplementedException();
			}
		}

		public VarT_Wrapped(obj.VarI3<T> var)
		{
			_var = var;

		}



	}
}
