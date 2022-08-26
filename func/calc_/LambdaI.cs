using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.calc_
{
	
	/// <summary>
	/// the taxonomy of func classifies according to func's return type
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface LamdaI
		:_lamda_.LambdaI
		,
		func.CalcI
		,
		IFunc
	{
		
	}

	


}