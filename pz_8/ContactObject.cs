﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    internal abstract class ContactObject
    {
        public string Name { get; set; } // имя контакта
        public string Phone { get; set; } // телефон контакта

        public ContactObject(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public abstract void DisplayInfo(); // абстрактный метод для отображения информации о контакте
    }
}
