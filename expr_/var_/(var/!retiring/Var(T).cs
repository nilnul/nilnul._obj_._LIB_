using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete(nameof(expr_.Var))]
	public class Var4<T> : 
		Var_dynamicTyped1
		,
		
		VarI_dynamicTyped1
	{

		public Var4():base(typeof(T))
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
