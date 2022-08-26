using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;


namespace nilnul.relation
{
	public class FunctionCall<TArg,TResult>
		:FunctionCallI<TArg,TResult>
	{

		private FunctionI<TArg, TResult> _function;
		private TArg _arguments;

		public FunctionCall(FunctionI<TArg, TResult> function, TArg arguments)
		{
			_function = function;
			_arguments = arguments;
		}


		#region IFunctionCall<TArg,TResult> Members

		public FunctionI<TArg,TResult> function
		{
			get { return _function; }
		}

		public TArg x
		{
			get
			{
				return _arguments;
			}
			set
			{
				if (function.domain.Contains(value)==true)
				{
					_arguments = value;
				}
				else {
					throw new ArgumentOutOfRangeException();
				}
				
			}
		}

		#endregion

        #region IFunctionCall<TResult> Members

        FunctionI<TResult> FunctionCallI<TResult>.function
        {
            get { 
                return ((FunctionCallI<TArg,TResult>)this).function; 
            }
        }

        #endregion
    }
}
