using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.be.vow_.xpN_._fail;

namespace nilnul.obj.op_.binary.be_.commutative
{
	public class Vow<T, TOp, TCommutative>
		: nilnul.obj.be.vow_.xpN_.Fail<TOp, TCommutative>
		where TCommutative : be_.CommutativeI<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		public Vow(TCommutative be) : base(be)
		{
		}

		public Vow(TCommutative be, FailException<TOp, TCommutative> xpn) : base(be, xpn)
		{
		}

		public Vow(TCommutative be, string msg) : base(be, msg)
		{
		}
	}

	public class Vow_beDefault<T, TOp, TCommutative>
		: Vow<T, TOp, TCommutative>
		where TCommutative : be_.CommutativeI<T, TOp>,new()
		where TOp : nilnul.obj.op_.BinaryI<T>

	{
		public Vow_beDefault() : base(nilnul.obj_.singleton_.Lazy<TCommutative>.Instance)
		{
		}

		public Vow_beDefault( FailException<TOp, TCommutative> xpn) : base(nilnul.obj_.singleton_.Lazy<TCommutative>.Instance, xpn)
		{
		}

		public Vow_beDefault(string msg) : base(nilnul.obj_.singleton_.Lazy<TCommutative>.Instance, msg)
		{
		}


	}

	public class Vow_beGeneral<T, TOp>
		: Vow<T, TOp, nilnul.obj.op_.binary.be_.CommutativeI<T,TOp>>

		where TOp : nilnul.obj.op_.BinaryI<T>

	{
		public Vow_beGeneral(CommutativeI<T,TOp> be) : base(be)
		{
		}

		public Vow_beGeneral(CommutativeI<T,TOp> be, FailException<TOp, CommutativeI<T,TOp>> xpn) : base(be, xpn)
		{
		}

		public Vow_beGeneral(CommutativeI<T,TOp> be, string msg) : base(be, msg)
		{
		}
	}

	public class Vow_beGeneral_opGeneral<T>
		: Vow_beGeneral<T, nilnul.obj.op_.BinaryI<T>>


	{
		public Vow_beGeneral_opGeneral(CommutativeI<T, BinaryI<T>> be) : base(be)
		{
		}

		public Vow_beGeneral_opGeneral(CommutativeI<T> be) : base(be)
		{
		}

		public Vow_beGeneral_opGeneral(CommutativeI<T, BinaryI<T>> be, FailException<BinaryI<T>, CommutativeI<T, BinaryI<T>>> xpn) : base(be, xpn)
		{
		}

		public Vow_beGeneral_opGeneral(CommutativeI<T> be, FailException<BinaryI<T>, CommutativeI<T, BinaryI<T>>> xpn) : base(be, xpn)
		{
		}


		public Vow_beGeneral_opGeneral(CommutativeI<T, BinaryI<T>> be, string msg) : base(be, msg)
		{
		}
		public Vow_beGeneral_opGeneral(CommutativeI<T> be, string msg) : base(be, msg)
		{
		}

	}

}
