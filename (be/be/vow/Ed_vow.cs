using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow
{


	//[Obsolete(nameof(nilnul.obj.vow.Ed))]
	[Obsolete()]
	public class Ed_vow<T, TVow>
		:
		nilnul.obj.vow.Ed<T>
		where TVow : nilnul.obj.VowI<T>
	{
		public Ed_vow(T val, VowI<T> vow) : base(val, vow)
		{
		}
	}


}
