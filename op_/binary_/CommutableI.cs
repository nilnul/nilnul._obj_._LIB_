using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_
{

	public interface ICommutable
		:IBinary
	{ }
	public interface CommutableI<T> : BinaryI<T>
		

	{

	}

	public class Commutative<T, TOp, TVow>
		: binary.be_.commutative.vow.En<T, TOp, TVow>
		,BinaryI<T>
		where TVow : obj.op_.binary.be_.commutative.Vow_beGeneral<T, TOp>, new()
		where TOp : nilnul.obj.op_.BinaryI<T>

	{
		public Commutative(TOp val) : base(val)
		{
		}

		public T op(T par, T par1)
		{
			return this.ee.op(par,par1);
		}
	}
	public class Commutative_opDefault<T, TOp, TVow>
		: Commutative<T,TOp,TVow>
		where TVow : obj.op_.binary.be_.commutative.Vow_beGeneral<T, TOp>, new()
		where TOp : nilnul.obj.op_.BinaryI<T>,new()

	{
		public Commutative_opDefault() : base(nilnul.obj_.singleton_.Lazy<TOp>.Instance)
		{
		}

		
	}




}
