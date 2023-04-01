using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co_
{
	/// <summary>
	/// according to nilnul rules regarding marker interface, generic ones shall inherit from less generic ones. Hence not ICo{T}:ICo{T,T}, but ICo{T,T}:ICo{T}, where ICo{T} has a typPar referring to the first type only; the second typ is undefined.
	/// </summary>
	/// <remarks>
	/// we may call such as <see cref="nilnul.obj.IDuo{T}"/>
	/// </remarks>
	/// alias:
	///		duo
	///		sametype
	///
	[Obsolete()]
	public interface IDuo<T>:ICo<T,T>
	{
	}
}
