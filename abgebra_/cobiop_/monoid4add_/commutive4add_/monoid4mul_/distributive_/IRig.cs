using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.monoid4add_.commutive4add_.monoid4mul_.distributive_
{


	/// <summary>
	/// for plus
	///		it is commutative monoid <see cref="pargoid_.magma_.semigrp_.monoid_.ICommutative"/>
	///			this requirs the set to be dwelt
	///	for multi
	///		it's a monoid with neutral element One, <see cref="pargoid_.magma_.semigrp_.IMonoid"/>
	/// 
	///		
	///			
	/// 
	/// </summary>
	/// <remarks>
	/// eg:
	///		natural numbers.
	///		

	/// 
	/// </remarks>
	/// rig
	///		ring without negation. for add, it's almost abel group (the "g" in "rig") but lack of negation;
	///	semiring
	///		taken by <see cref="cobiop_.IDistributive"/> as it means similar but not yet ring.
	///		also in semigrp we require the op to be associative, we don't need identity.
	/// 
	public interface IRig
		:
		IDistributive
		,
		_rig.IAnnillatored


	//cobiop_.associative4both_.distributive_.ISemiring // for 1st op, commutative and identity; for 2nd op, identity. for all: nil is nard for multi.
	//,
	//ISemiRig

	{
	}

	/*
	 try prove that nil is nard for multi.
	proof:

		 0*x=(0+0) * x = 0x +0x.
		then whether 0x=0?
			if we don't have negation, we cannot have the following:
				0x + -0x= 0x +0x -0x   hence 0=0x


	counter eg:
		///			for bits {0,1}, with ops {&,&}. the nil is not annilator.
		///			for bits {0,1}, with ops {|,|}. the nil is not annilator.
		///			
		///
		///https://math.stackexchange.com/questions/1186702/examples-for-almost-semirings-without-absorbing-zero/4425358#4425358
		///
		/// ( R∪{−∞,∞}
		///		,max,−∞
		///		,+,0
		///	)
		///		in which we define ∞+(−∞)=∞, making ∞ the multiplicative annihilator instead of the additive identity −∞.
		///
		///
		/// Let S be the set of pairs in R2 of the form [a,b] where a≤0 and b≥0.
		/// Define
		/// [a,b]+[a′,b′]=[min(a,a′),max(b,b′)]
		/// and
		/// [a,b][a′,b′]=[a+a′,b+b′]
		/// All it takes for distributivity are the identities  min(a,a′)+c=min(a+c,a′+c)  and max(b,b′)+c=max(b+c,b′+c).
		/// It turns out that e=[0,0] is the neutral element for both operations of S, so a=a+e=ae, and then it's impossible for e to multiplicatively absorb non e elements.
		///
	*/

	/*


	try check whether 0=1.

		if nil and 1 are the same element.
			if there is no nonnil elements:
				then it's ok.
					this is a trivia ring.


	 */

}

