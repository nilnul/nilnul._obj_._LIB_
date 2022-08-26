using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_._duo_._toTxt
{
	public abstract class AssociativeA
	{
		public abstract bool leftFalseRightTrue(nilnul.obj.CombineI a);


		static public AssociativeA StaticInstance = new Associatve_allLeft();

	}

	public class Associatve_allLeft: AssociativeA
	{
		public override bool leftFalseRightTrue(CombineI a)
		{

			return false;
			//throw new NotImplementedException();
		}
	}
}
