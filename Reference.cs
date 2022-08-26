using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// the reference to an obj. for example, var a=new Object(); a is the reference; a can be null. in a is stored the address which references the "new Object()". a is stored in a space which, say is named , "b".
	/// 
	/// but in var a=1;  a is not reference; a cannot be null. a is alias used by human, and will be compiled as "1". So a is just another coding for 1. a is the storage space for "1".
	/// 
	/// if we treat a value (not the storage space, but the stored content) as reference, then the value is interprected as a pointer to another space.
	/// </summary>
	/// <seealso cref="nameof(StorageSpace{T})"/>
	public class Reference<T>
	{


	}
}
