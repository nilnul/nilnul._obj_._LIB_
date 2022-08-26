using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.nonref.static_.fields
{
	/*
	 https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2207
CA2207: Initialize value type static fields inline
Cause
A value-type declares an explicit static constructor.

When a value-type is declared, it undergoes a default initialization where all value-type fields are set to zero and all reference-type fields are set to null (Nothing in Visual Basic).



	An explicit static constructor is only guaranteed to run before an instance constructor or static member of the type is called. Therefore, if the type is created without calling an instance constructor, the static constructor is not guaranteed to run.

If all static data is initialized inline and no explicit static constructor is declared, the C# and Visual Basic compilers add the beforefieldinit flag to the MSIL class definition. The compilers also add a private static constructor that contains the static initialization code. This private static constructor is guaranteed to run before any static fields of the type are accessed.


How to fix violations
To fix a violation of this rule initialize all static data when it is declared and remove the static constructor.

Example
The following example shows a type, StaticConstructor, that violates the rule and a type, NoStaticConstructor, that replaces the static constructor with inline initialization to satisfy the rule.

C#

Copy
public class StaticConstructor
{
    static int someInteger;
    static string resourceString;

    static StaticConstructor()
    {
        someInteger = 3;
        ResourceManager stringManager =
           new ResourceManager("strings", Assembly.GetExecutingAssembly());
        resourceString = stringManager.GetString("string");
    }
}

public class NoStaticConstructor
{
    static int someInteger = 3;
    static string resourceString = InitializeResourceString();

    static string InitializeResourceString()
    {
        ResourceManager stringManager =
           new ResourceManager("strings", Assembly.GetExecutingAssembly());
        return stringManager.GetString("string");
    }
}
Note the addition of the beforefieldinit flag on the MSIL definition for the NoStaticConstructor class.

il

.class public auto ansi StaticConstructor
extends [mscorlib]System.Object
{
} // end of class StaticConstructor

.class public auto ansi beforefieldinit NoStaticConstructor
extends [mscorlib]System.Object
{
} // end of class NoStaticConstructor
	 
	 */
	/// <summary>
	/// 
	/// </summary>
	class Init
	{
	}
}
