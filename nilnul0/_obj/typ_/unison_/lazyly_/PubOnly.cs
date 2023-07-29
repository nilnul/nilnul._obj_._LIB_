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
	/// multiple threads race to create objects;
	///		if a thread throws exception, the exception is not cached; the thread can later access the value that thence is to be recreated;
	///		if a thread throws no exception, it will get the value that is already created by itself or other threads;
	///
	[Obsolete("As this is waste of computation power, and it's consistent as some thread get exception, while some might get a value;")]
	static public class PubOnly<YourClass>
		where YourClass : new()
	{
	

		static public readonly System.Lazy<YourClass> _Instance =  new System.Lazy<YourClass>(
				() => new YourClass()	
				,
				 System.Threading.LazyThreadSafetyMode.PublicationOnly
				/*learn.microsoft.com/en-us/dotnet/api/system.lazy-1.-ctor?view=netframework-4.8.1#system-lazy-1-ctor(system-func((-0))-system-boolean)
				      * With any other LazyThreadSafetyMode setting, an unhandled exception in the initialization function would be cached. However, LazyThreadSafetyMode.PublicationOnly suppresses exception caching. 
				      * 
				      *  exceptions are never cached when you specify LazyThreadSafetyMode.PublicationOnly, even if initialization is performed by a function instead of by the parameterless constructor of the lazily created type.
				      *  
				      * Because the constructor for the Lazy<T> instance specified LazyThreadSafetyMode.PublicationOnly, all three threads are allowed to create LargeObject instances. The Lazy<T> object ensures that only one instance is used by all threads (except the thread where the initialization function throws an exception)
				      *  
				      * The exception message usually appears after messages indicating that other threads have successfully initialized the object. This is because of the delay introduced by throwing and catching the exception.
				      * 
				      * 
				      * 
				      */
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

