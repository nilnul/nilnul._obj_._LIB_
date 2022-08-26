using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_.distinct
{
	[Obsolete()]
	public class Vow_ovObj<T> : 
		
		
		nilnul.objs.be.Vow_ovObj<T>
	{
		public Vow_ovObj(IEqualityComparer<T> equalityComparer):base(
			new Distinct1<T>(equalityComparer)
		)
		{
		}

		


	}


}
