using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary._recur_
{

	public interface OpI<TOp>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// <see cref="nameof(nilnul.obj.op_.binary._cumulator_.InitialI)"/>
		/// </remarks>
		TOp op { get; }
	}

	public interface OpI_ovObj<TObj>
		:OpI<obj.op_.UnaryI<TObj>>
	{

	}

	public abstract class OpA_ovOp<TOp>
		:OpI<TOp>

	{
		private TOp _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}

		public OpA_ovOp(TOp op0)
		{
			_op = op0;
		}

	}
}
