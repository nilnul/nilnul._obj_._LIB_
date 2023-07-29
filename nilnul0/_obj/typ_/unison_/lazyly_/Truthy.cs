using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._obj.typ_.unison_.lazyly_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	/// the excecption is cached; all other threads will also get the value or cached exception;

	//[Obsolete(" Ms: If the initialization method (or the parameterless constructor, if there is no initialization method) uses locks internally, deadlocks can occur. me: sometimes we meet typeInitializationException, the inner exception of which is thread aborting;")]
	static public class Truthy<YourClass>
		where YourClass : new()
	{
	

		static public readonly System.Lazy<YourClass> _Instance =  new System.Lazy<YourClass>(
				() => new YourClass()	
				,
				true /*
				     
The thread safety mode of a Lazy<T> instance that is initialized with this constructor is LazyThreadSafetyMode.ExecutionAndPublication if isThreadSafe is true; otherwise, the mode is LazyThreadSafetyMode.None.

			 If the initialization method (or the parameterless constructor, if there is no initialization method) uses locks internally, deadlocks can occur.
			:(
learn.microsoft.com/en-us/dotnet/api/system.threading.lazythreadsafetymode?view=netframework-4.8.1#system-threading-lazythreadsafetymode-none
			)
		  **********/

			);

		static public  YourClass Instance
		{
			get
			{
				return _Instance.Value;
			}
		}




	}
}

