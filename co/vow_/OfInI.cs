using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.vow_
{
	public interface  OfInI<T,T1>
		:
		nilnul.obj.VowI_ofIn<(T,T1)>
	{
	}
	public interface  OfInI<T>
		:
		OfInI<T,T>
	{
	}

}
