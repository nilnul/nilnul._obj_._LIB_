using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.re_._distributive
{
	/// <summary>
	/// a * (b+c), where the multi is to the left of the plus in the calculation.
	/// 
	/// but in the arguments: the plus is put first, and the multi op is put last, as is done in defining algebra ring.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"></typeparam>
	public interface  LeftDistributiveI<T, TOp>
		:nilnul.obj.ReI<TOp>
		where TOp: nilnul.obj.op_.BinaryI<T>
	{

	}
}
