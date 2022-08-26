using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.term._adfixed.adfix_.suffix_
{
	/// <summary>
	/// suffixed for membered interface.
	/// more generic ones herit less generic.
	/// eg:
	///		AbcI{T,T1}
	///		AbcI{T}:AbcI{T,T}   // vs:<see cref="prefix_.IForInterface"/>, where T1 doesnot correspond to child T, whileas <see cref="prefix_.IForInterface"/>, abc_.IIsotype ,the generic type herits less one with T corresponds to both typePara of parent type.
	///		AbcI: AbcI{SomeDomain}
	/// </summary>
	class IForInterface
	{
	}
}
