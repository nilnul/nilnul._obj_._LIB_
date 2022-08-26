using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// parse a txt into obj.
	/// 
	/// </summary>
	/// <remarks>
	/// parse is part of building process of a programming project. but building is more than parsing in that:
	///		the parsed is context free, while compiled program catches contextual state.
	///		the parsed is immutable in that information is all stored in the txt. compiled procedure may be a operation to change one state to another.
	///	
	/// </remarks>
	interface IParse
	{
	}

	public interface ParseI<T>:_parse_.RetI<T> { }
}
