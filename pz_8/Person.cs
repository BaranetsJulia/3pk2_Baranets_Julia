﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    internal class Person : ContactObject
    {
        public string Address { get; set; } // адрес

        public Person(string name, string phone, string address) : base(name, phone)
        {
            Address = address;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Физическое лицо");
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Телефон: " + Phone);
            Console.WriteLine("Адрес: " + Address);
        }
    }
}
