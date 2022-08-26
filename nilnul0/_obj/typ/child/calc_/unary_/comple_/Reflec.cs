using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.unary_.comple_
{
	/// <summary>
	/// for a type X,
	///		subtype S would have no instance, ie, throw exception when instanticated,
	///		then complement subtype T is a reflect of S, and alias of X.
	/// </summary>
	/// <typeparam name="P"></typeparam>
	public interface IReflec<P,C>
		:
		typ.child.calc_.unary_.IComplement<P,C>
		,
		typ.calc_.unary_.IAlias<P>
		
		where C: Exception,P //directly child type
	{

	}
}
