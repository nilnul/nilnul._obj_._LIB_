namespace nilnul.obj.of_
{
	public interface OfSingleI<out TRet,in TPar>
		:IOfSingle<TRet,TPar>
		//,	OpI<TRet,TPar,null>	
	{
		TRet op(TPar par);
	}



}
