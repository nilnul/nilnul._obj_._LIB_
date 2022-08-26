using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func._stati
{



	public interface ApplyI_TinVar_TInRule<in TInVar, TInRule>

		: ApplyI<
				expr.StatiI<TInVar>
			,
			func.StatiI<TInRule>
		>

	{

		

	}

	public interface ApplyI<  TInRule>
		:ApplyI<
			obj.expr.StatiI
			,
			obj.func.StatiI<TInRule>
		>

	{

	

	}


	public interface ApplyI<in TArg, out Ret>
	{

		Ret apply(

			TArg arg
		);

	}



}
