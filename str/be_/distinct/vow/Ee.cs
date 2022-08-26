using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct.vow
{

	public class Ee1<T>
		:
		nilnul.obj.str.vow.Ee1<T>

	{
		public Ee1(
			IEnumerable<T> val
			,
			distinct.Vow2<T> vow
		)
			:
			base( val,vow)
		{
		}

		public Ee1( IEqualityComparer<T> eq, IEnumerable<T> val) :this(
			val
			,
			new distinct.Vow2<T>(eq)
		)
		{
		}

		public Ee1(
			EqualityComparer<T> eq
			,
			params T[] elements
		)
		:this(
			eq
			 ,
			(IEnumerable<T>)(elements) 
		)
		{
		}
	}
}