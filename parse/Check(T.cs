using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.parse
{
	/// <summary>
	/// vs: _parse.Check
	/// return at the first error; can return multipe occurence of error
	/// </summary>
	public class Check< T> :
		
		nilnul.obj.parse.Check<nilnul.obj._parse_.RetI<T>,T>

	{
		public Check(nilnul.obj._parse_.RetI<T> x) : base(x)
		{
		}

		

	}
}
