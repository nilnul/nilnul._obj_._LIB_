using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.monad_
{

	

	/*
	 
	 While learning a bit about monads in C#, for exercise I implemented an Exceptional monad for myself. With this monad, you can chain up operations that might throw an Exception like in these 2 examples:
var exc1 = from x in 0.ToExceptional()
           from y in Exceptional.Execute(() => 6 / x)
           from z in 7.ToExceptional()
           select x + y + z;
Console.WriteLine("Exceptional Result 1: " + exc1);

var exc2 = Exceptional.From(0)
           .ThenExecute(x => x + 6 / x)
           .ThenExecute(y => y + 7);
Console.WriteLine("Exceptional Result 2: " + exc2);

Both expressions yield the same result, just the syntax is different. The result will be an Exceptional<T> with the arisen DivideByZeroException set as property. The first example shows the "core" of the monad using LINQ, the second contains a different and perhaps more readable syntax, which illustrates the method chaining in a more understandable way.

So, how it's implemented? Here's the Exceptional<T> type:
public class Exceptional<T>
{
    public bool HasException { get; private set; }
    public Exception Exception { get; private set; }
    public T Value { get; private set; }

    public Exceptional(T value)
    {
        HasException = false;
        Value = value;
    }

    public Exceptional(Exception exception)
    {
        HasException = true;
        Exception = exception;
    }

    public Exceptional(Func<T> getValue)
    {
        try
        {
            Value = getValue();
            HasException = false;
        }
        catch (Exception exc)
        {
            Exception = exc;
            HasException = true;
        }
    }

    public override string ToString()
    {
        return (this.HasException ? Exception.GetType().Name : ((Value    !(  is null)) ? Value.ToString() : "null"));
    }
}

The monad is completed through extension methods ToExceptional<T>() and SelectMany<T, U>(), that correspond to the monad's Unit and Bind functions:
public static class ExceptionalMonadExtensions
{
    public static Exceptional<T> ToExceptional<T>(this T value)
    {
        return new Exceptional<T>(value);
    }

    public static Exceptional<T> ToExceptional<T>(this Func<T> getValue)
    {
        return new Exceptional<T>(getValue);
    }

    public static Exceptional<U> SelectMany<T, U>(this Exceptional<T> value, Func<T, Exceptional<U>> k)
    {
        return (value.HasException)
            ? new Exceptional<U>(value.Exception)
            : k(value.Value);
    }

    public static Exceptional<V> SelectMany<T, U, V>(this Exceptional<T> value, Func<T, Exceptional<U>> k, Func<T, U, V> m)
    {
        return value.SelectMany(t => k(t).SelectMany(u => m(t, u).ToExceptional()));
    }
}

And some little helper structures, that are not part of the monad's core:
public static class Exceptional
{
    public static Exceptional<T> From<T>(T value)
    {
        return value.ToExceptional();
    }

    public static Exceptional<T> Execute<T>(Func<T> getValue)
    {
        return getValue.ToExceptional();
    }
}

public static class ExceptionalExtensions
{
    public static Exceptional<U> ThenExecute<T, U>(this Exceptional<T> value, Func<T, U> getValue)
    {
        return value.SelectMany(x => Exceptional.Execute(() => getValue(x)));
    }
}

Some explanation: a method chain built with this monad is executed as long as one method of the chain throws an exception. In this case no more method of the chain will be executed and the first thrown exception will be returned as part of an Exceptional<T> result. In this case the HasException and Exception properties will be set. If no Exception occurs, HasException will be false and the Value property will be set, containing the result of the executed method chain.

Note that the Exceptional<T>(Func<T> getValue) constructor is responsible for the exception handling and the SelectMany<T,U>() method is responsible for distinguishing if a method, that was executed before, has thrown an exception.

	 */
}
