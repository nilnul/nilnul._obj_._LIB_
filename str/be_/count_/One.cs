using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.count_
{
	/// <summary>
	/// </summary>
	public class One<T> :
	Counted<T>
	
	{
		public One() : base(1)
		{
		}

		static public One<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<One<T>>.Instance;
			}
		}

	}
}