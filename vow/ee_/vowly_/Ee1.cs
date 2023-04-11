using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow
{
	[Serializable]

	[Obsolete(nameof(Ee_byRef<T>) + " is preferred in that it takes in a ref parameter in ctor.")]
	public class Ee1<T, TVow>
		:
		nilnul.obj.Box<T>
		,
		EeI<T>
		,
		_ee_.VowI<TVow>
		where TVow : nilnul.obj.VowI2<T>
	{
		public Ee1(T val,TVow vow) : base( val)
		{
			vow.vow(boxed);
		}

		private TVow _vow;

		public  TVow vow
		{
			get { return  _vow; }
			set
			{
				value.vow(boxed);
				_vow = value;
			}
		}

		public T ee => boxed;

		static public implicit operator T(Ee1<T, TVow> ee)
		{
			return ee.ee;
		}
	}

	[Serializable]

	public class Ee1<T>
		:
		Ee1<T,nilnul.obj.VowI2<T>>
		
		
	{
		public Ee1(T val, nilnul.obj.VowI2<T> vow) : base( val,vow)
		{
		}

		

		static public implicit operator T(Ee1<T> ee)
		{
			return ee.ee;
		}
	}


}
