using nilnul.obj._name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// the name in a context.
	/// for example:
	///		inside an assembly, the type's full name.
	///		inside an application, the type's name needs a prefix denoting the assembly.
	///		inside a folder of src, a repo's named converted from a division's path.
	///	<seealso cref="IIdenty"/>
	/// </summary>

	[Obsolete()]
	public class Name
		: nilnul.obj.be.En_beDefaultable<string, TxtBe>

	{

		public Name(string name) : base(name)
		{

		}

		static public bool operator ==(Name x, Name y)
		{
			return x.avowed == y.avowed;
		}
		static public bool operator !=(Name x, Name y)
		{
			return !(x == y);
		}
		static public implicit operator string(Name name)
		{
			return name.avowed;
		}

		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj  is null || GetType() != obj.GetType())
			{
				return false;
			}


			return this == obj;
			// TODO: write your implementation of Equals() here
			//throw new NotImplementedException();
			//return base.Equals(obj);
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{

			return avowed.GetHashCode();
			// TODO: write your implementation of GetHashCode() here
			//throw new NotImplementedException();
			//return base.GetHashCode();
		}

	}
}

