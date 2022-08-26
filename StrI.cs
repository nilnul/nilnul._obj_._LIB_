using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// ordered objs;i.e., objs with an order.
	/// any finite slew or collection such as array, list, linkedList, set, matrix, multi-dimensional array, of objects must be convertible to a str.
	/// A str can have only two subtype: Sans, and Started.
	/// </summary>
	/// <remarks>
	/// vs Objs
	///		str is ordered while objs are a collection of objects just put together, the strucuture or order is unspeficified.
	///		both are finite
	///		'cuz finite can always be ordered, nilnul.objs can always be converted to nilnul.obj.str; and vice versa. but for nilnul.objs, the order is not chozen yet.
	///		synonym to Objs
	///	vs Rec:
	///		common: length can change
	///		diff: the type of each component varies in rec, same in <see cref="nameof(IStr)"/>
	///		rec can be converted to a str{supper common type}, each component of which is of the common super type.
	/// </remarks>

	public interface IStr:
		IRec
		,
		ISeq
	{ }


	public interface IStr<T>:IStr{}
	/// <summary>
	/// 	 mark a custom type as finite. Donot use this as a input parameter/argument; use <see cref="nameof(IEnumerable{T})"/> directly instead.
	/// </summary>
	/// <typeparam name="T"></typeparam>

	[Obsolete(
		nameof(IEnumerable<T>)
		+
		" is simple and performant; this interface exists for "
		+ nameof(str_.seq_.Started3<T>) + " or " + nameof(str_.ISeq) 
		+ " or the like to denote it is a finite seq, while "
		+nameof(IEnumerable<T>)
		+ "doesnot explicitly say so and in fact it can be infinite; we use this interface to exclude the inifinite case."
	)]

	//[Obsolete(
	//	nameof(str_.SeqI3<T>) + " is simple and performant"
	//)]

	public interface StrI2<out T>
		:
		_str_.blank_.ItemI<T>
		,
		_str_.ToStarted0SansI<T>
	{
	}
}
