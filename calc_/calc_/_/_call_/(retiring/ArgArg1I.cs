using System;

namespace nilnul.obj._call_
{
	[Obsolete()]

	public interface ArgArg1I<T,T1>:ArgI<T>, Arg1I<T1>
	{
		
	}
	[Obsolete()]


	public interface ArgArg1I<T>:ArgArg1I<T,T> { }
}