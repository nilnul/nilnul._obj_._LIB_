namespace nilnul.obj.of_
{
	/// <summary>
	/// no input is needed
	/// </summary>
	/// alias:
	///		nothing
	///		ofEmpty
	///		constant
	public interface IOfEmpty:IOf { }
	public interface IOfEmpty<out T>:IOf1<T>, IOfEmpty { }



}
