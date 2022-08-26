using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._parse_
{
	public interface RetI<TRet>
	{

		TRet parse(string x);
	}
}
