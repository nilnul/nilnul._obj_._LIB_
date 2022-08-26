using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	//[Obsolete(nameof(_phrase_.ObjI<T>))]
	public interface PhraseI<T>
	{
		string phrase(T obj);
	}

	public interface PhraseI: _phrase_.ObjI<object>
	{
	}

}
