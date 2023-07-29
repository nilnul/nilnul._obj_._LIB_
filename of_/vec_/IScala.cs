namespace nilnul.obj.of_.vec_
{
	/// <summary>
	/// vec to obj. the type of the compnent of the vec is the same of the returned;
	/// </summary>
	/// alias:
	///		ofVec
	///		scala,
	///			where "s" is also the intial of str, the input type.
	///	vs:
	///		ofVec, where the ret type might differ from the type of the component of the input vec, whileas the ret type of this is the same as that of the component of the input vec.
	/// vs:
	///		ofStr, where the arity is not fixed. 
	///	<see cref="obj.of_.IVec"/>	
	public interface IScala:IVec
	{
	}
	public interface IScala<T>:IVec<T,T>,IScala
	{
	}



}
