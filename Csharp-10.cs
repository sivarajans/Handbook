global using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;


public class Implementation : Abstraction
{
    public override string absMember { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    volatile int volatiled = 5;

    public async void doParallel()
    {
        dynamic variable = 5;
        variable = variable + 25;
        variable = variable + "string";



        int ij = 020;
        long jk = 23423;

        object mk = 32;
        var okex = mk switch
        {
            int and > 20 or -100 => 243,
            int and <= 20 and -5 => 3,
            string => 232,
            bool s => 1,
            int ls => ls,
            var(d) => 23,
            _ => 1
        };

        ReadonlyStruct structure = new ReadonlyStruct { id = ij };
        var copied = structure with { name = "applied name" };



        List<Task> tasks = new List<Task>();
        for (int i = 1; i <= 50; i++)
        {
            var j = i;
            tasks.Add(new Task(() =>
            {
                volatiled = j;
                Console.WriteLine($"Running {j} {volatiled}");
                do
                {
                    j++;
                }
                while (j <= 545433543);
            }));
        }

        foreach (var t in tasks)
        {
            t.Start();
        }
        foreach (var t in tasks)
        {
            await t;
        }

        if (ij == jk || jk == 20)
        {

        }

        var ok = from t in tasks
                 join tagain in tasks
                 on t.Id equals tagain.Id
                 where t.Id == 200 || t.Id == 100
                 let mic = t.Exception
                 //group t by t.Status into stg
                 orderby t.Status ascending, t.IsCompleted descending, mic.Source ascending
                 //orderby t.IsCompleted descending
                 select t;

        var sdl = nameof(ok);
        var slkd = nameof(Parent);
        nint _i = 5;
        nuint _j = 324;

        //ParallelLoopResult idx = Parallel.For(1, 50, (int i) =>
        //{
        //    volatiled = i;
        //    Console.WriteLine($"Running {i}");
        //    //Thread.Sleep(5000);
        //});

        //if (idx.IsCompleted)
        //{

        //}
    }

    public IEnumerable<int> yielder()
    {
        foreach (var l in new int[] { 1, 2, 4 })
        {
            yield return l;
        }
    }

}

public abstract class Abstraction
{
    [DllImport("kernel32.dll")]
    private static extern void DoMeDll(string arg);


    public abstract string absMember { get; set; }
    private int? locMember { get; set; } = 5;

    public void Function(string s)
    {
        short? ln = locMember as short?;
    }
}

internal class Parent
{
    public delegate void Delegation(string args);
    private Delegation delegated;
    public event Delegation? delegatedEvent
    {
        add
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            delegated += value;

        }
        remove
        {
            Console.WriteLine("removal suspended");
        }
    }

    public void call()
    {
        delegated?.Invoke("fsd");

    }
    protected string protectedMember { get; set; } = "sd";
    const long longHigh = long.MaxValue - 1;
    public int ParentId { get; set; }
    public string? ParentName { get; set; }
    public char Type { get; init; }
    public decimal Amount { get; set; }



    public bool isParent()
    {



        try
        {
            switch (ParentId)
            {
                case 0:
                    ParentName = "nullified Parent";
                    ParentId = 1;
                    Delegation d = (string d) => { };
                    delegated += d;
                    delegated = d; // existing are overridden


                    delegatedEvent += d;
                    delegatedEvent -= (string dx) => { };
                    //delegatedEvent = d;
                    //delegatedEvent.Invoke("S");


                    break;
                case 1: return true;
                default: return false;
            }
        }
        catch (Exception)
        {
            // assume logging here.
            throw new Exception("errored here.");
        }
        finally
        {

        }
        return false;
    }

    public void LoopSimulator()
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i == 5) continue;
            if (i == 10) break;

        }
    }

    public Parent(int parentId)
    {
        ParentId = parentId;
        Type = 'P';
    }

    public void References(in string referenceNotAllowedForModification, ref string referenceModification, out string mustBeAltered)
    {
        mustBeAltered = "";
    }

    public void GetAllParents(params Parent[] parents)
    {

    }

    public static implicit operator String(Parent p)
    {

        return p.ParentName ?? "";
    }

    public static explicit operator Byte(Parent p)
    {
        return (byte)p.ParentId;
    }

    public static Parent operator +(Parent a)
    {
        return a;
    }
}

internal class Child : Parent, ITop
{
    private static object lc = new();
    public int ChildId { get; set; }
    public string? ChildName { get; set; }
    public readonly double Doubled = 3.0;
    public bool WhoIsIt = true;
    public bool WhatElse = false;
    public sbyte sineByte = -5;

    public IEnumerable<Action> actions = new List<Action>();
    public Child(int childId, int parentId) : base(parentId)
    {
        Doubled = 5;
        protectedMember = "child invocation";
    }

    public new void LoopSimulator()
    {
        float map = 32.3F;
        long ln = 32;
        do
        {
            ChildName = ChildId == 1 ? "#" : "#";

        } while (ChildName != "#");

        int i = 5;
        while (i == 5)
        {
            i = 6;
        }
        foreach (var l in actions)
        {

        }

        for (var i3 = 0; i3 <= 255; i3++)
        {

        }

        if (true && lc is not null)
        {
            lock (lc)
            {
                if (lc is null)
                {

                }
            }
        }
        else
        {
            if (lc == null)
            {

            }
        }
        GenericClass p = new();
        p.DoSo<Ok?, Child>();


        //p.DoIt<int?, Child>();

        //p.DoOverried<long?>();

        p.NonNull<int>();
        p.NonNull<Parent>();

        this.GetAllParents();
        "Sfds".Extending();
        //var ll = p.NullableValue<int>();
    }



    //public unsafe void MoveSo()
    //{
    //    fixed (int* p = stackalloc int[10])
    //    {
    //        *p = 5;
    //        var d = p + 1;
    //        *d = 10;
    //        var ls = sizeof(DateTime);
    //    }
    //}

    public void many()
    {
        var p = new Child(1, 2);
        if (typeof(Child) == p.GetType())
        {

        }

        ushort us = 32423;
        uint ui = 323243;
        ulong ul = 34243243;
        unchecked
        {
            ui = (uint)ul;
        }

        using (var ms = new MemoryStream())
        {

        }
    }

    private void _private() { }
    protected void _protec() { }
    internal void _intern() { }
    public void _pub() { }
    private protected void _priPro() { }
    protected internal void _proInter() { }

}

public class Ok
{

}
public enum Ayokya
{
    yok = 1,
    mak = 2
}




internal sealed class GenericClass : BaseGeneric
{
    public static void Member() { }
    public void DoSo<T, P>() where T : class?, new() where P : class, ITop { }

    // public void DoIt<T, P>() where T : struct ? where P : class? { }

    public void NonNull<T>() where T : notnull { }

    public void BaseClass<T>() where T : Parent { }

    public void NullabeInterface<T>() where T : ITop? { }

    public override void DoOverried<T>() where T : struct { }

    public void UnManaged<T>() where T : unmanaged { }

    //public T? NullableValue<T>() where T { return null; }

    public void OwnInheritance<T, U>() where T : U { }

}

internal class BaseGeneric
{
    public virtual void DoOverried<T>() where T : struct { }
}
public interface ITop
{

}

public struct MyStruct
{
    public int id { get; set; }
    public string name { get; set; }
}

public readonly record struct ReadonlyStruct(int id, string name);
public record class ClassStruct(int id, string name);

public static partial class Extenders
{
    public static string Extending(this string l)
    {
        return l + ("S");
    }
}
