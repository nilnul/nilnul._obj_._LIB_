namespace nilnul.obj.of_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		create,
	///			often means to materialize concept. for example,in IO, create file from data in memory.
	///		single, like tuple|<see cref="obj.ITup"/>, whileas <see cref="vec_.ICo"/>,<see cref="vec_.Uno{T}"/>, ..., etc ending with 'o' means <see cref="obj.IVec"/>
	public interface IOfSingle:IOf { }
	public interface IOfSingle<out T>:IOf1<T> ,IOfSingle{ }
	public interface IOfSingle<out TRet,in TInput>:IOfSingle<TRet> { }




}
