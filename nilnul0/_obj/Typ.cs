using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj
{
	/*
	 type shall be inclusive enough to form a closure for a set of operations.
	eg:
		we think nilnul.obj.Var is not exclusive enough as it's not closed in any operation.
			So we moved that as nilnul.obj.expr_.Var(), and  it's closed as an expr for a set expr operations.
	 */
	/// <see cref="nilnul.obj.expr_.IVar"/>
	/// <summary>
	/// this is like the System.Type, just the postthumorsly description of a type.
	///		for the type definition, there is no way that we can use the inheritance to constraint a type as stipulated here, as inheritance only applies to instance, not the type itself.
	/// </summary>
	/// <remarks>
	/// alias:
	///		type
	///	*
	///	type is in mind, while obj is what's materilized/reified/implemented in the substance sphere.
	///		so object is often named with a ver appended, for example "0r1" <see cref="nameof(nilnul.txt_._vered.ver)"/>
	///
	/// -----------static structure, and thence,  dynamic behavior
	/// type represents static structure, and instance represents dynamic behavior
	/// define things is to give a name, and give the name a meaning.
	/// </remarks>
	public interface ITyp
	{
	}
}
