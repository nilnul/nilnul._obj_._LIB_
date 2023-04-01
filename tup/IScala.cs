using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tup
{
	
	public interface IScala
		:rec.IScala
	{
	}
	public interface IScala<T> : IScala,rec.IScala<T> { }

}
