using System;

namespace nilnul.obj
{
	/// <summary>
	/// construct from known struct  of objects, to another type.
	/// If the result type is already defined, we fall into our known realm of knowledge.
	/// If the reuslt type is not defined, we either throw out exception, or we need to extend our knowledge, to construct new types on basis of current types..
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	///vs:
	///		<see cref="nilnul.obj.IOf"/>
	///			<see cref="ITo"/> shall be preferred to <see cref="IOf"/> as we can write extension methods under nilnul.someType.ToX, and then we can introduce the extension methods by introducing the namespace; Note: if we put extensions methods under the OfX, the returned is of the stub type, and we won't be intelligently tipped about the extension methods.
	///


	//[Obsolete("wrong namespace")]
	public interface ITo
		:
		nilnul.obj.of_.IOfSingle
		//nilnul.obj.op_.ITo
		//,
		//nilnul.obj.IOp<, object>

	{

	}

	[Obsolete(nameof(ITo1<T>))]
	public interface ITo<out T>
		:
		obj.ITo
		,
		nilnul.obj.of_.IOfSingle<T>

		//nilnul.obj.IOp<T, object>
	{

	}
	public interface ITo1<in T>
		:
		obj.ITo
		//,
		//nilnul.obj.of_.IOfSingle<T>

		//nilnul.obj.IOp<T, object>
	{

	}


	public interface ITo<in T1,out T>
		:
		obj.ITo1<T1>
		,
		nilnul.obj.of_.IOfSingle<T,T1>

		//nilnul.obj.IOp<T, object>
	{

	}



	


}
