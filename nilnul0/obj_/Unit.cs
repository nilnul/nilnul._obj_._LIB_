using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_
{
	/// <summary>
	/// The unit type is the terminal object in the category of types and typed functions. It should not be confused with the zero or bottom type, which allows no values and is the initial object in this category. Similarly, the Boolean is the type with two values.
	/// alias: void, Singleton Types
	/// </summary>
	public class Unit
	{
		public Unit()
		{

		}

		static public readonly Unit Singleton = nilnul.obj.SingletonByDefault<Unit>.Instance;

	}
}
