using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary
{
	/// <summary>
	/// the op, together with all the instances of type is an algebra.
	/// </summary>
	public interface IMagma
	{
	}

	/// <summary>
	/// Note exception is subtype of T. So operator can throw exception.
	/// However, if the set is not the type, but a subset of all instances, the returned must not be out of the set.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IMagma<T>:IMagma {

	}
}
