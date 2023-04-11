using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow.ee_.vowless_
{

	public class RetRef<T>
		:
		RetRef<T,nilnul.obj.VowI_ofIn<T>>
		
		
	{
		public RetRef(in T val, in nilnul.obj.VowI_ofIn<T> vow) : base(in val,in vow)
		{
		}
		public RetRef(in T val, nilnul.obj.VowI_ofIn<T> vow) : base(in val,vow)
		{
		}
		public RetRef(T val, in nilnul.obj.VowI_ofIn<T> vow) : base(in val,in vow)
		{
		}

		public RetRef( T val, nilnul.obj.VowI_ofIn<T> vow):this(in val, vow)
		{

		}

		

		static public implicit operator T(RetRef<T> ee)
		{
			return ee.eeByRef;
		}
	}


}
