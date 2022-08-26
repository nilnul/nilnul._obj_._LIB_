using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_
{

	[Obsolete(nameof(binary.converse.cumulator))]
	public class OpDefault4Right<T, TOp>
		: CumulatorRight<T>

		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public OpDefault4Right(T initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}
	




}
