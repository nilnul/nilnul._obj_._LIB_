using System;

namespace nilnul.obj_
{
	/// <summary>
	/// interpret the val literally; even if it's a ref, we still regard it as a literal val and process it as a pointer value type.
	/// </summary>
	/// alias:
	///		literal
	///		val
	[Obsolete(nameof(IObj) + " is itself a val; some of the val is interpreted as ref, some of the val is interpreted as literally.",true)]

	public interface ILiteral:IObj { }



	
}
