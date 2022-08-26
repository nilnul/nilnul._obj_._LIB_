using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.unary_
{
	/// <summary>
	/// <typeparamref name="C"/> should inherit this.
	/// an alias for type <typeparamref name="P"/>.
	/// we use this due to:
	///		1) <typeparamref name="P"/> is too long
	///		2) <typeparamref name="P"/> would have repetive segments, which is not allowed by nilnul.dev
	///		3) <typeparamref name="P"/> might be membered type. We want to define a marker interface synonym to it.
	///		4) some <typeparamref name="P"/> is defined in a long and confluent process. But after definition, it shall provide a short/simple interface here.
	///		5) we need to put the implementations details within the project, and public the API here in the alias
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="C"> the type that inherits this type</typeparam>
	/// <remarks>
	/// rename the type.
	/// In type system, one typ cannot inherit another. To do so, we will make a loop that is to be unallowed.
	///
	/// To denote this kinds of mutual inheritiance, we need go to a higher layer, or take a step back, to generic type. That is ,A :Alias{B}, and B:Alias{A}. note typ A is also a special(parameterless) generic typ 
	/// </remarks>
	public interface IAlias<P,C>
		:typ.calc_.unary_.IAlias<P>
		where C:P
	{

	}
	
}
