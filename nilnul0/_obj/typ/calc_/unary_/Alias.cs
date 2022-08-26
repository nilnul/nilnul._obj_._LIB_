using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.calc_.unary_
{
	/// <summary>
	/// to inherit this, the inheriter is eq to <typeparamref name="T"/>. 
	/// an alias for type <typeparamref name="T"/>.
	/// we use this due to:
	///		1) <typeparamref name="T"/> is too long
	///		2) <typeparamref name="T"/> would have repetive segments, which is not allowed by nilnul.dev
	///		3) <typeparamref name="T"/> might be membered type. We want to define a marker interface synonym to it.
	///		4) some <typeparamref name="T"/> is defined in a long and confluent process. But after definition, it shall provide a short/simple interface here.
	///		5) we need to put the implementations details within the project, and public the API here in the alias
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// rename the type.
	/// In type system, one typ cannot inherit another. To do so, we will make a loop that is to be unallowed.
	///
	/// To denote this kinds of mutual inheritiance, we need go to a higher layer, or take a step back, to generic type. That is ,A :Alias{B}, and B:Alias{A}. note typ A is also a special(parameterless) generic typ
	///
	/// alias:
	///		alias
	///		eq
	///		equiv
	///		same
	/// </remarks>
	public interface IAlias<T>
		:
		ISup<T>
		,
		ISub<T>

	{

	}
	public interface AliasI<T>
		:IAlias<T>
	{
		/// <summary>
		/// can be converted to an instance of <typeparamref name="T"/>
		/// </summary>
		T alias { get; }
	}
}
