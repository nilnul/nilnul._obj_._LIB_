using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._phrase_
{
	public interface ObjI<in T>
	{
		string phrase(T obj);
	}
}
