using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	//[Obsolete(nameof(nilnul.obj.op_.BinaryI) + ". for a type, the operation defined hence is returning that type; in other words, op is affiliated to a type by output, not input. Bear in mind that nilnul.obj is where we defined type ‘obj’, and any thing after 'nilnul.obj.' shall be operation that returns obj. ")]
	[Obsolete(nameof(nilnul.obj.co.IAlesce) + ".")]

	public interface BandI<out T, in TCo>
		where TCo : nilnul.obj.CoI2<T>
	{
		T band(TCo co);
	}


	[Obsolete(nameof(nilnul.obj.co.IAlesce) + ".")]
	public abstract class BandOnCombineA<T, TCo> :

	BandI<T, TCo>
	,
	nilnul.obj.CombineI1<T>
	where TCo : obj.CoI2<T>
	{
		public T band(TCo co) { return combine(co.component, co.component1); }

		public abstract T combine(T arg, T arg1)
		;
	}


}
