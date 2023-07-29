using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_.semiring_.demi_.monoid4add_
{
	/// <summary>
	/// for add it's negable.
	/// </summary>
	/// <remarks>
	/// now it's inferred that:
	///		for add, it's grp
	///
	/// annilator can be inferred：
	///		0*x=0*x+0*x
	///			cancel 0x on each sides, 0x=0
	/// </remarks>
	/// alias:
	///		negable
	///			, as inversable is called reciprocle, hence negable means for add ,not for mul;
	public interface INegable4add:ICommutative4add
	{
	}

}
