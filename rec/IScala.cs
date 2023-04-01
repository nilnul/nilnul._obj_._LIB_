using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.rec
{
	/// <summary>
	/// convert the rec structure to an instance of the type of one of the components.
	/// </summary>
	/// alias:
	///		scalarize
	///		scalar
	///		scala
	///		scalp
	///	vs:
	///		scaffold
	///			to structure
	public interface IScala
	{
	}

	/// convert the rec structure to an instance of the type, <typeparam name="T">,</typeparam> of one of the components.

	public interface IScala<T>:IScala { }
}
