using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj
{
	/// <summary>
	/// this takes a space in stack or heap. the content of this is interpreted by the runtime as an address, not a value itself.
	/// Pointer is not an object, but indirectly referencing an object.
	/// </summary>
	/// <remarks>
	/// when the pointer's val is nul, the runtime would interpret as not referencing an object at address 0, but as a special pointer that points to nothing, or an imaginary (not anywhere in the physical or data world, or hardwarewise, the memory) object.
	/// </remarks>
	internal class IPointer
	{
	}
}
