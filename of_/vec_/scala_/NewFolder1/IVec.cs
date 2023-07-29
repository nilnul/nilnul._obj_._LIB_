using System;

namespace nilnul.obj.op_.of_
{
	/// <summary>
	/// from vec to obj;
	/// </summary>
	/// alias;
	///		op
	///		scala
	///	vs:
	///		<see cref="of_.IStr"/>, which is not an <see cref="obj.IOp"/>
	[Obsolete(nameof(IScala))]
	public interface VecI<T>:obj.of_.vec_.ScalaI<T>
	{
	}


}
