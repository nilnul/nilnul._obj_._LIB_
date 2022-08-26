using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._str.recur_.headed0Sans_
{

	public interface SansI<T > :
		Headed0SansI<T>
		

	{

	}


	public class Sans<T> 
		: SansI<T>
	{
		public Sans( )
		{
			

		}


		static public Sans<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sans<T>>.Instance;
			}
		}

		public Headed0SansI<T> toHeaded0Sans()
		{
			return this;
		}
	}
}
