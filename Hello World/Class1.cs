﻿using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using.System.Windows.Forms;namespace FormDemo{    static void Main(string[] args)    {u        System.Console.WriteLine("Hello World");        System.Console.Write("Please Enter your name: ");        string t= System.String(Console.ReadLine);        System.Console.WriteLine("Hello" + t);        System.Console.WriteLine("How old are you Peter:");        int age;        string s = System.Console.ReadLine();        if   (s.Contains("."))        {            double d = double.Parse(s);