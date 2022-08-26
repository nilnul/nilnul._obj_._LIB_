using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.be_.commutative.vow
{
	public class En<T, TOp, TVow>
		: nilnul.obj.vow.Ee<TOp, TVow>
		where TVow : be_.commutative.Vow_beGeneral<T, TOp>, new()
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		public En(TOp val) : base(val, nilnul.obj_.singleton_.Lazy<TVow>.Instance)
		{
		}
	}
	public class En<T,  TVow>
		: nilnul.obj.vow.Ee<nilnul.obj.op_.BinaryI<T>, TVow>
		where TVow : be_.commutative.Vow_beGeneral_opGeneral<T>, new()
	{
		public En(nilnul.obj.op_.BinaryI<T> val) : base(val, nilnul.obj_.singleton_.Lazy<TVow>.Instance)
		{
		}
	}


}
