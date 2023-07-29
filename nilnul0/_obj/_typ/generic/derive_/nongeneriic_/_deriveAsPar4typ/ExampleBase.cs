using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ.generic.derive_.nongeneriic_._deriveAsPar4typ
{
#if DEBUG

	///blog.stephencleary.com/2022/09/modern-csharp-techniques-1-curiously-recurring-generic-pattern.html
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TDerived"></typeparam>

	abstract class ExampleBase<TDerived>
		where TDerived : ExampleBase<TDerived>
	{
		// Methods in here can use `(TDerived)this` freely.
		// This is particularly useful if this interface wants to *return* a value of TDerived.
		public virtual TDerived Something() => (TDerived)this; /// note the abstract
	}

	class AnotherExample : ExampleBase<AnotherExample>
	{
		// Implicitly has `public AnotherExample Something();` defined.
		// The base class method already has the correct return type.
		// (Can still override if desired).
	}

#endif


}
