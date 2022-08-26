using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_.opDefault_
{

	
	

	public class HeritGeneric<T, TOp>
		:
		Cumulator<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{

		public HeritGeneric(T initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{

		}

	}




}
