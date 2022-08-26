using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"> is subtype of Obj</typeparam>
	/// <typeparam name="T1"> is also subtype of Obj</typeparam>
	/// <remarks>
	/// This is implemented implicitly as :
	///		(T,T1)
	///		Tuple(T,T1)
	/// </remarks>
	public interface CoI1<T, T1> {
		 T component { get; }
		 T1 component1 { get; }

	}

	/// <summary>
	/// merge two type/par into one will make it easy to define unary function instead of binary function. somewhere we can only use unary function rather than binary function.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface CoI2<T>:CoI1<T,T>
	{ 
		 //T component { get; }
		 //T component1 { get; }
	}
}
