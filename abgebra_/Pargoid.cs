using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_
{
	/// <summary>
	/// with a single binary op
	/// </summary>
	/// eg:
	///		magma
	///		groupoid
	/// alias:
	///		binar
	///		unibiop_
	public interface IPargoid:IAbgebra
		,
		_abgebra_.ops_.binar_.ISingleton
	{
	}
}
