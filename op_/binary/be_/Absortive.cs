using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// idempotent
	/// absorptive
	/// reflexive
	public class Absorptive<T, TOp>
		: nilnul.obj.Box1<IEqualityComparer<T>>
		,
		nilnul.obj.op_.binary.BeI<T, TOp>
		where TOp : op_.BinaryI<T>

	{
		public Absorptive(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool be(TOp obj)
		{
			return boxed.Equals()
			throw new NotImplementedException();
		}
	}
}
