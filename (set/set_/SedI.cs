using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set_
{
	public interface SedI<T, TSet>
		:nilnul.obj.set_._sed_.SeedI<T>
		,
		nilnul.obj.set_._sed_.Peri<TSet>

		where TSet : nilnul.obj.Set_blank_ofElmentI <T>
	{
		
	}

	public interface SedI<T>
	{
		nilnul.obj.set.be_.sed.vow.Ed<T> toEn();
		//seed or choice is not necessary for know that the vowed must be able to be converted to dwelt Array, then we choose the first one.
	}

	public interface SedI
	{

	}
}
