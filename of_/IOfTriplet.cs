namespace nilnul.obj.of_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		ofTriplet
	public interface IOfTriple:IOf { }
	public interface IOfTriple<out TRet>:IOf1<TRet>,IOfTriple { }

	public interface IOfTriple<out TRet,in TInput,in TInput1, in TInput2>:IOfTriple<TRet> { }



}
