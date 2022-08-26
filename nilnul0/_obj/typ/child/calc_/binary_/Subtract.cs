using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.binary_
{

	/// <summary>
	/// not type <typeparamref name="C1"/>, but type <typeparamref name="C"/>
	/// </summary>
	/// <typeparam name="C"></typeparam>
	/// <typeparam name="C1"></typeparam>
	public interface IExcept<P, C,C1>
		:
		_obj.typ.calc_.binary_.ISubtract<C,C1>
		//,
		//nilnul.obj.IAlias<P>
		,
		nilnul._obj.typ.calc_.unary_.IAlias<P>

		where C:P
		where C1:P


	{
	}
}
