using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.avow
{
	[Obsolete(nameof(vow.Ed<T>))]
	public class Ed<T>
		:
		_ed_.AvowedA<T>
		, 
		_ed_.EdI<T>
	{
		//private _avow_.AvowI<T> _avow;

		//public _avow_.AvowI<T> avow
		//{
		//	//get { return _avow; }
		//	//set { _avow = value; }
		//}


		public Ed( T val, _avow_.AvowI<T> avow)
			:base(val)
		{
			avow.avow(val);


		}

		

		
	}
}
