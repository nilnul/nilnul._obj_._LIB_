namespace nilnul.obj.of_
{
	public interface OfCoupleI<out TRet,in TPar,in TPar1>
		:IOfCouple<TRet,TPar,TPar1>
		//,	OpI<TRet,TPar,TPar1,null>	//last TPar2 shall be understood as nothing
	{
		TRet op(TPar par, TPar1 par1);
	}



}
