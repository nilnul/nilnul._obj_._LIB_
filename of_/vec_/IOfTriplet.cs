namespace nilnul.obj.of_.vec_
{
	public interface IOfTriple<out TRet,in TInput>:IOfTriple<TRet,TInput,TInput,TInput> { }

	public interface OfTripleI<out TRet,in TInput>:

		IOfTriple<TRet,TInput>
		,
		OfTripleI<TRet,TInput,TInput,TInput>

	{ }


}
