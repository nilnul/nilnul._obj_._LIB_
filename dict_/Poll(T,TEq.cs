using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict_
{
	public class Poll<T,TEq>:Poll<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Poll():base(nilnul._obj.Singleton<TEq>.Instance)
		{

		}

		public Poll(IDictionary<T,bool> dict):base(dict, nilnul._obj.Singleton<TEq>.Instance)
		{

		}
	}
}
