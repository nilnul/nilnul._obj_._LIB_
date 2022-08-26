using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_
{
	/// <summary>
	///  the zero or bottom type, which allows no values and is the initial object in this category. 
	///  
	///  
	/// To use this:
	///		1) return this object in a function, when this type is regarded or reintroduced as the subtype of any type. here the reintroduction can be implemented by subtyping an exception.
	///		or 2) throw the exception in this object.
	///	alias:  exception and subtypes
	/// </summary>
	public class Bot
	{
		public Bot()
		{
			throw new Exception();
		}
		public Bot(string txt)
		{
			throw new Exception(txt);
		}
		public Bot(Exception exception)
		{
			throw exception;
		}
	}


}
