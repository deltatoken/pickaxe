﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HtmlAgilityPack;
using Pickaxe.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;



public class Code : RuntimeBase
{

    private Scope_d7ad3f27782b41168d9901167e79d02e _Scope_d7ad3f27782b41168d9901167e79d02e;

    private Scope_be2cc53e1add485f8011b28c29e2a672 _Scope_be2cc53e1add485f8011b28c29e2a672;

    public Code()
    {
        _Scope_d7ad3f27782b41168d9901167e79d02e = new Scope_d7ad3f27782b41168d9901167e79d02e();
        _Scope_be2cc53e1add485f8011b28c29e2a672 = new Scope_be2cc53e1add485f8011b28c29e2a672();
        TotalOperations = (TotalOperations + 3);
    }

    public void Run()
    {
        InitProxies();
        Block_6ab85c351002407fb8e2d2ccf7a8865b();
        Step_e498f43f33a4433cb111bd550a6fde90();
    }

    public void Block_6ab85c351002407fb8e2d2ccf7a8865b()
    {
        Step_26ecfc555a7c4e819b4f5dca28bf6b84();
        Step_fc6a12ec4fb943f8a743faab9cbaa662();
        Step_4f58444996ba4a0aa60202a4a20ffd0c();
    }

    private Table<ResultRow> Select_21f758d05be64ce7bcfb5fbf82abd153()
    {
        Call(7);
        RuntimeTable<ResultRow> result = new RuntimeTable<ResultRow>();
        ResultRow resultRow = new ResultRow(2);
        resultRow[0] = 1;
        resultRow[1] = "a";
        result.Add(resultRow);
        return result;
    }

    private void Insert_4d08d049e9394e968a1d26af03e27e4d()
    {
        Call(6);
        Table<ResultRow> resultRows = Select_21f758d05be64ce7bcfb5fbf82abd153();
        _Scope_be2cc53e1add485f8011b28c29e2a672.a.BeforeInsert(false);
        _Scope_d7ad3f27782b41168d9901167e79d02e.g_identity = _Scope_be2cc53e1add485f8011b28c29e2a672.a.RowCount;
        IEnumerator<ResultRow> x = resultRows.GetEnumerator();
        for (
        ; x.MoveNext();
        )
        {
            _Scope_d7ad3f27782b41168d9901167e79d02e.g_identity = (_Scope_d7ad3f27782b41168d9901167e79d02e.g_identity + 1);
            ResultRow row = x.Current;
            a tableRow = new a();
            tableRow.id = Convert.ToInt32(row[0]);
            tableRow.name = Convert.ToString(row[1]);
            _Scope_be2cc53e1add485f8011b28c29e2a672.a.Add(tableRow);
        }
        _Scope_be2cc53e1add485f8011b28c29e2a672.a.AfterInsert();
    }

    public void Step_26ecfc555a7c4e819b4f5dca28bf6b84()
    {
        Insert_4d08d049e9394e968a1d26af03e27e4d();
        OnProgress();
    }

    private Table<ResultRow> Select_6c435ed405944f6c835ce342995d095c()
    {
        Call(10);
        RuntimeTable<ResultRow> result = new RuntimeTable<ResultRow>();
        ResultRow resultRow = new ResultRow(2);
        resultRow[0] = 1;
        resultRow[1] = "a";
        result.Add(resultRow);
        return result;
    }

    private void Insert_5d73364a1c744f7aa40c0b727c4dfeda()
    {
        Call(9);
        Table<ResultRow> resultRows = Select_6c435ed405944f6c835ce342995d095c();
        _Scope_be2cc53e1add485f8011b28c29e2a672.b.BeforeInsert(false);
        _Scope_d7ad3f27782b41168d9901167e79d02e.g_identity = _Scope_be2cc53e1add485f8011b28c29e2a672.b.RowCount;
        IEnumerator<ResultRow> x = resultRows.GetEnumerator();
        for (
        ; x.MoveNext();
        )
        {
            _Scope_d7ad3f27782b41168d9901167e79d02e.g_identity = (_Scope_d7ad3f27782b41168d9901167e79d02e.g_identity + 1);
            ResultRow row = x.Current;
            b tableRow = new b();
            tableRow.id = Convert.ToInt32(row[0]);
            tableRow.name = Convert.ToString(row[1]);
            _Scope_be2cc53e1add485f8011b28c29e2a672.b.Add(tableRow);
        }
        _Scope_be2cc53e1add485f8011b28c29e2a672.b.AfterInsert();
    }

    public void Step_fc6a12ec4fb943f8a743faab9cbaa662()
    {
        Insert_5d73364a1c744f7aa40c0b727c4dfeda();
        OnProgress();
    }

    private CodeTable<anon_b62088bced274539905c5fdeda21d3f7> From_203ea4eca60d49a9bc690301e9762d66()
    {
        Call(13);
        IEnumerable<anon_03f0817225b744fdb13fd1603872e105> join = Fetch_e39add920e4c46f4a13f9e58ae1e060f();
        return Join_d78377c0f1db45d3ad27a70b5c840869(join);
    }

    private IEnumerable<anon_03f0817225b744fdb13fd1603872e105> Fetch_e39add920e4c46f4a13f9e58ae1e060f()
    {
        CodeTable<a> table = _Scope_be2cc53e1add485f8011b28c29e2a672.a;
        return table.Select(o =>
        {
            return Copy_f37f29b34f5844b58a747a07b9c5b03d(o);
        });
    }

    private anon_03f0817225b744fdb13fd1603872e105 Copy_f37f29b34f5844b58a747a07b9c5b03d(a o)
    {
        anon_03f0817225b744fdb13fd1603872e105 t = new anon_03f0817225b744fdb13fd1603872e105();
        t.a = o;
        return t;
    }

    private CodeTable<anon_b62088bced274539905c5fdeda21d3f7> Join_d78377c0f1db45d3ad27a70b5c840869(IEnumerable<anon_03f0817225b744fdb13fd1603872e105> outer)
    {
        Call(14);
        IEnumerable<anon_159c8dddc6bb4b3aa52b8b104448827d> table = Fetch_a2b27545159c4973b66cb3d43ce5213e();
        IList<anon_b62088bced274539905c5fdeda21d3f7> join = new List<anon_b62088bced274539905c5fdeda21d3f7>();
        IEnumerator<anon_03f0817225b744fdb13fd1603872e105> o = outer.GetEnumerator();
        for (
        ; o.MoveNext();
        )
        {
            anon_03f0817225b744fdb13fd1603872e105 oc = o.Current;
            IEnumerator<anon_159c8dddc6bb4b3aa52b8b104448827d> i = table.GetEnumerator();
            for (
            ; i.MoveNext();
            )
            {
                anon_159c8dddc6bb4b3aa52b8b104448827d ic = i.Current;
                if ((oc.a.id == ic.b.id))
                {
                    anon_b62088bced274539905c5fdeda21d3f7 t = new anon_b62088bced274539905c5fdeda21d3f7();
                    t.a = oc.a;
                    t.b = ic.b;
                    join.Add(t);
                }
            }
        }
        CodeTable<anon_b62088bced274539905c5fdeda21d3f7> newTable = new CodeTable<anon_b62088bced274539905c5fdeda21d3f7>();
        newTable.SetRows(join.ToList());
        return newTable;
    }

    private IEnumerable<anon_159c8dddc6bb4b3aa52b8b104448827d> Fetch_a2b27545159c4973b66cb3d43ce5213e()
    {
        CodeTable<b> table = _Scope_be2cc53e1add485f8011b28c29e2a672.b;
        return table.Select(o =>
        {
            return Copy_cc374d5d0b6c4d059232c504a54951aa(o);
        });
    }

    private anon_159c8dddc6bb4b3aa52b8b104448827d Copy_cc374d5d0b6c4d059232c504a54951aa(b o)
    {
        anon_159c8dddc6bb4b3aa52b8b104448827d t = new anon_159c8dddc6bb4b3aa52b8b104448827d();
        t.b = o;
        return t;
    }

    private Table<ResultRow> Select_c3f7926e43b9440084c35831a79c2762()
    {
        Call(12);
        RuntimeTable<ResultRow> result = new RuntimeTable<ResultRow>();
        result.AddColumn("id");
        result.AddColumn("name");
        result.AddColumn("id");
        result.AddColumn("name");
        CodeTable<anon_b62088bced274539905c5fdeda21d3f7> fromTable = From_203ea4eca60d49a9bc690301e9762d66();
        IEnumerator<anon_b62088bced274539905c5fdeda21d3f7> x = fromTable.GetEnumerator();
        for (
        ; x.MoveNext();
        )
        {
            anon_b62088bced274539905c5fdeda21d3f7 row = x.Current;
            ResultRow resultRow = new ResultRow(4);
            resultRow[0] = row.a.id;
            resultRow[1] = row.a.name;
            resultRow[2] = row.b.id;
            resultRow[3] = row.b.name;
            if (((((resultRow[0] != null)
                        && (resultRow[1] != null))
                        && (resultRow[2] != null))
                        && (resultRow[3] != null)))
            {
                result.Add(resultRow);
            }
        }
        OnSelect(result);
        return result;
    }

    public void Step_4f58444996ba4a0aa60202a4a20ffd0c()
    {
        Select_c3f7926e43b9440084c35831a79c2762();
        OnProgress();
    }

    public void Step_e498f43f33a4433cb111bd550a6fde90()
    {
        OnProgress(new ProgressArgs(TotalOperations, TotalOperations));
    }

    private class Scope_d7ad3f27782b41168d9901167e79d02e
    {

        public int g_identity;

        public Scope_d7ad3f27782b41168d9901167e79d02e()
        {
        }
    }

    private class Scope_be2cc53e1add485f8011b28c29e2a672
    {

        public CodeTable<a> a;

        public CodeTable<b> b;

        public Scope_be2cc53e1add485f8011b28c29e2a672()
        {
            a = new BufferTable<a>();
            b = new BufferTable<b>();
        }
    }

    private class a : IRow
    {

        public int id;

        public string name;
    }

    private class b : IRow
    {

        public int id;

        public string name;
    }

    private class anon_03f0817225b744fdb13fd1603872e105 : IRow
    {

        public a a;
    }

    private class anon_159c8dddc6bb4b3aa52b8b104448827d : IRow
    {

        public b b;
    }

    private class anon_b62088bced274539905c5fdeda21d3f7 : IRow
    {

        public a a;

        public b b;
    }
}
