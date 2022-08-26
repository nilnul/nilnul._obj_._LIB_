using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be_.and
{
	public class Vow<TObj,TBe,TBe1>
		:nilnul.obj.be.Vow2<
			TObj
			,
			nilnul.obj.be_.FroAnd_defaultable<TObj,TBe,TBe1>
		>
		where TBe:nilnul.obj.BeI1<TObj>, new()
		where TBe1:nilnul.obj.BeI1<TObj>, new()
	{

	}
}
