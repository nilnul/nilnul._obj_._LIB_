using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.be_
{
	/// <summary>
	/// set has el; or el is in set;
	/// </summary>
	/// vs:
	///		include: <see cref="set.re_._SupsetX"/>
	///			set includes a subset.
	/// <typeparam name="T"></typeparam>
	public interface HasI<T>
	{
		bool has(T el);
	}
}
