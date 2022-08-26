using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.relation
{
	
	public class Function<TArgs,TResult>
		//:IFunction<TArgs,TResult>
		//where TResult: IElement 
		//where TArgs:IElement
	{
		private IExpr<ISet<TArgs>> _domain;
		private System.Linq.Expressions.Expression<Func<TArgs, TResult>> _rule;

		public Function(IExpression<ISet<TArgs>> domain,System.Linq.Expressions.Expression<Func<TArgs,TResult>> rule) {

			///todo: add some rule to check that the domain is valid through the rule. rule.maxdomain.IsSuperSetOf(domain)
			///
			this._domain = domain;
			this._rule = rule;

		}

		//public Function(Set domain,Func<TArgs[],TResult> logic) {
		//    this.logic = logic;
		//    this.domain = domain;

		//    validateDomain();

		//}

		////private bool validateDomain() {
		//    if (
		//        logic.MaxDomain().include(domain)

		//    )
		//    {
		//        _validated = true;

		//    }
		//    else {
		//        _validated = false;
				
		//    }

		//}

		/// <summary>
		/// rely on human to validate if necessary.
		/// </summary>
		/// <param name="domain"></param>
		/// <param name="logic"></param>
		/// <param name="validater"></param>
		//protected Function(Set domain, Func<Element[], Element> logic,string validater)
		//{
		//    this.logic = logic;
		//    if (
		//        logic.MaxDomain().include(domain)
		//    )
		//    {
		//        this.domain = domain;


		//    }
		//    else
		//    {
		//        this.validater = validater;
		//        this.domain = domain;
		//    }

		//}


	
	}

	
}
