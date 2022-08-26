using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be_
{
	public class False<T> : nilnul.obj.BeI<T>

		,
		nilnul.obj.BeI1<T>
	{
		public bool be(T obj)
		{
			return false;

			//throw new NotImplementedException();
		}


		static public False<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<False<T>>.Instance;
			}
		}


	}
}
