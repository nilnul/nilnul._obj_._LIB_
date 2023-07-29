using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr
{
	public interface VowI<T> : nilnul.obj.VowI2<nilnul.obj.ExprI_sys<T>>
	{
	}

	public abstract class VowA<T> : VowI<T>
	{
		public abstract void vow(ExprI_sys<T> obj);
		public void vow(Expr_sys<T> x)
		{
			vow((ExprI_sys<T>)x);
		}

	}
}
