using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.binary_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public interface IIntersect<P,A,B>
		:typ.calc_.binary_.IIntersect<A,B>
		//,
		//nilnul.obj.IAlias<P> //it must be child of p
				,
		nilnul._obj.typ.calc_.unary_.IAlias<P>

		where A :P
		where B:P
	{
	}
}
