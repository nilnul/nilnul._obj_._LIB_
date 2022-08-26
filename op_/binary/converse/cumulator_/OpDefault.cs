using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.converse.cumulator_
{

	public class OpDefault<T, TOp>
		: converse.Cumulator<T>

		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public OpDefault(T initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}
	




}
