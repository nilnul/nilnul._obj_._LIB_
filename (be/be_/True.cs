using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be_
{
	public class True<T> : nilnul.obj.BeI<T>
		,
		nilnul.obj.BeI1<T>
	{
		public bool be(T obj)
		{
			return true;

			//throw new NotImplementedException();
		}


		static public True<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<True<T>>.Instance;
			}
		}


	}
}
