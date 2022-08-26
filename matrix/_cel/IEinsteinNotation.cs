using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix._cel
{
	/// <summary>
	/// C[i,j]D[j,k] would means sum over j, of all C[i,*]D[*,k]
	/// we here adapted it a little:
	///		use punc or other special character/notation rather than ordinary index to mean the index where an aggregation traverses upon.
	/// </summary>
	class IEinsteinNotation
	{
	}
}
