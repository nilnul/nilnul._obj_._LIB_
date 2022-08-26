using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.obj.func.pars_
{
	/// <summary>
	/// <see cref="LambdaExpression.Body.Vars"/> intersected with <see cref="LambdaExpression.Parameters"/>
	/// </summary>
	public interface IUsedInBody: reps_.pars_.IBodied
	{
	}
}
