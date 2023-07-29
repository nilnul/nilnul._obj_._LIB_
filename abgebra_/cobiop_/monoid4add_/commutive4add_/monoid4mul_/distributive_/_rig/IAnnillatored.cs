using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.monoid4add_.commutive4add_.monoid4mul_.distributive_._rig
{
	/// <summary>
	/// nil is the <see cref="cobiop_.magma4both.el_.nil_.IAnnihilator"/>;
	///the absorption/annihilation laws, which are their nullary version:
	/// 0x=0=x0
	/// </summary>
	/// <remarks>
	/// In a ring, absorption follows from cancelling|absorption, since
	///	 0x=(0+0)x=0x+0x
	/// we can cancel one copy using grp's inversal property, to obtain
	/// 0x=0;
	/// 
	/// In a rig, however, we have to assert absorption separately.
	/// </remarks>
	public interface IAnnillatored
	{
	}
}
