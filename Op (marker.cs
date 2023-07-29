using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	[Obsolete(nameof(of_.ITernary))]
	public interface OpI<out TRet,in TPar,in TPar1,in TPar2>
		:IOp<TRet,TPar,TPar1,TPar2>
	{
		TRet op(TPar par, TPar1 par1, TPar2 par2);
	}


	public interface OpI<out TRet,in TPar,in TPar1>
		:IOp<TRet,TPar,TPar1>
		//,	OpI<TRet,TPar,TPar1,null>	//last TPar2 shall be understood as nothing
	{
		TRet op(TPar par, TPar1 par1);
	}


	public interface OpI1<out TRet,in TPar>
		:IOp<TRet,TPar>
		//,	OpI<TRet,TPar,null>	
	{
		TRet op(TPar par);
	}

	[Obsolete()]

	public interface OpI4<out TRet>
		:IOp<TRet>
		//,	OpI<TRet,null>	
	{
		TRet op();
	}

	public interface OpI1
		:IOp,
		OpI4<object>
	{
	}



}
