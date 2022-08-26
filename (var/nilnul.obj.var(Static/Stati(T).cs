using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	public interface StatiI: 
		obj.VarI_blank1
	{

	
	}




	public class Stati<T> : 
		VarA,
		StatiI
	{

	
	}


}

namespace nilnul.obj.varStatic
{

	public class Var<T> : 
		VarI_static<T>
	{

	
	}
}
