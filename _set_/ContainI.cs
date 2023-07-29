using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_
{
	/// <summary>
	/// as long as an instnce has such method, it's a set. So a set might be infinite; but it must have a mechanism to determine whether an element is inside- that is, it has an edge.
	/// but "Set" defaults to a finite "Set". for infinite set, see the concrete typed project and the "Set" defined therein; or see "nilnul.set.axiomatic" for axiomatized set.
	/// This is the "set" way of saying "be". So "be" is preferred, as it's much simpler.
	/// </summary>
	/// 
	///[Obsolete(nameof(ContainsI<T>))]
	public interface ContainI<T>
	{
		bool contain(T element);
	}


}
