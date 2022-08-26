using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_
{
	[Obsolete()]
	public class Distinct<T,TEq>:Distinct<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Distinct():base(nilnul.obj.SingletonByDefault<TEq>.Instance)
		{

		}

		static public Distinct<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Distinct<T,TEq>>.Instance;
			}
		}



	}
}
