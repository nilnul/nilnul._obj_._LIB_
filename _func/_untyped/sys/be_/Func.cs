using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func._untyped.sys.be_
{
	/// <summary>
	/// no vars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Func : _expr._untyped.sys.BeI
	{
		public bool be(Expression obj)
		{
			
			return (obj is System.Linq.Expressions.LambdaExpression );
			//throw new NotImplementedException();
		}



		static public Func Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Func>.Instance;
			}
		}


	}
}
