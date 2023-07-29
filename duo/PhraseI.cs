using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo
{
	public interface PhraseI<T,T1>
	{
		string phrase(T key, T1 val);
	}
}
