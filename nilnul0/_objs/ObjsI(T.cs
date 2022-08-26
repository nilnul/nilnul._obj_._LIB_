using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// any finite slew or collection such as array, list, linkedList, set, matrix, multi-dimensional array, of objects must be convertible to a str.
	/// A str can have only two subtype: Sans, and Started.
	/// </summary>
	/// 
	[Obsolete()]
	public interface ObjsI<T>:ObjsI
	{

	}
	[Obsolete()]
	public interface ObjsI1<T> : ObjsI, IEnumerable<T> { }

	


}
