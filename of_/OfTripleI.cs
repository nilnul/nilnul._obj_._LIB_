namespace nilnul.obj.of_
{
	public interface OfTripleI<out TRet,in TPar,in TPar1,in TPar2>
		:IOfTriple<TRet,TPar,TPar1,TPar2>
	{
		TRet op(TPar par, TPar1 par1, TPar2 par2);
	}



}
