using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// an alias for type <typeparamref name="T"/>.
	/// we use this due to:
	///		1) <typeparamref name="T"/> is too long
	///		2) <typeparamref name="T"/> would have repetive segments, which is not allowed by nilnul.dev
	///		3) <typeparamref name="T"/> might be membered type. We want to define a marker interface synonym to it.
	///		4) some <typeparamref name="T"/> is defined in a long and confluent process. But after definition, it shall provide a short/simple interface here.
	///		5) we need to put the implementations details within the project, and public the API here in the alias
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete(nameof(_obj.typ.calc_.unary_.IAlias<T>))]
	public interface IAlias<T>
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
