using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.function;

namespace nilnul_obj.op
{
	/// <summary>
	/// a listop and some arguments.
	/// </summary>
	/// <typeparam name="TOp"></typeparam>
	public partial interface ListOpCallI_Op<TOp>
		: 
		
		ListOpCallI
		,
		
		OpCallI<TOp>

		where TOp:ListOpI
	{
		//TOp op
		//{
		//    get;
		//    set;
		//}
	}
}
