namespace nilnul.obj.expr_.var_
{
	/// <summary>
	/// A STORAGE place. the address of the storage place is known at compile time or load time;
	/// </summary>
	/// <remarks>
	/// the storage might store the value itself, whence we call it literal;
	/// or store a pointer to the value, whence we call it reference;
	/// </remarks>
	/// alias:
	///		runtime
	///		stored
	public interface IStored:expr_.IVar { }


}
