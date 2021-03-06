﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOOP
{
    class Person
    {
        public string name;
        public int age;

        //public Person()
        //{
        //    this.Name = "Gosho";
        //    this.Age = 18;
        //}

        public Person() : this ("No name", 1)
        {
        }
        public Person(int age) : this ("No name", age)
        {
        }
        public Person(string name) : this (name, 1)
        {
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name  { get; set; }
        public int Age { get; set; }
    }
}
