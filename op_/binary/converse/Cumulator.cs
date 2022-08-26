using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.converse
{
	



	public class Cumulator<T>
		:
		op_.binary.Cumulator<T>
		
	{

		public Cumulator(T initial, nilnul.obj.op_.BinaryI<T> accumulator)
			:
			base(initial, new op_.binary.Converse<T>(accumulator))
		{

		}

	}



}
