using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.withType
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Var<T> : VarI
	{
		private obj.VarI3<T> _var;
		public Var(obj.VarI3<T> var  )
		{
			_var = var;
		}

		public Type type
		{
			get
			{
				return typeof(T);
				throw new NotImplementedException();
			}
		}
	}
}
