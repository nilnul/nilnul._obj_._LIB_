using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp"></typeparam>
	/// <typeparam name="TArg">formI, or exprI? we will decide later</typeparam>
	public class Unary<TOp,TArg> : 
		nilnul.obj.call_._unary_.OpArgA<TOp,TArg>,
		nilnul.obj.call_.UnaryI<TOp,TArg>

		where TOp : nilnul.obj.op_._unary_.BlankI

	{
		public Unary(TOp op,TArg arg) : base(op,arg)
		{
		}
	}
}
