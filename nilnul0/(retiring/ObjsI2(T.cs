using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	

	/// <summary>
	/// finite many objects.
	/// It can be fed into nilnul.obj.Str to gain an arbitrary order. So the order is unspecified here.
	/// It can be fed into nilnul.obj.Set to treat repeating as one. 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	///		
	/// <c>
	/// obj.str is ordered in place
	/// </c>
	/// </remarks>
	/// /// objects. 
	/// an abstract way to say T[], to make T[] short without "[]" if T is known and ommited by subclass of this, to make T[] subtypable, to make other array-like structure such as list to be abstracted and treated in the way the same as this.
	/// finite. (ordered or not) is undefined; whiel obj.str is ordered and finite
	///
	[Obsolete()]
	public interface ObjsI2<T> : nilnul._objs_.ToArrI<T>, ObjsI, _objs_.BlankI, IObjs<T>
	{



	}





}
