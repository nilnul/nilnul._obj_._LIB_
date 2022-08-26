namespace nilnul.obj.call_._unary_
{
	public interface OpArgI<TOp,TArg>
		:
		nilnul.obj._call_.OpI1<TOp>
		
		,


		ArgI<TArg>

		where TOp: nilnul.obj._op_.BlankI

	{

	}
}