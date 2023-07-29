using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary.cumulator_.opDefault_
{

	
	

	public class HeritGeneric<T, TOp>
		:
		Cumulator<T, TOp>
		where TOp : nilnul.obj.of_.BinaryI<T>, new()
	{

		public HeritGeneric(T initial) : base(
			initial
			,

				 nilnul._obj.typ_._UnisonX<TOp>.Unison
		)
		{

		}

	}




}
