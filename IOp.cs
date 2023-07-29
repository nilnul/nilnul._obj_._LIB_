namespace nilnul.obj
{
	///
	/// as <see cref="IConvert"/> is used to denote a conversion from type to another type, "op" now can be used to refer to the intersection of <see cref="IOf"/> and <see cref="ITo"/>
	/// alias:
	///		on
	///			like no, not?
	///			1on1
	///		ov
	///			like of or over?
	/// 
	/// <summary>
	/// operation involves type T or rec of T, which might be in input, or output.
	/// By op we can let the type output/input with other types and be not isolated.
	/// </summary>
	/// <remarks>
	/// an operation; often a blacked boxed, which is called from outside and returns a result to outside; for transparent one, see<see cref="IFunc"/>
	/// </remarks>
	/// nomanclature:
	///		Op
	///			of parameter,
	///			
	/// alias:
	///		op
	///			, means a "O" shaped <see cref="IOf"/> that is <see cref="of_.IVec"/>
	///		scala	
	public interface IOp
		:of_.IVec
		,
		of_.vec_.IScala
	{
	}


}