using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.calc_.binary_
{
	/// <summary>
	/// subtype of <typeparamref name="A"/> and <typeparamref name="B"/>. This can be achieve in c# by inheriting both.
	/// </summary>
	/// <remarks>
	/// In JavaScript, there’s a concept called mixin. A mixin can be defined as a class that contains methods used by other classes, where those methods are not located inside the parent class.
	///
	/// </remarks>
	public interface IIntersect<A,B>

	#region err:  they may unify i
		//:
		//typ.calc_.unary_.ISub<A>
		//,
		//typ.calc_.unary_.ISub<B>

		/* 
and Y are the same type which then means that they would be the same
interface definition 
		 it doesn't seem to be possible - this MSDN page lists the only possible generic type constraints, and none can express the constraint "T and U can be any types, but must have distinct inheritance hierarchies" http://msdn.microsoft.com/en-us/library/d5x73970(v=vs.80).aspx
		 */

	#endregion
	{
	}
}
