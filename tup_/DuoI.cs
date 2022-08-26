using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tup_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		double
	///		co
	///			couple
	///				ends similar to tuple.
	public interface IDuo { }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">type of the first component. (typ of the last compnent is unknow)</typeparam>
	public interface IDuo<T> {

	}
	public interface IDuo<T,T1>:IDuo<T> {

	}


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"> subtype of the base type: here obj</typeparam>
	/// <typeparam name="T1">subtype of the base type: here it's obj</typeparam>
	/// <remarks>
	///	vs <see cref="obj.str_.Duo"/>: the component of which is of the same subtype, given a type for the discourse.
	///		
	/// </remarks>
	public interface DuoI<T,T1>:IDuo<T,T1>
	{
	}

	 interface DuoI<T>:IDuo<T,object>, IDuo<T>
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		
	/// </remarks>
	 interface DuoI:DuoI<object>
	{
	}

}
