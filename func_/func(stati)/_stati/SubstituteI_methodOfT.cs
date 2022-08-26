using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func._stati
{
	public interface SubstituteI_methodOfT<T>
		:SubstituteI_methodOfTObj<obj.func.StatiI<T>>
	{


	}

	public interface SubstituteI_methodOfTObj<out TRet>
	{
		TRet substitute<T>(nilnul.obj.var.Stati<T> var, nilnul.obj.expr.StatiI<T> expr);
	}



	public interface SubstituteI<out TFunc>
	{
		TFunc substitue<TInVar,TVar,TArg>
			(TVar var,    TArg arg)
			where TVar:obj.var.Stati<TInVar>
			where TArg:obj.expr.StatiI<TInVar>
			;
	}

	public  interface SubstituteI

	{
		TFunc substitue<TVar,TArg, TFunc>
			(TVar var,    TArg arg)
			
			;

	}




}
