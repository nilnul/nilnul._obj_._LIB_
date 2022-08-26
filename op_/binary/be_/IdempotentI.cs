using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// idempotent
	/// absorptive
	/// reflexive
	public interface IdempotentI<T, TOp>
		: 
		nilnul.obj.op_.binary.BeI<T, TOp>
		where TOp : op_.BinaryI<T>

	{
		
	}
}
