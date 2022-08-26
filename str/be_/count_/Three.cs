using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.count_
{
	/// <summary>
	/// </summary>
	public class Three<T> :
	Counted<T>
	
	{
		public Three() : base(3)
		{
		}

		static public Three<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Three<T>>.Instance;
			}
		}

	}
}