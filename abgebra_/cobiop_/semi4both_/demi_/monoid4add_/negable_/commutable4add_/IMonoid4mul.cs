using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_.semiring_.demi_.monoid4add_.negable_.commutable4add_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///  annilator can be inferred：
	///		0*x=0*x+0*x
	///			cancel 0x on each sides, 0x=0
	/// this is a ring;
	/// </remarks>
	public interface IMonoid4mul
		:
		ICommutative4add
	{
	}
}
