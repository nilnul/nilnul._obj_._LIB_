using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.op_.binary_
{
	/// <summary>
	/// also known as T.Co
	/// </summary>
	public interface ClosedI:BinaryI
	{

	}
	

	public interface ClosedI<T> 
		:
		op_.binary_.ClosedI
		,
		
		BinaryI<T, T,T>
	{

	}
}
