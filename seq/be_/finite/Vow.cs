using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be_.finite
{
	public class Vow<T,TBeFinite>
		:nilnul.obj.seq.be.Vow<T,TBeFinite>
		where TBeFinite:be_.FiniteI<T>, new()

	{

	}

	public class Vow_beDynamic<T,TBeFinite>
		:

		nilnul.obj.seq.be.Vow_beDynamic<T,TBeFinite>
		where TBeFinite:be_.FiniteI<T>

	{
		public Vow_beDynamic(TBeFinite val) : base(val)
		{
		}

	}

	public class Vow_beDynamic<T>
		:

		Vow_beDynamic<T,FiniteI<T>>

	{
		public Vow_beDynamic(FiniteI<T> val) : base(val)
		{
		}

	}


	public class Vow<T>:nilnul.obj.seq.be.Vow<T,Finite<T>>

	{

	}

}
