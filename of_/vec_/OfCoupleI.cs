namespace nilnul.obj.of_.vec_
{
	public interface IOfCouple<out TRet,in TPar>
		:of_.IOfCouple<TRet,TPar,TPar>
		//,	OpI<TRet,TPar,TPar1,null>	//last TPar2 shall be understood as nothing
	{
	}

	public interface OfCoupleI<out TRet,in TPar>
		:of_.OfCoupleI<TRet,TPar,TPar>
		,IOfCouple<TRet,TPar>
		//,	OpI<TRet,TPar,TPar1,null>	//last TPar2 shall be understood as nothing
	{
	}



}
