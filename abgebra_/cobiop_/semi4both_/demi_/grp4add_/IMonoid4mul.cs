using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_.semiring_.demi_.grp4add_
{
	/// <summary>
	/// for multiply, it's monoid;
	/// </summary>
	/// <remarks>
	/// (x+y)(1+1)=x(1+1)+y(1+1) = x+x + y+y
	/// (x+y)(1+1)=(x+y)1+(x+y)1 = x+y + x+y
	/// cancel x, and y on the border.
	/// x+y=y+x
	/// So the commutative can be inferred;
	///
	/// So this is a ring.
	/// 
	/// </remarks>
	public interface IMonoid4mul
		:
		IGrp4add
	{
	}


}
