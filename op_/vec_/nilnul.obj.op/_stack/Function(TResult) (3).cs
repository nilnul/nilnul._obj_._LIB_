using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Function<TResult>
        :
        IFunction<TResult>
	{
		private ISet _domain;

		public Function(ISet domain) {
			_domain = domain;
			
		}



		#region IFunction<TResult> Members

		public ISet domain
		{
			get {
				return _domain;
			}
            set
            {
                throw new NotImplementedException();
            }
		}

		public Expression<Func<TResult>> rule
		{
			get { 
				return _rule;
			}
            set
            {
                throw new NotImplementedException();
            }
		}

		#endregion






        #region IFunction<TResult> Members


        LambdaExpression IFunction<TResult>.rule
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
