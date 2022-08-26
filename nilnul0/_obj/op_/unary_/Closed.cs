using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.op_.unary_
{
	/// <summary>
	/// aka: T.Op
	/// </summary>
	public interface ClosedI:UnaryI
	{

	}
	

	public interface ClosedI<T> 
		:
		op_.unary_.ClosedI
		,
		
		op_.UnaryI<T, T>
		,
		WithinSubsI<T,T,T>
	{

	}
}
