using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{



	/// <summary>
	/// rel is finite. This is the axiomatic form of rel.Has, applicable in infinite case..
	/// </summary>
	public interface IRe
	{
	}

	public interface IRe<T, T1>:IRe1<T> {

	}


	[Obsolete( "for marker interface, less typpar shall go first, and leave other typepar for later more typepar generic ")]
	public interface IRe<T>:IRe
	{
	}

	static public class _ReX
	{
		public const char SYMBOL = '⥽'; //fish tail U+297D 


	}




}
