using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary.cumulator_
{

	public class OpDefault<T, TOp>
		: Cumulator<T>

		where TOp : nilnul.obj.of_.BinaryI<T>, new()
	{
		public OpDefault(T initial)
			:
		base(
				initial
				, 
				nilnul._obj.typ_._UnisonX<TOp>.Unison
		)
		{
		}
	}
	




}
