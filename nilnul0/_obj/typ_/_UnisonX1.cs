using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul._obj.typ_
{
	///in c++, one can return a function that returns vod;
	///

	//we can cast any type to unison by expressing that we disregard its value; in Js, we have void(any) which returns void.

	// so we can return anything if the returned type is unison; semantically this means we discard any value;
	//	This is in opposite direction to the one: you can return xpn nomatter what the returned type is.  Or this shall be in opposite to object, not unison?

	///alias:
	///	unis
	///	eg
	///	unison
	static public class _UnisonX<YourClass>
		where YourClass : new()
	{

		/// <summary>
		/// 
		/// </summary>
		static public readonly YourClass Unison = new YourClass();/*
		learn.microsoft.com/en-us/dotnet/api/system.typeinitializationexception?view=net-7.0                                                           * 
		The type has static (in C# or F#) or Shared (in Visual Basic) variables that are declared and initialized in a single statement. In this case, the language compiler generates a static constructor for the type. You can inspect it by using a utility such as IL Disassembler. For instance, when the C# and VB compilers compile the following example, they generate the IL for a static constructor that is similar to this:

.method private specialname rtspecialname static   
         void  .cctor() cil managed  
{  
   // Code size       12 (0xc)  
   .maxstack  8  
   IL_0000:  ldc.i4.3  
   IL_0001:  newobj     instance void TestClass::.ctor(int32)  
   IL_0006:  stsfld     class TestClass Example::test  
   IL_000b:  ret  
} // end of method Example::.cctor

		                                                           */

	}
}