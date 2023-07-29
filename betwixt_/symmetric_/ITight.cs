using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.betwixt_.symmetric_
{
	/// <summary>
	/// without concrete type info, this cannot be fully defined; as this needs to be either a <see cref="closed_.ISingleton"/>, or an open one, but the open one would be as short as possible.
	/// This can be expressed as <see cref="obj.ICo"/>: if it's <see cref="obj.co_.ISame"/>, it would be <see cref="closed_.ISingleton"/>, otherwise <see cref="open_.IAdjacent"/>
	/// </summary>
	/// <remarks>
	/// used in eg: nilnul.num.to_.Lb, which would return a closed singleton, or an open one (n,n+1), as the binary logarithm would be a number, or somewhere betwixt two adjacent numbers;
	/// 
	/// </remarks>
	/// <inheritdoc cref="ISymmetric"/>
	/// alias:
	///		tight
	///		compact
	///			might conflict other well defined math terms;
	///		
	internal class ITight
		:ISymmetric
	{
	}
}
