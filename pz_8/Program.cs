﻿using System;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван Иванов", "123-45-67", "ул. Пушкина, д. 10");
            School school = new School("Школа №1", "234-56-78", "ул. Лермонтова, д. 5", "Петров П.П.");


            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddContact(person);
            phoneBook.AddContact(school);

            phoneBook.DisplayContacts();
            Console.ReadLine();
        }
    }
}
