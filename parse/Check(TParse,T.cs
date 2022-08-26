using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.parse
{
	/// <summary>
	/// vs: _parse.Check
	/// return at the first error; can return multipe occurence of error
	/// </summary>
	public class Check<TParse, T> :
		nilnul.obj.Box<TParse>
		,
		nilnul.obj._parse.CheckI

		where TParse : nilnul.obj._parse_.RetI<T>
	{
		public Check(TParse val) : base(val)
		{
		}

		public string check(string obj)
		{
			try
			{
				boxed.parse(obj);
			}
			catch (Exception e)
			{
				return e.ToString() + " ";
			}
			return "";

		}


		

	}
}
