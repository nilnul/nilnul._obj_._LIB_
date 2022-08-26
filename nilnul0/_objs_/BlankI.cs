using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._objs_
{
	/// <summary>
	/// finite objects without structure like 1,2,3,2 in set {1,2,3,2} but without the braces, or str [1,2,3,2] without brackets, or bag {1,2,3,2} without braces. Note the different meaning of objs 1,2,3,2 in set and bag.
	/// objs can be enumerable without specified order, i.e., order is not guarteed the same every time
	/// </summary>
	/// <remarks>
	/// objs with structure (by being enclosed by brackets):
	///		(1,2): tuple
	///		&lt; 1,2 &gt: sortie, or  str that is distinct
	/// 
	/// vs:
	///		IEnumerable{T},  which might be 
	///			infinite, (Count() or ToArray() is an extension method, and implementation subtypes are not required to implement Count() or ToArray())
	///			ordered, for we have orderBy extension.
	///		Set, which disregards repeated elements whileas Objs{T} can have repeated elements.
	///		Str, which is ordered. Though we can order Objs, the order is not guaranteed the same.
	/// </remarks>
	/// 
	/*/// any finite slew or collection such as array, list, linkedList, set, matrix, multi-dimensional array, of objects must be convertible to a str.
	/// A str can have only two subtype: Sans, and Started.*/
	public interface BlankI
	{
	}
	/*for example, for a collection of string we don't want to differentiate upper case or lowercase, 
	 we don't care about whether there are ones that are same, and/or the order
	 we just enumerate if need be in a lazy way.
	 */
}
