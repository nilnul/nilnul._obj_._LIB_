using System;

namespace nilnul.obj.op_
{
	/// <summary>
	/// construct from known struct  of objects, to another type.
	/// If the result type is already defined, we fall into our known realm of knowledge.
	/// If the reuslt type is not defined, we either throw out exception, or we need to extend our knowledge, to construct new types on basis of current types..
	/// </summary>
	///
	[Obsolete(nameof(obj.ITo))]
	public interface ITo
		:IOp
	{

	}


}
