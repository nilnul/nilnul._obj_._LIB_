using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo_
{
	public interface ICo<T>:obj.IDuo<T,T>
	/// not <see cref="IDuo{T}"/> where the last typePar is unspecified;
	{
	}
}
