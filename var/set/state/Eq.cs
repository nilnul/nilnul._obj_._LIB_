using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign
{
	public class Eq<T>
		:
		nilnul.obj.set.eq_.OfEnumerable<

			 nilnul.obj.var.Assignment<T>,
				nilnul.obj.var.set.State<T>
		
		>,
		 
		nilnul.obj.var.set.assign.EqI<T>
	{


		
		public Eq(IEqualityComparer<T> valEq):base(
			new nilnul.obj.var.assign.Eq<T>(valEq)
			,
			x=>x.avowed
			)
		{

		

		}

	}
}
