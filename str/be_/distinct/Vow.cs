using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct
{
	public class Vow2<T>
		: 
		nilnul.obj.str.be.Vow1<T>
	{
		public Vow2(IEqualityComparer<T> equalityComparer):base(
			new Distinct3<T>(equalityComparer)
		)
		{
		}
	}
}