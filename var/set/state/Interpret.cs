using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign
{
	/// <summary>
	/// for the assignments of vars, return a value. This can be applied to expr or func.
	/// </summary>
	public class Interpret<TVar, TRet>
	{
		private nilnul.obj.var.set.State<TVar> _assign;

		public nilnul.obj.var.set.State<TVar> assign
		{
			get { return _assign; }
			set { _assign = value; }
		}

		private TRet _ret;

		public TRet ret
		{
			get { return _ret; }
			set { _ret = value; }
		}

		public Interpret( nilnul.obj.var.set.State<TVar> assigns, TRet ret )
		{
			_assign = assign;
			_ret = ret;
		}


	}
}
