using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	public class Started<T> : nilnul.obj.str._be_.OnArrI<T>
	{
		public bool be(T[] obj)
		{
			return obj.Any();
		}

		static public Started<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Started<T>>.Instance;
			}
		}

	}
}