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
	public class Assign<T,TVar>
		where TVar:VarI5<T>
	{
		private TVar _var;

		public TVar var
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

		public Assign(TVar var, T val)
		{
			_var = var;
			_val = val;
		}

	}
}
