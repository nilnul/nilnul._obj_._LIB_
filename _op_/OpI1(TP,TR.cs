using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._op_
{
	/// <summary>
	/// T -> T
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// 
	[Obsolete(nameof(_op.GenericI<TPar,TOut>))]
	public interface OpI<in TPar, out TOut>
	{
		TOut op(TPar par);

	}

	


}
