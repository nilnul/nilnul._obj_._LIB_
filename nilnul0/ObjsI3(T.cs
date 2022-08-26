using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	/// <summary>
	/// a str of objs. it can be enumerated into different order as specfied in GetEnumerator().
	/// if order is disregarded, use obj.set.
	/// an abstract way to say T[], to make T[] short without "[]" if T is known and ommited by subclass of this, to make T[] subtypable, to make other array-like structure such as list to be abstracted and treated in the way the same as this.
	/// finite. (ordered or not) is undefined; whiel obj.str is ordered and finite
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// <c>
	/// obj.str is ordered in place
	/// </c>
	/// </remarks>
	public interface ObjsI3<out T> : IEnumerable<T>,IObjs<T>
	{



	}




}
