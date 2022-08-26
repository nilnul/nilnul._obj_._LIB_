using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// container is extension of set in that set will be put as a subtype of container.
	/// </summary>
	/// <remarks>
	/// alias:
	///		collection
	///			but container is more explicit and unambigouse in having a method called "contain"
	///			avoid conflicts with builtin type:ICollction
	///			container is used to denote the "shell", content is used to denote the "inner". Collection denotes both so we should use this term
	///		container
	///	nomanclature
	///		vered 0 to avoid conflict with builtin ICollection
	/// </remarks>
	public interface ICollection0 {

	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ICollection0<T>
		:ICollection0 // for "I"Led interface, generic type inherit from those of less type paras.
	{ }

	public interface CollectionI<T>
		:_collection_.ContainI<T>
		,_collection_.BlankI
		
		,
		ICollection0<T>
	{

	}

	

	/// <summary>
	/// a collection of objects. a CollectionI(T) where T is object
	/// </summary>
	public interface CollectionI1:CollectionI<object>
	{
	}

}
