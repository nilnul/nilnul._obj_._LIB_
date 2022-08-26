using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_
{
	/// <summary>
	/// denote the finite aspect of the set.
	/// this can also be done by inheriting nilnul.Objs
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ToObjsI<T>
	{

		nilnul.ObjsI2<T> toObjs();

	}
}
