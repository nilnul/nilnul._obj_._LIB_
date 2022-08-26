using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func_
{
	[Obsolete()]
	public interface RuleI<out TRule>
		where TRule : nilnul.obj.ExprI
	{
		TRule rule { get; }
	}

	[Obsolete()]
	public class Rule<TRule> 
		:
		RuleI<TRule>
		where TRule : nilnul.obj.ExprI

	{
		private TRule _rule;
		public TRule rule
		{
			get
			{
				return _rule;
				//throw new NotImplementedException();
			}
		}

		public Rule(TRule rule)
		{
			_rule = rule;
		}
	}

	
}
