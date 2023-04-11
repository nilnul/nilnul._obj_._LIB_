namespace nilnul.obj
{

	public interface OfI1< out TRet, in TArg> :
		IOf
		,
		nilnul.obj.OpI1<TRet,TArg> //let's reuse ;
	{
		//TRet of(TArg arg);
	}

	/// there is no need to have an "of" with nary par, as it's covered in <see cref="nilnul.obj.of_.INary"/>

}
