using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ
{
	/// <summary>
	/// the typ parameter is named after, and standing for one Seg of the generic's namepsace.
	/// So it's recommended to not repeat segs in namespace.
	/// </summary>
	/// <remarks>
	/// alias:
	///		generi
	/// </remarks>
	public interface IGeneric
	{

	}
	/*
		///  feed (鳄鱼), 信区: DotNET
	标 题: 泛型到底是编译器支持的，还是运行时支持的？
发信站: 水木社区(Thu Mar 23 15:27:43 2017), 站内

rt
不是很明白
如果是编译器支持的话
比如list<T>
那么我调用list<int> 和 list<string>
它就会生成两个类
是这样的吗？
--

※ 来源:·水木社区 http://newsmth.net·[FROM: 101.38.72.*]

[本篇全文] [回复文章] [本篇作者：keygen] [回信给作者] [进入讨论区] [返回顶部][分享到 搜狐微博 腾讯微博 新浪微博]2发信人: keygen (推石头的人), 信区: DotNET
标  题: Re: 泛型到底是编译器支持的，还是运行时支持的？
发信站: 水木社区(Thu Mar 23 15:55:24 2017), 站内

主要是 JIT 支持的，算是广义的编译支持吧。
C# 编译到 IL 的时候，类型是作为一个参数存在的，这个时候还没有生成新的类型。
JIT 处理这种 IL 的时候，如果泛型的类型参数是值类型，每个不同的参数类型生成单独的类型，如果类型参数是引用类型，统一使用 object 来代表，就同一份代码。

【 在 feed(鳄鱼) 的大作中提到: 】
 
	 */
}
