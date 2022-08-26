using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.refer.static_.fields
{
	/*
	 https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1810
	CA1810: Initialize reference type static fields inline

Cause
A reference type declares an explicit static constructor.

When a type declares an explicit static constructor, the just-in-time (JIT) compiler adds a check to each static method and instance constructor of the type to make sure that the static constructor was previously called. Static initialization is triggered when any static member is accessed or when an instance of the type is created. However, static initialization is not triggered if you declare a variable of the type but do not use it, which can be important if the initialization changes global state.

When all static data is initialized inline and an explicit static constructor is not declared, Microsoft intermediate language (MSIL) compilers add the beforefieldinit flag and an implicit static constructor, which initializes the static data, to the MSIL type definition. When the JIT compiler encounters the beforefieldinit flag, most of the time the static constructor checks are not added. Static initialization is guaranteed to occur at some time before any static fields are accessed but not before a static method or instance constructor is invoked. Note that static initialization can occur at any time after a variable of the type is declared.

How to fix violations
To fix a violation of this rule, initialize all static data when it is declared and remove the static constructor.


	 */
	/// <summary>
	/// 
	/// </summary>
	class Init
	{
		//public override sealed string ToString() { return ""; }
	}
}

/*
 * 
https://csharpindepth.com/Articles/BeforeFieldInit

 class Test
{
    static object o = new object();
}

class Test
{
    static object o;

    static Test()
    {
        o = new object();
    }
}
The two classes are not, in fact, the same. They both have type initializers - and the two type initializers are the same. However, the first does not have a static constructor, whereas the second does. This means that the first class can be marked as beforefieldinit and have its type initializer invoked at any time before the first reference to a static field in it. The static constructor doesn't even have to do anything. This third class is equivalent to the second:

class Test
{
    static object o = new object();

    static Test()
    {
    }
}
 */