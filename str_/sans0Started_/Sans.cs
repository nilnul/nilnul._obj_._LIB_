using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started_
{

	public interface SansI<out T > :
		Sans0StartedI<T>
		,_sans_.BlankI
		

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

		public Sans0StartedI<T> toSans0Started()
		{
			return this;
		}
	}
}
