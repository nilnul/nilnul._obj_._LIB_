using System;
namespace nilnul._obj.typ_.unison_
{
	/// <summary>
	/// sometimes, <see cref="System.TypeInitializationException"/> wrapping <see cref="System.Threading.ThreadAbortException"/> happends; sometimes, it doesnot happen;
	/// I'm not sure wether it's due to multiple threads racing to initialize the type when in debugging mode or other mode when some thread is aborted when the LazyThreadSafetyMode is <see cref="System.Threading.LazyThreadSafetyMode.ExecutionAndPublication"/> (only one is run), or other mode.
	/// The Ms Doc is obsure on this; So don't use this;
	/// </summary>
	///

	[Obsolete(" Ms: If the initialization method (or the parameterless constructor, if there is no initialization method) uses locks internally, deadlocks can occur. me: sometimes we meet typeInitializationException, the inner exception of which is thread aborting;")]
	public interface ILazyly { }

	static public class _LazylyX
	{
		public const System.Threading.LazyThreadSafetyMode MODE = System.Threading.LazyThreadSafetyMode.ExecutionAndPublication;


	}
}