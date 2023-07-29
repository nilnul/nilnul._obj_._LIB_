using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.grp4add_.monoid4mul_.ring_.plural_
{
	/// <summary>
	/// the add is already commutative; so here we further require multi to be commutative;
	/// </summary>
	public interface ICommutative
		:
		IPlural
		,
		ring_.ICommutative
	{
	}
}
