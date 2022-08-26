using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.term._adfixed.adfix_.prefix_
{
	/// <summary>
	/// prefixed for marker interface.
	/// there is no memeber in the interface.
	/// </summary>
	/// <remarks>
	/// more generic types shall inherit less generic ones if the two types share the same name.
	///	eg:
	///		IAbc
	///		IAbc{T} : IAbc
	///		IAbc{T,T1}:IAbc{T}   /// note, the order of the (T,T1) shall be: the one to be herited goes first.
	///	If you do need a more generic type to herit less generic one, do as follows:
	///		IAbc{T,T1}
	///		abc_.IIsotype{T}:IAbc{T,T}
	///	vs: <see cref="suffix_"/>
	/// </remarks>
	class IForInterface:adfix_.IForInterface
	{
	}
}
