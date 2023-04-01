using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow
{

	public class Ee_ofIn<T>
		:
		Ee_ofIn<T,nilnul.obj.VowI_ofIn<T>>
		
		
	{
		public Ee_ofIn(in T val, in nilnul.obj.VowI_ofIn<T> vow) : base(in val,in vow)
		{
		}
		public Ee_ofIn(in T val, nilnul.obj.VowI_ofIn<T> vow) : base(in val,vow)
		{
		}
		public Ee_ofIn(T val, in nilnul.obj.VowI_ofIn<T> vow) : base(in val,in vow)
		{
		}

		public Ee_ofIn( T val, nilnul.obj.VowI_ofIn<T> vow):this(in val, vow)
		{

		}

		

		static public implicit operator T(Ee_ofIn<T> ee)
		{
			return ee.eeByRef;
		}
	}


}
