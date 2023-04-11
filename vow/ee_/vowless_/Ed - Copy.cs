using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._vow_;

namespace nilnul.obj.vow
{
	[Obsolete()]

	public class Ed<T>
		:
		_ed_.VowedA<T>
		, 
		_ed_.VowedI<T>
	{
		//private _avow_.AvowI<T> _avow;

		//public _avow_.AvowI<T> avow
		//{
		//	//get { return _avow; }
		//	//set { _avow = value; }
		//}


		public Ed( T val, VowI<T> vow)
			:base(val)
		{
			vow.vow(val);

		}
	}

	[Obsolete()]


	public class Ed_vowVary<T, TVow>
		: Ed<T>
		where TVow : nilnul.obj.VowI<T>
	{
		public Ed_vowVary(T val, TVow vow) : base(val, vow)
		{
		}

		static public implicit operator T(Ed_vowVary<T, TVow> ed) {
			return ed.ed;
		}
	}

	[Obsolete()]

	public class Ed<T, TVow>
		: Ed<T>
		where TVow : nilnul.obj.VowI<T>, new()
	{
		public Ed(T val) : base(val, nilnul.obj.SingletonByDefault<TVow>.Instance)
		{
		}

		static public implicit operator T(Ed<T, TVow> ed) {
			return ed.ed;
		}
	}


}
