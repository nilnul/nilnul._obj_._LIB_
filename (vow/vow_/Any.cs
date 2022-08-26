using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow_
{
	/// <summary>
	/// this guy is not principaled; he receives everything.
	/// This type is not very practically useful; it's put here for just theoretical beautifulness.
	/// If an entity is uselss or doing nothing or is plain-sightedly simple, its appearances indicates that the program is good at simplifying problems.
	/// </summary>
	public class Any 
	{

		//[Conditional("a")]	//an interface cannot be conditional
		[DebuggerStepThrough]

		public void vow()
		{
				
		
		}
	

		static public readonly Any Singleton = SingletonByDefault<Any>.Instance;

	}
}
