using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._parse
{
	public interface CheckI<in T>
	{
		string check(T obj);
	}
	public interface CheckI
	{
		string check(string obj);
	}

}
