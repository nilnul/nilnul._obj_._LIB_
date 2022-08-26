using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.count_
{
	/// <summary>
	/// </summary>
	public class Two<T> :
	Counted<T>
	
	{
		public Two() : base(2)
		{
		}

		static public Two<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Two<T>>.Instance;
			}
		}

	}
}