using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._abgebra_.ops
{
	/// <summary>
	/// we can generate <see cref="obj.of_.IUnary"/> from <see cref="obj.of_.INary"/> by designing mapping like:
	///		0->1, 1->0
	///			,
	///			<see cref="abgebra_.set.DerivePositiveAry"/>
	///	<see cref="obj.of_.IBinary"/> from <see cref="obj.of_.IUnary"/> by, say,
	///		"+" from "++" by appling it repeatedly; <see cref="abgebra_.pargoid.ToRingoid"/>
	/// </summary>
	internal class GeneratingNewOps
	{
	}
}
