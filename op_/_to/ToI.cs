using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._to
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TSrc"></typeparam>
	/// <typeparam name="TDst"></typeparam>
	/// 
	[Obsolete(nameof(nilnul.obj._op.GenericI<TSrc,TDst>))]
	public interface SrcGenericI<in TSrc,out TDst>

	{
		TDst to(TSrc src);

	}
}
