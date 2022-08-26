using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._obj.typ_.nilable_.unprimable_.singleton_
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	public class ByLazy<YourClass>
		where YourClass : new()
		//where YourClass:class
	{
		/// <summary>
		/// this might be null when default-initiazlizing.
		/// </summary>
		/// <remarks>
		/// cuz System.Lazy need to be constructed eagerly, so if YourClass construction is not time-consuming, to create a lazy class beforehand is not worthy the saved time by the slack/delay offered by lazily creating YourClass
		/// </remarks>

		static private readonly System.Lazy<YourClass> _Instance = null;
		static ByLazy()   //due to the "Intance" body has access to "_Instance", so "_Instance will be initalized". So maybe we can remove this static constructor?
		{
			_Instance = new System.Lazy<YourClass>(
				() => unprimable_.Singleton<YourClass>.Instance, true
			);
		}/*
The thread safety mode of a Lazy<T> instance that is initialized with this constructor is LazyThreadSafetyMode.ExecutionAndPublication if isThreadSafe is true; otherwise, the mode is LazyThreadSafetyMode.None. 		  
		  **********/

		private ByLazy() { }

		/// <summary>
		/// this might be null when _Instance is null. when void of static ctor, [beforeFieldInit] is applied, and the property/member access would requires no initialization of field, so the field might be null.
		/// </summary>
	



	}
}

/*
 https://stackoverflow.com/questions/67814537/typeinitializationexception-inner-is-thread-being-aborted-exception-when-debu
which is by me


When I "Run tests" in Visual studio unit testing method, I haven't encountered any exception.

When I "Debug tests" without breakpoints, it will succeed.

But when I "Debug tests" with some breakpoints set, sometimes it will complete successfully. Sometimes it will throw "TypeInitializationException"; the inner exception of "TypeInitializationException" is "Thread being aborted exception" -- while in my test there are no multi-threading, so I don't know where this thread (the one being aborted) comes from.

I attempted to debug step by step. Visual Studio throws an exception at my access to a static property :

//namespace nilnul.obj_.
public sealed class Singleton<YourClass>
        where YourClass : new()
    {
        static private readonly YourClass _Instance = new YourClass();
        static public YourClass Instance
        {
            get
            { // <------ here is the red cross indicating exception shows, and the run exited abruptly here
                return _Instance;               
            }
        }
    }
I checked my call stack. one level up is as follows:

public class Set : nilnul.fs._address.doc_._exted.ext.Set //this is a collection of file name extensions
    {
        public Set() : base(".com", ".exe", ".bat")
        {
        }

        static public Set Singleton
        {
            get
            {
                return nilnul.obj_.Singleton<Set>.Instance;
            }
        }

    }
I suspect the above Set constructor. So I manually craft a new test in which I call the same parameterless constructor to create an instance, and I found no problem. So the constructor should not be the culprit.

The problem now seems lie with either (1): the Singleton class, or (2) the VisualStudio debugging tests (maybe VS initialized some threads I don't know, and the threads do some job in a timing that contradicts my code).

For the first possibility, I am investigating and asked another question separately on stackoverflow (see Can the static constructor be omittable in my lazy singleton class? ). I also revisited my code, and changed some lazy code (for example, in the singleton class I changed the instance construction from lazy to eager; I also changed some IEnumerable to IEnumerable.ToArray()) to eager (I don't believe that should be an issue, but changing it to eagerness might help reveal the true issue). I pondered and pondered and I don't think my code shall be an issue.

So maybe visual studio unit test, when user click "Debug tests" context menu, arbitrarily initiated some background thread to initiate types? can I configure VS to disable these arbitrary (if not wild) threads? Or can I step into the steps in the type initialization to see what on earth the issue is --currently I was just stopped at the above mentioned Singleton.Instance.get(), and told a typeInitializtionException (with the inner thread being aborted exception.)?

edit:
after some fumbles for half a day, I begin to suspect the culprit is the debug mode's auto evaluating properties. becuz: when I disable the "Enable property evaluation" options, it seems the TypeInitialization exception goes away.

So it can be derived that the Debugger use a separate thread to evaluate the static property, which initiates a field. But I still don't get why debugger aborts that thread, and why the thread aborting incurs a typeInitializationException. It seems the main thread and the debugger thread both tried to initiate one type, and the debugger thread was aborted. If so, the abort exception shall not be wrapped in the typeInitialization exception, as the type is still correctly and successfully initiated (in another thread).

If my inference is right, at least I can leave my code the way it is and stop scratching my head and dig my code dependencies to find where goes wrong. I am not sure about whether I should report this as a bug to visualstudio team (and where I should submit this to)

P.S. When click the context menu "Debug Tests", and with "Enable properties evaluating" option, the issue sometimes comes up, sometimes not. It's this "sometimes" that annoys me. So I suspect there are some racing issue among my thread and VS debug thread when both trying initiate the same type (when the debug thread fails, I will be facing an exception; otherwise, I will see no bug. and I suspect that's why the exception is thrown only SOMETIMES!)

c#
multithreading
unit-testing
Share
Edit
Delete
Flag
edited Jun 3 at 9:22
asked Jun 3 at 2:08

NilNul
1955 bronze badges
After experimenting with different options ( Runt tests or Debug test, breakPoint on or off, EnablePropertiesEval on or off ), the statistics now support my guess. So guys, if you encounter with the same issue in "Debug Tests" with breakpoints enabled, try to set off the option of "EnablePropertiesEval



 */
/*
 it seems Lazy one encounters the above problem more often than nonLazy one.
 */
