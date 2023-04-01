using nilnul.obj.func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.unison_
{
	/// I think the fact that subtracting two pointers in C# giving you a long is an implementation detail.
	/// Well, this whole part of the discussion got started because of the fact that specifying Size = 0 for your own struct giving it a size of 1 is also an implementation detail.
	/// ClassSize of zero does not mean the class has zero size. It means that no .size directive was specified at definition time, in which case, the actual size is calculated from the field types, taking account of packing size (default or specified) and natural alignment on the target, runtime platform.
	/// A ValueType shall have a non-zero size - either by defining at least one field, or by providing a non-zero ClassSize [ERROR]
	/// As @tannergooding mentioned the CLI specification, there must be no value type of 0 size, and System.Void is indeed defined as:
	/// [StructLayout(LayoutKind.Sequential, Size = 1)]
	/// public struct Void { }
	///
	/// <summary>
	/// void
	/// </summary>

	[StructLayout(LayoutKind.Sequential, Size = 0)]
	public struct Vod
		:IUnison
	{
		//Func<void> func;
		// or maybe we shall have Func, which has non paras, as the one with no returning values?

		//static public implicit operator Void(Vod v) { }
	}



}
