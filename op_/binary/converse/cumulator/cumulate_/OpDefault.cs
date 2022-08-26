using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.converse.cumulator.cumulate_
{

	public class OpDefault<T, TOp>
		: Cumulate<T>

		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public OpDefault(T initial) : base(
			initial,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TOp>.Instance
		)
		{
		}
	}
	




}
