using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.accumulate_
{
	public class FroCombine<T>
		: nilnul.obj.accumulate_.FroCombine<nilnul.obj.BeI<T>>
	{
		public FroCombine(obj.CombineI<BeI<T>> combine, BeI<T> unit) : base(combine, unit)
		{
		}
	}

	public class FroCombine<T, TCombine>
		:nilnul.obj.accumulate_.FroCombine<nilnul.obj.BeI<T>,TCombine>
		where TCombine: nilnul.obj.be.CombineI<T>, nilnul.obj.be._combine_.UnitI<T>,new()
	{

	}
}
