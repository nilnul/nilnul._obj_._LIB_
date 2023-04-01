using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func
{
	/// as nilnul.set.Family is used to denote set of sets when discussed together with nilnul.Set such as to distinguish the two, "func.Lambda" denotes function of func, to distinguish from "Func" when used together.
	/// cuz it's functional of func, hence the pars are of type "Func", ie, <see cref="func.expr_.IVar"/>, and the body is <see cref="func.IExpr"/>
	/// 
	/// <summary>
	/// it's a function of func. in nilnul, repetive notions are renamed to a new term;
	/// lambda is the parameterize of function that in turn is the parameterization of expr.
	/// lambda is higher ordered with respect to func, as in lambda, we can operate on func, and returns func.
	/// So it's defined based on <see cref="func.IExpr"/>. The logic to transform one func to another might be hidden logic in the body of the function of func, including the <see cref="func.IOp"/>
	/// Note this is defined different from <see cref="System.Linq.Expressions.LambdaExpression"/>
	/// </summary>
	/// 
	/// to be functional of func, we need <see cref="func.IOp"/> to trans out the <see cref="obj.IFunc"/> to involving with other types. we then can have <see cref="func.ICalc"/> and <see cref="func.IExpr"/>, including <see cref="func.expr_.IVar"/>, and herehence parameterized <see cref="func.IExpr"/> to get funtionals:<see cref="func.ILamda"/>.
	/// lambda as func on <see cref="obj.IFunc"/> is like <see cref="obj.IFunc"/> to <see cref="IObj"/>
	/// 
	/// alias:
	///		lamda
	///			avoiding use of lambda, as it's used in greek letter.
	/// vs：
	///		<see cref="func.ICalc"/>
	///			calc 's par can be func or nonfunc, if the calc is abstracted func <see cref="func.calc_.ILamda"/>. If the par is func, then it's equiv to <see cref="ILamda"/>.
	///				but a calc might have no par. For example, the application and the compos expression.
	///			
	///	vs:	<see cref="IFunc"/>
	///			func's par can be func. But func's body is taken as an <see cref="obj.IExpr"/>, which might be a nonfunc.expr (not <see cref="func.IExpr"/>)
	///				whileas this is a func of func, and every par stands for a func, not obj;

	public interface ILamda
	{
	}
}
