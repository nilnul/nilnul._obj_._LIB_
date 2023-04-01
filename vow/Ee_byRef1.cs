using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow
{

	public class Ee_byRef<T>
		:
		Ee_byRef<T,nilnul.obj.Vow_ofRefI<T>>
		
		
	{
		public Ee_byRef(ref T val, ref nilnul.obj.Vow_ofRefI<T> vow) : base(ref val,ref vow)
		{
		}
		public Ee_byRef(ref T val, nilnul.obj.Vow_ofRefI<T> vow) : base(ref val,vow)
		{
		}
		public Ee_byRef(T val, ref nilnul.obj.Vow_ofRefI<T> vow) : base(ref val,ref vow)
		{
		}

		public Ee_byRef( T val, nilnul.obj.Vow_ofRefI<T> vow):this(ref val, vow)
		{

		}

		

		static public implicit operator T(Ee_byRef<T> ee)
		{
			return ee.eeByRef;
		}
	}


}
