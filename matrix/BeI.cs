using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix
{
	public interface BeI
	{
		bool be<T>(T[,] matrix);
	}
	public interface BeI<T>
		:nilnul.obj.BeI1<T[,]>
	{ }
}
