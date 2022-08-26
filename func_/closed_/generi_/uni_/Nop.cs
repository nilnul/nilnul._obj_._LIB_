using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.closed_.generi_.uni_
{
	public class Nop<T> :
		Uni<T>
		
	{
		public Nop() : base( (Expression< Func<T,T>>)(x=>x ))
		{
		}

		static public Nop<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nop<T>>.Instance;
			}
		}

	}
	public class Nop:Nop<object>
	{

		static public Nop Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nop>.Instance;
			}
		}


	}
}
