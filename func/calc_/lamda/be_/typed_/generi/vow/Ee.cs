using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda.be_.typed_.generi.vow
{
	public class Ee_lambda<T> :
		nilnul.obj.vow.ee_.Defaultable<
			LambdaExpression,
			generi.Vow_lambda<T>
		>
	{
		public Ee_lambda(LambdaExpression val) : base(val)
		{
		}
		
	}
}
