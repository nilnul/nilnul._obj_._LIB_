using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.be_
{
	public class Square<T>
		:
		strung.BeI<T>

	{
	

		public bool be(IEnumerable<IEnumerable<T>> obj)
		{
			
			if (obj.Any())
			{
				return SameArity<T>.Singleton.be(
					obj
				); ;
			}
			return true;
			//throw new NotImplementedException();
		}


		static public Square<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Square<T>>.Instance;
			}
		}


	}
}
