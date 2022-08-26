using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.input.compo
{
	public class Call<T, T1>
		: CallI
		where T : CallI
		where T1 : CallI
	{
		private T _inputs;

		public T inputs
		{
			get { return _inputs; }
			set { _inputs = value; }
		}

		private T1 _inputs1;

		public T1 inputs1
		{
			get { return _inputs1; }
			set { _inputs1 = value; }
		}

		public Call(
			T x,
			T1 y
		)
		{
			_inputs = x;
			_inputs1 = y;
		}



		public HashSet<VarI1> boundVars
		{
			get {
				var r = new HashSet<VarI1>();
				r.UnionWith(_inputs.boundVars);
				r.UnionWith(_inputs1.boundVars);
				return r;

				
				throw new NotImplementedException(); 
			
			}
		}
	}
}
