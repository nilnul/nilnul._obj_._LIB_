using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_
{
	/// <summary>
	/// given any T,
	/// op(initial, any) = op(any,initial) = inital.
	/// this doesnot imply Commutativity:
	///		for example, in Matrix, (0, multi)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// This is not much useful as <see cref="UnardableI{T}"/>
	/// alias:
	///		neutral
	///		nul
	/// </remarks>
	/// 
	public interface INardable
	{
	}
}
