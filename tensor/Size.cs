using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tensor
{
	/// <summary>
	/// a str of nums.
	/// eg:
	///		3*1
	///		[3,5,7]
	///		2
	///		0*7
	///		0	//for 1d tensor, or a vec/str.
	///		[]		//for scalar, or 0d tensor.
	/// </summary>
	public interface ISize
		:
		obj.IStr<uint>
	{

	}
}
