using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.parse.check_
{
	/// <summary>
	/// vs: _parse.Check
	/// return at the first error; can return multipe occurence of error
	/// </summary>
	public class Defaultable<TParse, T> :
		
		nilnul.obj.parse.Check<TParse,T>

		where TParse : nilnul.obj._parse_.RetI<T>,new()
	{
		public Defaultable() : base(nilnul.obj_.singleton_.Lazy<TParse>.Instance)
		{
		}


		static public Defaultable<TParse, T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Defaultable<TParse, T>>.Instance;
			}
		}


	}
}
