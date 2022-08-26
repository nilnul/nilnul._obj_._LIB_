using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.expr;

namespace nilnul.obj.func.stati.mono
{
	public class Vary
	{

		public class Call_tInVar_TInFunc<TInVar,TInRule>
			:
			Call<obj.var.Stati<TInVar>, obj.func.StatiI<TInRule>>

			,StatiI<TInRule>
			,_stati.ApplyI<TInRule>

			//,obj.func._stati.SubstituteI_methodOfTObj<>
			where TInVar : obj.var.Stati<TInVar>
			where TInRule : obj.func.StatiI<TInRule>, obj.func._stati.SubstituteI_methodOfT<TInRule>
		{


			public Call_tInVar_TInFunc(
				obj.var.Stati<TInVar> var
				,
				obj.func.StatiI<TInRule> rule
				):base(var, rule)
			{


			}

			public StatiI<TInRule> apply(expr.StatiI arg)
			{
				if (arg is obj.expr.StatiI<TInVar> )
				{
					return apply(arg as obj.expr.StatiI<TInVar>);
				}

				throw new NotImplementedException();
			}

			public obj.func.StatiI<TInRule> apply(obj.expr.StatiI<TInVar> arg)
			{

				return this.rule.substitute<
					TInVar
					
				>(
					var, arg
				);

			}

			

			public StatiI<TInRule> substitute<T>(var.Stati<T> var, expr.StatiI<T> expr)
			{

				return new Call_tInVar_TInFunc<TInVar,  TInRule >(
					this.var
					,
					this.rule.substitute<T>(var, expr)
				);

				throw new NotImplementedException();
			}
		}



		public class Call<TVar, TFunc>
		{
			private TVar _var;

			public TVar var
			{
				get { return _var; }
				set { _var = value; }
			}

			private TFunc _rule;

			public TFunc rule
			{
				get { return _rule; }
				set { _rule = value; }
			}

			public Call(TVar var, TFunc func)
			{
				_var = var;
				_rule = func;

			}

			public override string ToString()
			{
				return $"({_var}){obj._func.FuncX.GoesTo}{_rule}";


			}

		}
	}
}
