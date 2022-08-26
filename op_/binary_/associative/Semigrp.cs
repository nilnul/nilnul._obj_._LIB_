using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.associative
{
	/// <summary>
	/// if the op is associative, then together with all the instances of the type, it is semigroup
	/// </summary>
	/// semigrp can be empty.
	public interface ISemigrp: binary.IMagma
	{
	}
}
