using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	[Obsolete()]
	public interface SeqI1<T>
		:
		_seq_.Seq<T>
		,

		nilnul.obj.StrI_blank_ofEl<T>
	{
	}


}