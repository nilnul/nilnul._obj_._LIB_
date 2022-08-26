using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	

	/// <summary>
	/// as Ienumerable(T) has a member : ToArray or ToList, so it's implicitly finite.
	/// if the Seq is infinite, the toArray and ToList are supposed to throw exception. In other words, when no exception is thrown, the type is finite Str.
	/// </summary>
	public interface ISeq:IStr { }
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">class or struct or any other type</typeparam>
	[Obsolete(nameof(IEnumerable<T>))]
	public interface ISeq<T> : ISeq , IStr<T>{ }

	//[Obsolete(nameof(IEnumerable<T>))]

	/// <summary>
	/// mark a custom type as finite. Donot use this as a input parameter/argument; use <see cref="nameof(IEnumerable{T})"/> directly instead.
	/// <seealso cref="nameof(nilnul.obj.IOf)"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface SeqI3<T>:
		
		nilnul.obj.IStr<T>,
		IEnumerable<T>
		,
		ISeq<T>

	{
	}

}
