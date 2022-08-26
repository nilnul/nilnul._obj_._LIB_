using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ._ns._seg._nom
{
	/// <summary>
	/// at least two letters.
	/// eg:
	///		abc
	///			in
	///				_abc_
	///					which is a nom in seg: _abc_1
	///						in			nilnul._abc_1
	///		
	///	excluding:
	///		t
	///			which is considered in
	///				<see cref="nom_.ITmp"/>
	///		
	/// </summary>
	public interface ITerm
	{
	}
}
