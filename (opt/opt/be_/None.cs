using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.opt.be_
{
	public class Non<T>: 
		nilnul.obj.BeI1<nilnul.obj.OptI<T>>
		,
		nilnul.obj.BeI1<nilnul.obj.Opt1<T>>

	{
		public bool be(OptI<T> obj)
		{
			return obj is nilnul.obj.opt_.NonI; 
			throw new NotImplementedException();
		}


		

		public bool be(obj.Opt1<T> obj)
		{
			return be(obj.val);
			//throw new NotImplementedException();
		}


		static public Non<T> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Non<T>>.Instance;
			}
		}

	}
}
