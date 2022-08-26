using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace nilnul.vod.op_
{
	/// <summary>
	/// Eg:
	///		<see cref="nameof(System.Action)"/>
	///	counterEg:
	///		<see cref="nameof(System.Action<T>)"/>
	/// </summary>
	static public class NaryX
	{

		public static void Throws<T>(this Action func, T msg)
			where T : Exception
		{
			var exceptionThrown = false;
			try
			{
				func.Invoke();
			}
			catch (T)
			{
				exceptionThrown = true;
			}

			nilnul.bit.vow_._TrueX.Vow(
				exceptionThrown
				,
				(msg)
			);

			
		}

		public static void Throws(this Action func, Exception msg)
			
		{
			func.Throws<Exception>(msg);

			
		}


		public static void Throws(this Action func, string msg="Expected exception is not thrown")
			
		{
			Throws(func, new Exception(msg));

			
		}




	}
}
