using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct_
{

	public class EqNeo<T,TEq>
		: 
		Distinct3<T >
		where TEq : IEqualityComparer<T>, new()
	{
		public EqNeo() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance)
		{
		}


		static public EqNeo<T,TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqNeo<T,TEq>>.Instance;
			}
		}

	}




}
