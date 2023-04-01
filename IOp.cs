namespace nilnul.obj
{
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
	public interface IOp
	{
	}
}