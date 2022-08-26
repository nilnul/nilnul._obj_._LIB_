using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.attr_
{
	/// <summary>
	/// if Identy is not enough to specify an object, then we can use spec. Spec inclues identy and other attrs
	/// the attrs, telling the difference from one object to another, that can be used to specify one object
	/// note, in some scenario, one object is regarded as equiv to another, while in other scenario, it's regarded differnt. so Spec is like an equivComparer.
	/// </summary>
	public interface ISpec:nilnul.obj.IAttr
	{
	}
}
