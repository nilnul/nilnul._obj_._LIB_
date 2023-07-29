using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
    static public class SwapX
    {
		static public void Swap<T>(ref T first, ref T second) {
			T temp = first;
			first=second;
			second= temp;
	
		
		}
		static public void Swap<T>(this List<T> list, int i,int j) {
			T t = list[i];

			list[i] = list[j];
			list[j] = t;
		}



    }

	/*

为什么要这么swap，没看出来有任何的优点啊
虽然少了一个变量，但是多了3个加减操作
临时变量可能被编译器优化到寄存器中，几乎没有开销
而这个3个加减操作可优化不了

而且加法还可能溢出，代码可读性也差。
不过同X的面试官也非常垃圾，刚毕业的经验不足这么写并不是什么严重的问题

用临时变量编译完了就是四个movl而已，用xor需要三次movl三次xorl。

哪个好还用再说吗？

	*/
}
