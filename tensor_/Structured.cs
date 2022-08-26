using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tensor_
{
	/// <summary>
	/// p-dimensinal, where p is positive number.
	/// eg:
	///		<see cref="IVec"/>
	///		<see cref="IMatrix"/>
	/// </summary>
	/// <seealso cref="nilnul.obj.IStructure"/>
	public interface IStruc:ITensor
	{
	}
}
