using System;

namespace nilnul.obj.expr_.call_._nary
{
	[Obsolete(nameof(obj.calc_._nary.IOp))]

	public interface IOp {

	}

	[Obsolete(nameof(obj.calc_._nary.IOp))]
	public interface OpI<out TOp>
		:IOp
		where TOp:nilnul.obj.IOp
	{
		TOp op { get;  }
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	[Obsolete(nameof(obj.calc_._nary.IOp))]
	public class Op<TOp>

	{
		private TOp _op;
		public TOp op
		{
			get
			{
				return _op;
			}
			set
			{
				_op = value;
			}
		}
		public Op(TOp op)
		{
			this.op = op;
		}
	}
}