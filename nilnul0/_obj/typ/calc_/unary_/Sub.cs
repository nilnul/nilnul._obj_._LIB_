using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.calc_.unary_
{

	/// <summary>
	///to inherit this, the inheriter is the sub type of <typeparamref name="C"/>. That is , eq to a sub type of <typeparamref name="C"/>.
	/// This is unnecessary ,as the inheriter can directly herit <typeparamref name="C"/>. But when it comes to generic type, this would be useful, as you cannot herit a generic type.
	/// </summary>
	/// <typeparam name="C"></typeparam>
	///
	//[Obsolete("This is unnecessary ,as the inheriter can directly herit " + nameof(C) )]
	public interface ISub<C>
	{
	}
}
