using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.re_._distributive
{
	/// <summary>
	/// If it's  <see cref="LeftDistributiveI{T, TOp}"/> or <see cref="RightDistributiveI{T, TOp}"/>
	/// in the arguments:
	/// the plus is put first, and the multi op is put last, as is done in defining algebra ring.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"></typeparam>
	public interface  SemiI<T, TOp>
		:nilnul.obj.ReI<TOp>
		where TOp: nilnul.obj.op_.BinaryI<T>
	{

	}


}
