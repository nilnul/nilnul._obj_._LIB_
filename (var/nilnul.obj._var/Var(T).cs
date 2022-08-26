using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._var
{
	public class Var<T> : 
		Var_dynamicTyped
		,
		
		VarI_dynamicTyped
	{

		public Var():base(typeof(T))
		{

		}
		//public Type type
		//{
		//	get
		//	{
		//		return typeof(T);
		//		throw new NotImplementedException();
		//	}
		//}
	}
}
