using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.var
{
	/// <summary>
	/// 
	/// </summary>
	public class Assignment<T>
	{
		private VarI5<T> _var;

		public VarI5<T> var
		{
			get { return _var; }
			set { _var = value; }
		}


		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Assignment(VarI5<T> var, T val)
		{
			_var = var;
			_val = val;
		}

	}
}
