using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_
{

	/// <summary>
	/// with a co of binary op.
	/// there is an order between the two op. But the two op can be the same.
	/// the first op is called "+", the second "*"
	/// </summary>
	/// alias:
	///		ringoid
	///			,similar to <see cref="IPargoid"/>, whileas "rin", not "par", is in this, meaning "", "inverse", "negation"
	///		ringish
	///		ringlike
	public interface ICobiop:IAbgebra
	{
	}


	public interface CobiopI<T,TAdd,TMulti> :

		ICobiop
		,
		_cobiop_.AddI<T,TAdd>
		,
		_cobiop_.MultiI<T,TMulti>
		where TAdd: obj.op_.BinaryI<T>
		where TMulti: obj.op_.BinaryI<T>

	{

	}
}
