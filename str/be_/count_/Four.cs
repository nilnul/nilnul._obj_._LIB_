using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.count_
{
	/// <summary>
	/// </summary>
	public class Four<T> :
	Counted<T>
	
	{
		public Four() : base(4)
		{
		}

		static public Four<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Four<T>>.Instance;
			}
		}

	}
}